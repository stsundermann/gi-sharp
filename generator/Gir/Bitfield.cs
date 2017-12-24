using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Bitfield
	{
        [XmlAttribute("deprecated")]
        public bool Deprecated;

        [XmlAttribute("deprecated-version")]
        public string DeprecatedVersion;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("version")]
        public string Version;

        [XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
        public string CType;

        [XmlAttribute("get-type", Namespace = "http://www.gtk.org/introspection/glib/1.0")]
        public string GLibGetType;

        [XmlAttribute("type-name", Namespace = "http://www.gtk.org/introspection/glib/1.0")]
        public string GLibTypeName;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("member")]
        public List<Member> Members;

        [XmlElement("function")]
        public List<Function> Function;
	}
}