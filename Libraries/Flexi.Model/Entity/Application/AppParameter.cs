using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flexi.Model.Application
{
    [Table("appparameter")]
    public class AppParameter
    {
        [Key]
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public int InstitutionId { get; set; }
        public int Status { get; set; }

       
    }
}
