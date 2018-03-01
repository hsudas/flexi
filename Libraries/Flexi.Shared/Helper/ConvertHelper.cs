using System;

namespace Flexi.Shared.Helper
{
    public class ConvertHelper
    {
        private static readonly Lazy<ConvertHelper> lazy = new Lazy<ConvertHelper>(() => new ConvertHelper());
        public static ConvertHelper Instance { get { return lazy.Value; } }
        private ConvertHelper()
        {
        }

        public Decimal? ConvertToDecimalNullable(string txt)
        {
            decimal val = 0;
            if (decimal.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }

        public Decimal ConvertToDecimal(string txt)
        {
            decimal val = 0;

            if (decimal.TryParse(txt, out val))
            {
                return val;
            }
            return val;
        }

        public int? ConvertToIntNullable(string txt)
        {
            int val = 0;
            if (int.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }

        public int ConvertToInt(string txt)
        {
            int val = 0;

            if (int.TryParse(txt, out val))
            {
                return val;
            }
            return val;
        }

        public long ConvertToLong(string txt)
        {
            long val = 0;

            if (long.TryParse(txt, out val))
            {
                return val;
            }
            return val;
        }

        public DateTime? ConvertToDateTimeNullable(string txt)
        {
            DateTime val;
            if (DateTime.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }
    }
}
