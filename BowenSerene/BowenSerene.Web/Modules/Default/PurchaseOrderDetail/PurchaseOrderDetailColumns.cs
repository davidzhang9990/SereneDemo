
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
        public String Id { get; set; }
        public String ParentId { get; set; }
        public String ContainerNumber { get; set; }
        public String BlockNumber { get; set; }
        public String ProNumber { get; set; }
        public String ProName { get; set; }
        public String ProType { get; set; }
        public String ProMine { get; set; }
        public String ProGrade { get; set; }
        public Decimal ProDensity { get; set; }
        public Int32 BuyCount { get; set; }
        public Int32 Length { get; set; }
        public Int32 Width { get; set; }
        public Int32 Height { get; set; }
        public Decimal Thick { get; set; }
        public Decimal Size { get; set; }
        public Decimal Weight { get; set; }
        public Decimal Volume { get; set; }
        public Int32 IsStock { get; set; }
        public DateTime StockDate { get; set; }
        public String WarehouseNumber { get; set; }
        public Int32 AutoBuyCount { get; set; }
        public Int32 AutoLength { get; set; }
        public Int32 AutoWidth { get; set; }
        public Int32 AutoHeight { get; set; }
        public Decimal AutoSize { get; set; }
        public Decimal AutoWeight { get; set; }
        public Decimal AutoVolume { get; set; }
        public String AutoGrade { get; set; }
        public Int32 IsFinishType { get; set; }
        public String Notes { get; set; }
        public Int32 SortCode { get; set; }
        public Int32 IsAssignOrder { get; set; }
        public DateTime AssignOrderDate { get; set; }
        public Int32 IsAssign { get; set; }
        public DateTime AssignDate { get; set; }
        public String AssignUserId { get; set; }
        public String AssignUserName { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}