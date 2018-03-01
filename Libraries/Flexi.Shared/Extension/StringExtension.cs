using Flexi.Shared.Helper;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Flexi.Shared.Extension
{
    public static class StringExtension
    {
        public static bool IsNull(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static string ToInitCap(this string value)
        {
            string fLetter = string.Empty;
            string remainingLetter = string.Empty;
            if (!string.IsNullOrEmpty(value))
            {
                fLetter = value.Substring(0, 1).ToUpper();
                if (value.Length > 1)
                {
                    remainingLetter = value.Substring(1, value.Length - 1).ToLower();
                }
            }
            return fLetter + remainingLetter;
        }

        public static string ToCamelCase(this string str, bool invariantCulture = true)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            if (str.Length == 1)
            {
                return invariantCulture ? str.ToLowerInvariant() : str.ToLower();
            }
            return (invariantCulture ? char.ToLowerInvariant(str[0]) : char.ToLower(str[0])) + str.Substring(1);
        }

        public static string ToPascalCase(this string str, bool invariantCulture = true)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }
            if (str.Length == 1)
            {
                return invariantCulture ? str.ToUpperInvariant() : str.ToUpper();
            }
            return (invariantCulture ? char.ToUpperInvariant(str[0]) : char.ToUpper(str[0])) + str.Substring(1);
        }

        // Output: This Is A String Test
        public static string ToProperCase(this string text)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(text);
        }

        public static string Truncate(this string str, int maxLength)
        {
            if (str == null)
            {
                return null;
            }
            if (str.Length <= maxLength)
            {
                return str;
            }
            return str.Left(maxLength);
        }

        public static string IfNullOrEmpty(this string str, string value)
        {
            if (string.IsNullOrEmpty(str))
            {
                str = value;
            }
            return str;
        }

        public static string Left(this string str, int len)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
            }
            if (str.Length < len)
            {
                throw new ArgumentException("len argument can not be bigger than given string's length!");
            }
            return str.Substring(0, len);
        }

        public static string RemoveLastCharacter(this String instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }

        public static string RemoveLast(this String instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }

        public static string RemoveFirstCharacter(this String str)
        {
            return str.Substring(1);
        }

        public static string RemoveFirst(this String instr, int number)
        {
            return instr.Substring(number);
        }

        public static string GetFirstCharacter(this String str, int number)
        {
            return str.Substring(str.Length - number);
        }

        public static string GetLastCharacter(this String str, int number)
        {
            return str.Substring(str.Length - number);
        }

        public static bool IsEmail(this string input)
        {
            var match = Regex.Match(input, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool IsPhone(this string input)
        {
            var match = Regex.Match(input, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool IsNumeric(this string input)
        {
            var match = Regex.Match(input, @"^[0-9]+$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool IsDate(this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                DateTime dt;
                return (DateTime.TryParse(input, out dt));
            }
            else
            {
                return false;
            }
        }

        public static bool IsBoolean(this Type type)
        {
            return type.Equals(typeof(Boolean));
        }

        public static string RemoveSpaces(this string s)
        {
            return s.Replace(" ", "");
        }

        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)System.Enum.Parse(typeof(T), value, true);
        }

        public static string StripHtml(this string input)
        {
            // Will this simple expression replace all tags???
            var tagsExpression = new Regex(@"</?.+?>");
            return tagsExpression.Replace(input, " ");
        }

        public static Exception ToException(this object o)
        {
            return new Exception(o.ToString());
        }

        public static void CreateDirectory(this DirectoryInfo dirInfo)
        {
            if (dirInfo.Parent != null) CreateDirectory(dirInfo.Parent);
            if (!dirInfo.Exists) dirInfo.Create();
        }

        public static bool ContainsAny(this string theString, char[] characters)
        {
            foreach (char character in characters)
            {
                if (theString.Contains(character.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public static T FromJson<T>(this string value)
        {
            return ServiceStack.Text.JsonSerializer.DeserializeFromString<T>(value);
        }

        public static T FromXml<T>(this string value)
        {
            return XmlHelper.Instance.Deserialize<T>(value);
        }

        public static string EncodeW1252(this string text)
        {
            byte[] bytes = System.Text.Encoding.Default.GetBytes(text);
            System.Text.Encoding w1252 = System.Text.Encoding.GetEncoding(1252);
            byte[] output = System.Text.Encoding.Convert(System.Text.Encoding.UTF8, w1252, bytes);
            string convertedText = w1252.GetString(output);
            return convertedText;
        }

        public static string HtmlEncode(this string text)
        {
            return System.Net.WebUtility.HtmlEncode(text);
        }

        public static string HtmlDecode(this string text)
        {
            return System.Net.WebUtility.HtmlDecode(text);
        }

        //public static string ToMd5(this string str)
        //{
        //    using (var md5 = MD5.Create())
        //    {
        //        var inputBytes = Encoding.UTF8.GetBytes(str);
        //        var hashBytes = md5.ComputeHash(inputBytes);

        //        var sb = new StringBuilder();
        //        foreach (var hashByte in hashBytes)
        //        {
        //            sb.Append(hashByte.ToString("X2"));
        //        }

        //        return sb.ToString();
        //    }
        //}
    }
}

