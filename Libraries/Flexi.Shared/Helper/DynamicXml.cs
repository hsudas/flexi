using System.Dynamic;
using System.Xml.Linq;
using System.Linq;

namespace Flexi.Shared.Helper
{

    public class DynamicXml : DynamicObject
    {
        private XElement _Root;

        private DynamicXml(XElement root)
        {
            _Root = root;
        }

        public static DynamicXml Parse(string xmlString)
        {
            if (xmlString == "")
            {
                return null;
            }
            return new DynamicXml(XDocument.Parse(xmlString.Replace("<br>", "")).Root);
        }

        public static DynamicXml Load(string filename)
        {
            return new DynamicXml(XDocument.Load(filename).Root);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;

            var att = _Root.Attribute(binder.Name);
            if (att != null)
            {
                result = att.Value;
                return true;
            }

            var nodes = _Root.Elements(binder.Name);
            if (nodes.Count() > 1)
            {
                result = nodes.Select(n => new DynamicXml(n)).ToList();
                return true;
            }

            var node = _Root.Element(binder.Name);
            if (node != null)
            {
                if (node.HasElements)
                {
                    result = new DynamicXml(node);
                }
                else
                {
                    result = node.Value;
                }
                return true;
            }

            return true;
        }
    }
}
