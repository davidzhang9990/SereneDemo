
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.PurchaseOrderDetail")]
    [BasedOnRow(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderDetailColumns
    {
        public String ProductNumber { get; set; }
        public String Container { get; set; }
        public String BlockNumber { get; set; }
        public Int32 Length { get; set; }
        public Int32 Width { get; set; }
        public Int32 Height { get; set; }
        public Decimal Thick { get; set; }
        public Decimal Size { get; set; }
        public Decimal Weight { get; set; }
        public Decimal Volume { get; set; }
        public Int32 IsFinishType { get; set; }
        public String Notes { get; set; }
    }
}