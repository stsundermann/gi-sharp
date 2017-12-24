using System.Xml.Serialization;

namespace Generator.Gir
{
    public enum TransferOwnership
    {
        [XmlEnum("full")]
        Full,
        [XmlEnum("none")]
        None,
        [XmlEnum("container")]
        Container,
        [XmlEnum("floating")]
        Floating
    }
}