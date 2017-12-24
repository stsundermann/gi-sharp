using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Callback
	{
        [XmlAttribute("deprecated")]
        public bool Deprecated;

        [XmlAttribute("deprecated-version")]
        public string DeprecatedVersion;

        [XmlAttribute("introspectable")]
        public bool Introspectable;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("throws")]
        public bool Throws;

        [XmlAttribute("version")]
        public string Version;

        [XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
        public string CType;

        [XmlElement("parameter")]
        public List<Parameter> Parameters;

        [XmlElement("return-value")]
        public ReturnValue ReturnValue;
	}
}