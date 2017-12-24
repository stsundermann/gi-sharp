﻿using System;
using System.Xml.Serialization;

namespace Generator.Gir
{
    [XmlInclude(typeof(InstanceParameter))]
    public class Parameter
    {
        [XmlAttribute("allow-none")]
        public bool AllowNone;

        [XmlAttribute("caller-allocates")]
        public bool CallerAllocates;

        [XmlAttribute("closure")]
        public int Closure;

        [XmlAttribute("destroy")]
        public int Destroy;

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
