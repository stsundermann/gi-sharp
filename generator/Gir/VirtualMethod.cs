using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class VirtualMethod
	{
        [XmlAttribute("deprecated")]
        public bool Deprecated;

        [XmlAttribute("deprecated-version")]
        public string DeprecatedVersion;

        [XmlAttribute("introspectable")]
        public bool Introspectable;

        [XmlAttribute("invoker")]
        public string Invoker;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("throws")]
        public bool Throws;

        [XmlAttribute("version")]
        public string Version;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("return-value")]
        public ReturnValue ReturnValue;

        [XmlElement("parameter")]
        public List<Parameter> Parameters;

	}
}