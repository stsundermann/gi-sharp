using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Alias
	{
		[XmlAttribute("name")]
		public string Name;

		[XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
		public string CType;

		[XmlElement("doc")]
		public string Doc;

		[XmlElement("type")]
		public Type Type;
	}
}