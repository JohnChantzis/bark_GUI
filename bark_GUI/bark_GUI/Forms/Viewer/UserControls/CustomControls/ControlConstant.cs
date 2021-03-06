﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Xml;

namespace bark_GUI.CustomControls
{
    public partial class ControlConstant : CustomControl
    {
        // Public Variables
        public override string Value
        {
            get { return textBoxValue.Text.Trim(); }
            set { textBoxValue.Text = value; }
        }

        public string DefaultUnit
        {
            get { return _defaultUnit; }
            set { _defaultUnit = value; SetUnit(value); }
        }

        public UnitChange UnitChange;

        // Private Variables
        private string _defaultUnit;

        // Constructor
        public ControlConstant(string name, List<string> typeOptions, List<string> unitOptions,
            bool isRequired, string help, GeneralControl generalControl)
            : base(name, isRequired, help, generalControl)
        {
            InitializeComponent();

            // Checks
            Debug.Assert(typeOptions != null, "Control_Constant for element {0} constructor argument typeOptions is null.", name);
            Debug.Assert(unitOptions != null, "Control_Constant for element {0} constructor argument unitOptions is null.", name);

            // Set name.
            labelName.Text = name.Trim();

            // Set possible types.
            foreach (string s in typeOptions)
                comboBoxType.Items.Add(s);

            // Since this is the control for 'Constant' type, have it selected.
            SelectConstant();

            // Visual candy.
            if (typeOptions.Count == 1)
                comboBoxType.Enabled = false;

            // Set unit.
            foreach (string s in unitOptions)
                comboBoxUnit.Items.Add(s);
            comboBoxUnit.SelectedIndex = 0;
            if (unitOptions.Count == 1)
                comboBoxUnit.Enabled = false;

            // Set help
            if (!string.IsNullOrEmpty(help))
                toolTipHelp.SetToolTip(labelName, help);

            // Red color if empty text box & required.
            textBoxValue_TextChanged(null, null);
        }







        /* PUBLIC METHODS */
        public override void SetValue(string value) { if (!string.IsNullOrEmpty(value)) textBoxValue.Text = value; }
        public override void SetUnit(string unit) { if (!string.IsNullOrEmpty(unit)) comboBoxUnit.Text = unit; }
        // Set the Control's name for the Element Viewer.
        public override void SetControlName(string name) { Name = name; labelName.Text = name; }
        public override bool HasNewValue()
        {
            // Check if the value is not empty and is not the default.
            var valueIsNew = !string.IsNullOrEmpty(textBoxValue.Text.Trim()) &&
                               (textBoxValue.Text.Trim() != DefaultValue);

            // Check if the unit is not empty and is not the default.
            var unitIsNew = !string.IsNullOrEmpty(comboBoxUnit.Text) &&
                               (comboBoxUnit.Text != DefaultUnit);

            // Return true if ANYTHING changed.
            return valueIsNew || unitIsNew;
        }
        public override void UpdateValues()
        {
            textBoxValue_TextChanged(null, null);
            comboBoxUnit_SelectedIndexChanged(null, null);
        }







        /* Apply Changes to the XmlDocument */

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            var value = textBoxValue.Text.Trim();

            //// Fix value. (starting zeros)
            //var fixedValue = value.TrimStart(new char[1] { '0' });
            //if (!string.IsNullOrEmpty(fixedValue))
            //    value = fixedValue;
            //else
            //    textBoxValue.Text = fixedValue;

            // Validation
            textBoxValue.ResetBackColor();
            textBoxValue.ResetForeColor();

            // Item Required Validation
            if (string.IsNullOrEmpty(value) && IsRequired)
                textBoxValue.BackColor = Color.Tomato;

            // SimpleType Validation
            if (Validator != null)
                IsValid = Validator(value);

            if (!IsValid)
            {
                textBoxValue.ForeColor = Color.Red;
                return;
            }
        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUnit.SelectedItem == null) return;

            var value = comboBoxUnit.SelectedItem.ToString().Trim();

            if (string.IsNullOrEmpty(value)) return;

            if (UnitChange != null)
                UnitChange(value);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Constant")
                return;
            GeneralControl.ReplaceWith(ConvertToCustomControl_Type(comboBoxType.SelectedItem.ToString()));
            SelectConstant();
        }






        /* PRIVATE UTILITY METHODS */

        private void SelectConstant()
        {
            for (int i = 0; i < comboBoxType.Items.Count; i++)
                if (comboBoxType.Items[i].ToString() == "Constant")
                    comboBoxType.SelectedIndex = i;
        }
    }
}
