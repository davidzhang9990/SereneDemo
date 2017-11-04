
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Inspection")]
    [BasedOnRow(typeof(Entities.InspectionRow))]
    public class InspectionColumns
    {
        [DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 InspectId { get; set; }
        [EditLink]
        public String ParentNumber { get; set; }
        [DisplayName("验货员")]
        public String UserUsername { get; set; }
        [DisplayName("创建日期")]
        public DateTime InsertDate { get; set; }
    }
}