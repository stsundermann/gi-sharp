using System;
using System.Xml.Serialization;

namespace Generator.Gir
{
	[Serializable]
	public class Include
	{
		[XmlAttribute("name")]
		public string Name { get; set;}

		[XmlAttribute("version")]
		public string Version { get; set; }
	}
}