using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Function
	{
        [XmlAttribute("deprecated")]
        public bool Deprecated;

        [XmlAttribute("deprecated-version")]
        public string DeprecatedVersion;

        [XmlAttribute("introspectable")]
        public bool Introspectable;

        [XmlAttribute("moved-to")]
        public string MovedTo;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("shadowed-by")]
        public string ShadowedBy;

        [XmlAttribute("shadows")]
        public string Shadows;

        [XmlAttribute("throws")]
        public bool Throws;

        [XmlAttribute("version")]
        public string Version;

        [XmlAttribute("identifier", Namespace = "http://www.gtk.org/introspection/c/1.0")]
        public string CIdentifier;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("return-value")]
        public ReturnValue ReturnValue;

        [XmlElement("parameter")]
        public List<Parameter> Parameters;
	}
}