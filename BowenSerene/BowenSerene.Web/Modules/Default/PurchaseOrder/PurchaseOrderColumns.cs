
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
        [EditLink,AlignCenter]
        public String Number { get; set; }
        public Int16 Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public String SupplierName { get; set; }
        public Int16 Status { get; set; }
        public String Notes { get; set; }
    }
}