
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    [Table("AppMenuRole")]
    public class AppMenuRole
    {
        [Key]
        public int MenuRoleId { get; set; }

        public int MenuId { get; set; }

        public string RoleId { get; set; }

    }
    [Table("AppMenuUser")]
    public class AppMenuUser
    {
        [Key]
        public long Id { get; set; }
        public string UserId { get; set; }

        public int MenuId { get; set; }

    }

}
