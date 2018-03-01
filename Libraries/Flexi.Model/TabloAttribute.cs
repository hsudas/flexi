using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal.Model
{
    // TabloAttribute isimli niteliğimiz sadece sınıf veya yapılara uygulanabilecektir.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TabloAttribute : Attribute
    {
        private string _tabloAdi;
        private string _schemaAdi;

        public string TabloAdi
        {
            get { return _tabloAdi; }
            set { _tabloAdi = value; }
        }
        public string SchemaAdi
        {
            get { return _schemaAdi; }
            set { _schemaAdi = value; }
        }

        public TabloAttribute(string tablonunAdi, string schemaninAdi)
        {
            TabloAdi = tablonunAdi;
            SchemaAdi = schemaninAdi;
        }
        public TabloAttribute(string tablonunAdi)
            : this(tablonunAdi, "dbo")
        {
        }
        public TabloAttribute()
        {
        }
    }
}
