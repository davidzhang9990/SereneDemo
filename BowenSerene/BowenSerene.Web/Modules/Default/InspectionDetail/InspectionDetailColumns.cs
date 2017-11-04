
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.InspectionDetail")]
    [BasedOnRow(typeof(Entities.InspectionDetailRow))]
    public class InspectionDetailColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 InspectionDetailId { get; set; }
        public Int32 ParentId { get; set; }
        public String OrderDetailContainer { get; set; }
    }
}