
namespace BowenSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.PurchaseOrder")]
    [BasedOnRow(typeof(Entities.PurchaseOrderRow))]
    public class PurchaseOrderForm
    {
        public String Number { get; set; }
        public Int32 Type { get; set; }
        public Int32 ShareType { get; set; }
        public Int32 Status { get; set; }
        public Int32 IsPay { get; set; }
        public Int32 DeleteMark { get; set; }
        public String BuyUserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public String SupplierId { get; set; }
        public String SupplierNumber { get; set; }
        public String LetterNumber { get; set; }
        public Decimal EstimateTotal { get; set; }
        public Decimal ReckonTotal { get; set; }
        public Decimal TotalSize { get; set; }
        public Decimal TotalWeight { get; set; }
        public Decimal TotalVolume { get; set; }
        public Int32 TotalContainer { get; set; }
        public Int32 TotalBuyCount { get; set; }
        public Int32 TotalPieceCount { get; set; }
        public String Notes { get; set; }
        public String AgentNumber { get; set; }
        public Int32 PayWay { get; set; }
        public String Behalf { get; set; }
        public Decimal Ocean { get; set; }
        public String Description { get; set; }
        public String Attachment { get; set; }
        public String BillLadingNumber { get; set; }
        public DateTime BillLadingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public String CompanyShip { get; set; }
        public String PortDepart { get; set; }
        public String PortDest { get; set; }
        public Int32 PriceTerms { get; set; }
        public String OrganizeId { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}