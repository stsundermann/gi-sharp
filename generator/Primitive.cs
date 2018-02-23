using System.ComponentModel;

namespace Generator
{
    public class Primitive : IType
    {
        public Primitive(string cType, string type, string defaultValue)
        {
            CType = cType;
            Type = type;
            DefaultValue = defaultValue;
        }
        
        public string CType { get; set; }

        public string Type;
        
        public string DefaultValue;
    }
}