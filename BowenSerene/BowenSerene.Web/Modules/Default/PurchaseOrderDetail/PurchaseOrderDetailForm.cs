
namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.PurchaseOrderDetail")]
    [BasedOnRow(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderDetailForm
    {
        public Guid ParentId { get; set; }
        public String Container { get; set; }
        public String BlockNumber { get; set; }
        public Guid ProductId { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Length { get; set; }
        public Int32 Width { get; set; }
        public Int32 Height { get; set; }
        public Decimal Thick { get; set; }
        public Decimal Size { get; set; }
        public Decimal Weight { get; set; }
        public Decimal Volume { get; set; }
        public Int32 AutoQuantity { get; set; }
        public Int32 AutoLength { get; set; }
        public Int32 AutoWidth { get; set; }
        public Int32 AutoHeight { get; set; }
        public Decimal AutoSize { get; set; }
        public Decimal AutoWeight { get; set; }
        public Decimal AutoVolume { get; set; }
        public Int32 IsFinishType { get; set; }
        public String Notes { get; set; }
    }
}