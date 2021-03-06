﻿using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Array
	{
		[XmlAttribute("fixed-size")]
		public int FixedSize;

		[XmlAttribute("length")]
		public int Length;

		[XmlAttribute("name")]
		public string Name;

		[XmlAttribute("zero-terminated")]
		public bool ZeroTerminated;

		[XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
		public string CType;
	}
}