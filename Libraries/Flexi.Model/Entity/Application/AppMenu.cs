using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace Flexi.Model.Application
{
    [Table("AppMenu")]
    public class AppMenu
    {
        [Key]
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Parent { get; set; }
        public int ApplicationId { get; set; }
    }
}
