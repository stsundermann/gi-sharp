﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Signal
	{
        [XmlAttribute("action")]
        public string Action;

        [XmlAttribute("deprecated")]
        public bool Deprecated;

        [XmlAttribute("deprecated-version")]
        public string DeprecatedVersion;

        [XmlAttribute("detailed")]
        public bool Detailed;

        [XmlAttribute("introspectable")]
        public bool Introspectable;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("no-hooks")]
        public bool NoHooks;

        [XmlAttribute("no-recurse")]
        public bool NoRecurse;

        [XmlAttribute("version")]
        public string Version;

        [XmlAttribute("when")]
        public string When;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("return-value")]
        public ReturnValue ReturnValue;

        [XmlArray("parameters")]
        [XmlArrayItem("parameter", Type = typeof(Parameter))]
        [XmlArrayItem("instance-parameter", Type = typeof(InstanceParameter))]
        public List<Parameter> Parameters;

	}
}