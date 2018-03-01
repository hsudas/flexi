using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    public abstract class BaseEntity
    {
        //[DefaultValue(1)]
        [Column("status")]
        public int? Status { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateduser")]
        public string LastUpdatedUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("deleteuser")]
        public string DeleteUser { get; set; }
        [Column("deletedate")]
        public DateTime? DeleteDate { get; set; }

        public BaseEntity()
        {
            Status = 1;
        }
    }
}
