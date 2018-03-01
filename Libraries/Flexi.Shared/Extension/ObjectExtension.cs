using Flexi.Shared.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Flexi.Shared.Extension
{
    public static class ObjectExtension
    {
        public static string ToJson(this object value)
        {
            string json = JsonHelper.Instance.SerializeObject(value);
            return json;
        }

        public static string ToJsonWithoutNullValue(this object value)
        {
            string json = JsonHelper.Instance.SerializeObjectWithoutNullValue(value);
            return json;
        }

        public static string ToJson<T>(this T value)
        {
            string json = ServiceStack.Text.JsonSerializer.SerializeToString<T>(value);
            return json;
        }

        public static string ToXml<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var emptyNs = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                using (var writer = XmlWriter.Create(stringWriter, settings))
                {
                    xmlserializer.Serialize(writer, value, emptyNs);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ToXml, An error occurred", ex);
            }
        }

        public static string ToXmlWithXmlTag<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var emptyNs = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value, emptyNs);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ToXml, An error occurred", ex);
            }
        }

        public static Dictionary<string, string> ToDictionary(this object source)
        {
            var properties = source.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var result = properties.ToDictionary(propertyInfo => propertyInfo.Name, propertyInfo => propertyInfo.GetValue(source).ToString());
            return result;
        }
    }
}
