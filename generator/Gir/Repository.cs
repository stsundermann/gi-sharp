using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Generator.Gir
{
	[Serializable]
	[XmlRoot("repository", Namespace = "http://www.gtk.org/introspection/core/1.0")]
	public class Repository
	{
		[XmlAttribute("version")]
		public string Version { get; set; }

		[XmlElement("include")]
		public List<Include> Includes { get; set; }

		[XmlElement("package")]
		public Package Package { get; set; }

		[XmlElement("include", Namespace = "http://www.gtk.org/introspection/c/1.0")]
		public CInclude CInclude { get; set; }

		[XmlElement("namespace")]
		public Namespace NameSpace { get; set; }
	}
}

