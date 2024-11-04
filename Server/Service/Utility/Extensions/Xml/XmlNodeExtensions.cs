using System.Xml;
using System.Xml.Linq;

namespace Utility.Extensions.Xml
{
    public static class XmlNodeExtensions
    {
        public static XElement ToXElement(this XmlNode node)
        {
            return XElement.Parse(node.ToString());
        }
    }
}