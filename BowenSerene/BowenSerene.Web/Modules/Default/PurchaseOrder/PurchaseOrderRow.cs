
namespace BowenSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[PurchaseOrder]")]
    [DisplayName("Purchase Order"), InstanceName("Purchase Order"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchaseOrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Size(50), PrimaryKey, QuickSearch]
        public String Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("订单编号"), Size(50), NotNull]
        public String Number
        {
            get { return Fields.Number[this]; }
            set { Fields.Number[this] = value; }
        }

        [DisplayName("订单类型")]
        public Int32? Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        [DisplayName("分摊类型")]
        public Int32? ShareType
        {
            get { return Fields.ShareType[this]; }
            set { Fields.ShareType[this] = value; }
        }

        [DisplayName("状态")]
        public Int32? Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
        }

        [DisplayName("Is Pay")]
        public Int32? IsPay
        {
            get { return Fields.IsPay[this]; }
            set { Fields.IsPay[this] = value; }
        }

        [DisplayName("Delete Mark")]
        public Int32? DeleteMark
        {
            get { return Fields.DeleteMark[this]; }
            set { Fields.DeleteMark[this] = value; }
        }

        [DisplayName("采购员"), Size(50)]
        public String BuyUserId
        {
            get { return Fields.BuyUserId[this]; }
            set { Fields.BuyUserId[this] = value; }
        }

        [DisplayName("采购日期")]
        public DateTime? PurchaseDate
        {
            get { return Fields.PurchaseDate[this]; }
            set { Fields.PurchaseDate[this] = value; }
        }

        [DisplayName("Supplier Id"), Size(50)]
        public String SupplierId
        {
            get { return Fields.SupplierId[this]; }
            set { Fields.SupplierId[this] = value; }
        }

        [DisplayName("Supplier Number"), Size(50)]
        public String SupplierNumber
        {
            get { return Fields.SupplierNumber[this]; }
            set { Fields.SupplierNumber[this] = value; }
        }

        [DisplayName("Letter Number"), Size(50)]
        public String LetterNumber
        {
            get { return Fields.LetterNumber[this]; }
            set { Fields.LetterNumber[this] = value; }
        }

        [DisplayName("Estimate Total"), Size(20), Scale(2)]
        public Decimal? EstimateTotal
        {
            get { return Fields.EstimateTotal[this]; }
            set { Fields.EstimateTotal[this] = value; }
        }

        [DisplayName("Reckon Total"), Size(20), Scale(2)]
        public Decimal? ReckonTotal
        {
            get { return Fields.ReckonTotal[this]; }
            set { Fields.ReckonTotal[this] = value; }
        }

        [DisplayName("Total Size"), Size(20), Scale(3)]
        public Decimal? TotalSize
        {
            get { return Fields.TotalSize[this]; }
            set { Fields.TotalSize[this] = value; }
        }

        [DisplayName("Total Weight"), Size(20), Scale(2)]
        public Decimal? TotalWeight
        {
            get { return Fields.TotalWeight[this]; }
            set { Fields.TotalWeight[this] = value; }
        }

        [DisplayName("Total Volume"), Size(20), Scale(2)]
        public Decimal? TotalVolume
        {
            get { return Fields.TotalVolume[this]; }
            set { Fields.TotalVolume[this] = value; }
        }

        [DisplayName("Total Container")]
        public Int32? TotalContainer
        {
            get { return Fields.TotalContainer[this]; }
            set { Fields.TotalContainer[this] = value; }
        }

        [DisplayName("Total Buy Count")]
        public Int32? TotalBuyCount
        {
            get { return Fields.TotalBuyCount[this]; }
            set { Fields.TotalBuyCount[this] = value; }
        }

        [DisplayName("Total Piece Count")]
        public Int32? TotalPieceCount
        {
            get { return Fields.TotalPieceCount[this]; }
            set { Fields.TotalPieceCount[this] = value; }
        }

        [DisplayName("Notes"), Size(1000)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("Agent Number"), Size(1000)]
        public String AgentNumber
        {
            get { return Fields.AgentNumber[this]; }
            set { Fields.AgentNumber[this] = value; }
        }

        [DisplayName("Pay Way")]
        public Int32? PayWay
        {
            get { return Fields.PayWay[this]; }
            set { Fields.PayWay[this] = value; }
        }

        [DisplayName("Behalf"), Size(1000)]
        public String Behalf
        {
            get { return Fields.Behalf[this]; }
            set { Fields.Behalf[this] = value; }
        }

        [DisplayName("Ocean"), Size(20), Scale(2)]
        public Decimal? Ocean
        {
            get { return Fields.Ocean[this]; }
            set { Fields.Ocean[this] = value; }
        }

        [DisplayName("Description"), Size(1000)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Attachment")]
        public String Attachment
        {
            get { return Fields.Attachment[this]; }
            set { Fields.Attachment[this] = value; }
        }

        [DisplayName("Bill Lading Number"), Size(50)]
        public String BillLadingNumber
        {
            get { return Fields.BillLadingNumber[this]; }
            set { Fields.BillLadingNumber[this] = value; }
        }

        [DisplayName("Bill Lading Date")]
        public DateTime? BillLadingDate
        {
            get { return Fields.BillLadingDate[this]; }
            set { Fields.BillLadingDate[this] = value; }
        }

        [DisplayName("Arrival Date")]
        public DateTime? ArrivalDate
        {
            get { return Fields.ArrivalDate[this]; }
            set { Fields.ArrivalDate[this] = value; }
        }

        [DisplayName("Company Ship"), Size(50)]
        public String CompanyShip
        {
            get { return Fields.CompanyShip[this]; }
            set { Fields.CompanyShip[this] = value; }
        }

        [DisplayName("Port Depart"), Size(50)]
        public String PortDepart
        {
            get { return Fields.PortDepart[this]; }
            set { Fields.PortDepart[this] = value; }
        }

        [DisplayName("Port Dest"), Size(50)]
        public String PortDest
        {
            get { return Fields.PortDest[this]; }
            set { Fields.PortDest[this] = value; }
        }

        [DisplayName("Price Terms")]
        public Int32? PriceTerms
        {
            get { return Fields.PriceTerms[this]; }
            set { Fields.PriceTerms[this] = value; }
        }

        [DisplayName("Organize Id"), Size(50)]
        public String OrganizeId
        {
            get { return Fields.OrganizeId[this]; }
            set { Fields.OrganizeId[this] = value; }
        }

        [DisplayName("Insert User Id")]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Insert Date")]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Id; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Id;
            public StringField Number;
            public Int32Field Type;
            public Int32Field ShareType;
            public Int32Field Status;
            public Int32Field IsPay;
            public Int32Field DeleteMark;
            public StringField BuyUserId;
            public DateTimeField PurchaseDate;
            public StringField SupplierId;
            public StringField SupplierNumber;
            public StringField LetterNumber;
            public DecimalField EstimateTotal;
            public DecimalField ReckonTotal;
            public DecimalField TotalSize;
            public DecimalField TotalWeight;
            public DecimalField TotalVolume;
            public Int32Field TotalContainer;
            public Int32Field TotalBuyCount;
            public Int32Field TotalPieceCount;
            public StringField Notes;
            public StringField AgentNumber;
            public Int32Field PayWay;
            public StringField Behalf;
            public DecimalField Ocean;
            public StringField Description;
            public StringField Attachment;
            public StringField BillLadingNumber;
            public DateTimeField BillLadingDate;
            public DateTimeField ArrivalDate;
            public StringField CompanyShip;
            public StringField PortDepart;
            public StringField PortDest;
            public Int32Field PriceTerms;
            public StringField OrganizeId;
            public Int32Field InsertUserId;
            public DateTimeField InsertDate;
            public Int32Field UpdateUserId;
            public DateTimeField UpdateDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PurchaseOrder";
            }
        }
    }
}
