using System;
using System.Xml.Serialization;

namespace Generator.Gir
{
    public class ReturnValue
    {
        [XmlAttribute("nullable")]
        public bool Nullable;

        [XmlAttribute("transfer-ownership")]
        public TransferOwnership TransferOwnership;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("type")]
        public Type Type;
    }
}
