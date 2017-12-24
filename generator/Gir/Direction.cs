using System;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public enum Direction
	{
		[XmlEnum("out")]
		Out,
		[XmlEnum("in")]
		In,
		[XmlEnum("in-out")]
		InOut
	}
}

