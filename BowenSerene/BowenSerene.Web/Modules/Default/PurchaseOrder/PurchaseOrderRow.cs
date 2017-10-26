
using System.Collections.Generic;
using BowenSerene.Administration.Entities;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

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
    [DisplayName("Purchase Order"), InstanceName("订单"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchaseOrderRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Purchase Order Id"), PrimaryKey]
        public Guid? PurchaseOrderId
        {
            get { return Fields.PurchaseOrderId[this]; }
            set { Fields.PurchaseOrderId[this] = value; }
        }

        [DisplayName("单号"), Size(100), NotNull, QuickSearch, Updatable(false)]
        public String Number
        {
            get { return Fields.Number[this]; }
            set { Fields.Number[this] = value; }
        }

        [DisplayName("类型"), NotNull, Width(120), Updatable(false)]
        public PurchaseType? Type
        {
            get { return (PurchaseType?)Fields.Type[this]; }
            set { Fields.Type[this] = (Int16?)value; }
        }

        [DisplayName("分摊类型"), NotNull, Width(120)]
        public PurchaseShareType? ShareType
        {
            get { return (PurchaseShareType?)Fields.ShareType[this]; }
            set { Fields.ShareType[this] = (Int16?)value; }
        }

        [DisplayName("采购日期"), NotNull, DefaultValue("now")]
        public DateTime? PurchaseDate
        {
            get { return Fields.PurchaseDate[this]; }
            set { Fields.PurchaseDate[this] = value; }
        }

        [DisplayName("供应商"), NotNull, ForeignKey(typeof(SuppliersRow), "SupplierId"), LeftJoin("jSupplier")]
        [LookupEditor(typeof(SuppliersRow), InplaceAdd = true)]
        public Guid? SupplierId
        {
            get { return Fields.SupplierId[this]; }
            set { Fields.SupplierId[this] = value; }
        }

        [Origin("jSupplier"), DisplayName("供应商名称"), QuickSearch]
        public String SupplierName
        {
            get { return Fields.SupplierName[this]; }
            set { Fields.SupplierName[this] = value; }
        }

        [DisplayName("Supplier Suffix"), Expression("jSupplier.[Suffix]")]
        public String SupplierSuffix
        {
            get { return Fields.SupplierSuffix[this]; }
            set { Fields.SupplierSuffix[this] = value; }
        }

        [DisplayName("信用证号"), Size(100)]
        public String LetterNumber
        {
            get { return Fields.LetterNumber[this]; }
            set { Fields.LetterNumber[this] = value; }
        }

        [DisplayName("进口代理"), Size(100)]
        public String AgentNumber
        {
            get { return Fields.AgentNumber[this]; }
            set { Fields.AgentNumber[this] = value; }
        }

        [DisplayName("付款方式"), NotNull]
        public PurchasePayWay? PayWay
        {
            get { return (PurchasePayWay?)Fields.PayWay[this]; }
            set { Fields.PayWay[this] = (Int16?)value; }
        }

        [DisplayName("贷代"), Size(100)]
        public String Behalf
        {
            get { return Fields.Behalf[this]; }
            set { Fields.Behalf[this] = value; }
        }

        [DisplayName("提单号"), Size(100)]
        public String BillLadingNumber
        {
            get { return Fields.BillLadingNumber[this]; }
            set { Fields.BillLadingNumber[this] = value; }
        }

        [DisplayName("提单日期")]
        public DateTime? BillLadingDate
        {
            get { return Fields.BillLadingDate[this]; }
            set { Fields.BillLadingDate[this] = value; }
        }

        [DisplayName("预计到货")]
        public DateTime? ArrivalDate
        {
            get { return Fields.ArrivalDate[this]; }
            set { Fields.ArrivalDate[this] = value; }
        }

        [DisplayName("船公司"), Size(100)]
        public String CompanyShip
        {
            get { return Fields.CompanyShip[this]; }
            set { Fields.CompanyShip[this] = value; }
        }

        [DisplayName("启运港"), Size(100)]
        public String PortDepart
        {
            get { return Fields.PortDepart[this]; }
            set { Fields.PortDepart[this] = value; }
        }

        [DisplayName("目的港"), Size(100)]
        public String PortDest
        {
            get { return Fields.PortDest[this]; }
            set { Fields.PortDest[this] = value; }
        }

        [DisplayName("价格条款"), Size(100)]
        public String PriceTerms
        {
            get { return Fields.PriceTerms[this]; }
            set { Fields.PriceTerms[this] = value; }
        }

        [DisplayName("附件"), Size(1000), MultipleImageUploadEditor(FilenameFormat = "PurchaseOrder/AttachImages/~")]
        public String Attachment
        {
            get { return Fields.Attachment[this]; }
            set { Fields.Attachment[this] = value; }
        }

        [DisplayName("描述"), Size(1000)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("状态"), NotNull]
        public Int16? Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PurchaseOrderId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Number; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField PurchaseOrderId;
            public StringField Number;
            public Int16Field Type;
            public Int16Field ShareType;
            public DateTimeField PurchaseDate;
            public GuidField SupplierId;
            public StringField LetterNumber;
            public StringField AgentNumber;
            public Int16Field PayWay;
            public StringField Behalf;
            public StringField BillLadingNumber;
            public DateTimeField BillLadingDate;
            public DateTimeField ArrivalDate;
            public StringField CompanyShip;
            public StringField PortDepart;
            public StringField PortDest;
            public StringField PriceTerms;
            public StringField Attachment;
            public StringField Notes;
            public Int16Field Status;

            public StringField SupplierName;
            public StringField SupplierSuffix;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PurchaseOrder";
            }
        }
    }
}
