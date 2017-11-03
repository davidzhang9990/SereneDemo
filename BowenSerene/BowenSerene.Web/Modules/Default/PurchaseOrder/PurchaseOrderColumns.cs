
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
        [EditLink, QuickFilter]
        public String Number { get; set; }
        [QuickFilter]
        public Int16 Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        [QuickFilter]
        public String SupplierName { get; set; }
        [QuickFilter]
        public Int16 Status { get; set; }
        public String Notes { get; set; }
    }
}