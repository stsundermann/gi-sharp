using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Constant
	{
		[XmlAttribute("deprecated")]
		public bool Deprecated;

		[XmlAttribute("deprecated-version")]
		public string DeprecatedVersion;

		[XmlAttribute("name")]
		public string Name;

		[XmlAttribute("value")]
		public string Value;

		[XmlAttribute("version")]
		public string Version;

		[XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
		public string CType;

		[XmlElement("doc")]
		public string Doc;

		[XmlElement("type")]
		public Type Type;
	}
}