using System;
using System.Xml.Serialization;

namespace Generator.Gir
{
    public class Parameter
    {
        [XmlAttribute("allow-none")]
        public bool AllowNone;

        [XmlAttribute("caller-allocates")]
        public bool CallerAllocates;

        [XmlAttribute("closure")]
        public bool Closure;

        [XmlAttribute("destroy")]
        public bool Destroy;

        [XmlAttribute("direction")]
        public Direction Direction;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("nullable")]
        public bool Nullable;

        [XmlAttribute("optional")]
        public bool Optional;

        [XmlAttribute("skip")]
        public bool Skip;

        [XmlAttribute("transfer-ownership")]
        public TransferOwnership TransferOwnership;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("type")]
        public Type Type;
    }
}
