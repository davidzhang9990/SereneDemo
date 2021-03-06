﻿
namespace BowenSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.PurchaseOrderSlab")]
    [BasedOnRow(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderSlabColumns
    {
        [Width(120)]
        public Guid? ProductId { get; set; }
        [Width(100)]
        public String Category { get; set; }
        [Width(100)]
        public String Container { get; set; }
        [Width(100)]
        public String BlockNumber { get; set; }
        [Width(100)]
        public Int32 Length { get; set; }
        [Width(100)]
        public Int32 Width { get; set; }
        [Width(100)]
        public Decimal Thick { get; set; }
        [Width(100)]
        public Guid? IsFinishType { get; set; }
        [Width(100)]
        public Decimal Size { get; set; }
        [Width(100)]
        public String Mine { get; set; }
        [Width(100)]
        public String Grade { get; set; }
        [Width(120)]
        public String Notes { get; set; }
    }
}