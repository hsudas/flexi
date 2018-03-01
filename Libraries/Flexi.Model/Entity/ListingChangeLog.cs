using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("listingchangelog")]
    public class ListingChangeLog
    {
        [Key]
        [Column("listingchangelogid")]
        public long ListingChangeLogId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("itemid")]
        public string ItemId { get; set; } // amazonda asin, walmart ta itemId
        [Column("projectname")]
        public string ProjectName { get; set; }
        [Column("tablename")]
        public string TableName { get; set; }
        [Column("changedcolumn")]
        public string ChangedColumn { get; set; }
        [Column("oldvalue")]
        public string OldValue { get; set; }
        [Column("newvalue")]
        public string NewValue { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        public ListingChangeLog()
        {
            Status = 1;
        }
    }
}
