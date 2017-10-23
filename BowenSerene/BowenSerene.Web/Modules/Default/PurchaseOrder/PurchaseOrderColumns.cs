
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.PurchaseOrder")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String Id { get; set; }
        public String Number { get; set; }
        public Int32 Type { get; set; }
        public Int32 ShareType { get; set; }
        public Int32 Status { get; set; }
        public String BuyUserId { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}