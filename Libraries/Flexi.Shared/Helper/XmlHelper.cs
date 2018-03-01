using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Flexi.Shared.Helper
{
    public class XmlHelper
    {
        private static readonly Lazy<XmlHelper> lazy = new Lazy<XmlHelper>(() => new XmlHelper());
        public static XmlHelper Instance { get { return lazy.Value; } }
        private XmlHelper()
        {
        }

        public T Deserialize<T>(string xmlStr)
        {
            var serializer = new XmlSerializer(typeof(T));
            T result;
            using (TextReader reader = new StringReader(xmlStr))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }

        public T Deserialize2<T>(string data) where T : class, new()
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var sr = new StringReader(data))
            {
                return (T)xmlSerializer.Deserialize(sr);
            }
        }

        public string Serialize<T>(T obj)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(typeof(T), "UTF-8");
            serializer.Serialize(stringwriter, obj);
            return stringwriter.ToString();
        }

        public string Serialize<T>(T obj, XmlSerializerNamespaces ns)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, obj, ns);
            return stringwriter.ToString();
        }

        public string SerializeToString<T>(T value)
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(value.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, value, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
