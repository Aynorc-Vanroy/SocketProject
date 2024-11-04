using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Utility.Extensions.Xml
{
    public static class XElementExtensions
    {
        public static bool Exists(this IEnumerable<XElement> elements, string elementName)
        {
            return elements.Any(x => x.Name == elementName);
        }
    }
}