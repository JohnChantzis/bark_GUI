﻿namespace bark_GUI.Structure.ItemTypes
{
    class ItemType
    {
        /* INHERiTING VARIABLES */
        public string Name;

        /* INHERiTING METHODS */
        public bool IsComplexType() { return (GetType() == typeof (ComplexType)); }
        public bool IsSimpleType() { return (GetType() == typeof(SimpleType)); }
    }
}
