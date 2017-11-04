
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 InspectId { get; set; }
        public String ParentNumber { get; set; }
        public String UserUsername { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
    }
}