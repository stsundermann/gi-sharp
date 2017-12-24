using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Package
	{
		[XmlAttribute("name")]
		public string Name { get; set; }
	}
}