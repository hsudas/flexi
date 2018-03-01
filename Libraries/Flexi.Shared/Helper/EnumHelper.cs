using Flexi.Shared.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flexi.Shared.Helper
{
    public class EnumHelper
    {
        private static readonly Lazy<EnumHelper> lazy = new Lazy<EnumHelper>(() => new EnumHelper());
        public static EnumHelper Instance { get { return lazy.Value; } }
        private EnumHelper()
        {
        }

        public List<string> GetListOfName<T>() where T : struct
        {
            Type t = typeof(T);
            return !t.IsEnum ? null : Enum.GetValues(t).Cast<Enum>().Select(x => x.ToString()).ToList();
        }

        public static List<string> GetListOfDescription<T>() where T : struct
        {
            Type t = typeof(T);
            return !t.IsEnum ? null : Enum.GetValues(t).Cast<Enum>().Select(x => x.GetDescription()).ToList();
        }

        //public string Serialize<T>(T value)
        //{
        //    var fallback = Enum.GetName(typeof(T), value);
        //    var member = typeof(T).GetMember(value.ToString()).FirstOrDefault();
        //    if (member == null)
        //        return fallback;
        //    var enumMemberAttributes = member.GetCustomAttributes(typeof(EnumMemberAttribute), false).Cast<EnumMemberAttribute>().FirstOrDefault();
        //    if (enumMemberAttributes == null)
        //        return fallback;
        //    return enumMemberAttributes.Value;
        //}
    }
}
