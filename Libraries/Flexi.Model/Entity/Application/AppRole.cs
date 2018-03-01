﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    [Table("AspNetRoles")]
    public class AspNetRoles
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

    }

}
