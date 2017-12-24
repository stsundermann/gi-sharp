﻿using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Type
	{
		[XmlAttribute("name")]
		public string Name;

		[XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
		public string CType;

		[XmlElement("array")]
		public Array Array;
	}
}