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

    [ColumnsScript("Default.PurchaseOrderDetail")]
    [BasedOnRow(typeof(Entities.PurchaseOrderDetailRow))]
    public class PurchaseOrderDetailColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid PurchaseOrderDetailId { get; set; }
        public String ParentNumber { get; set; }
        [EditLink]
        public String Container { get; set; }
        public String BlockNumber { get; set; }
        public String ProductNumber { get; set; }
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
        public Int32 IsStock { get; set; }
        public DateTime StockDate { get; set; }
        public Int32 IsAssign { get; set; }
        public DateTime AssignDate { get; set; }
        public Int32 IsAssignOrder { get; set; }
        public DateTime AssignOrderDate { get; set; }
        public Int32 IsFinishType { get; set; }
        public String Notes { get; set; }
        public Int32 SortCode { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int32 UpdateUserId { get; set; }
    }
}