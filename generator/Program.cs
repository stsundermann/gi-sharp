using System;
using System.Xml.Serialization;
using System.Xml;

using Generator.Gir;

namespace Generator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var serializer = new XmlSerializer(typeof(Repository));

            using (var reader = XmlReader.Create(args[0]))
			{
				var repository = (Repository)serializer.Deserialize(reader);

				repository.GenerateNamespace();
			}
		}
	}
}
