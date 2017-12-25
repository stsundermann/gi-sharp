using System.Collections.Generic;
using System.Xml.Serialization;

namespace Generator.Gir
{
	public class Union
	{
        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("type", Namespace = "http://www.gtk.org/introspection/c/1.0")]
        public string CType;

        [XmlElement("doc")]
        public string Doc;

        [XmlElement("field")]
        public List<Field> Fields;

        [XmlElement("method")]
        public List<Method> Methods;

		[XmlElement("record")]
		public List<Record> Records;
	}
}