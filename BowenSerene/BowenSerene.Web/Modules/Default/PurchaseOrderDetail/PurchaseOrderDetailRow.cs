
namespace BowenSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[PurchaseOrderDetail]")]
    [DisplayName("Purchase Order Detail"), InstanceName("Purchase Order Detail"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchaseOrderDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Purchase Order Detail Id"), PrimaryKey]
        public Guid? PurchaseOrderDetailId
        {
            get { return Fields.PurchaseOrderDetailId[this]; }
            set { Fields.PurchaseOrderDetailId[this] = value; }
        }

        [DisplayName("Parent"), NotNull, ForeignKey("[dbo].[PurchaseOrder]", "PurchaseOrderId"), LeftJoin("jParent"), TextualField("ParentNumber")]
        public Guid? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Container"), Size(50), NotNull, QuickSearch]
        public String Container
        {
            get { return Fields.Container[this]; }
            set { Fields.Container[this] = value; }
        }

        [DisplayName("Block Number"), Size(50), NotNull]
        public String BlockNumber
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Products]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductNumber")]
        public Guid? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Quantity")]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Length")]
        public Int32? Length
        {
            get { return Fields.Length[this]; }
            set { Fields.Length[this] = value; }
        }

        [DisplayName("Width")]
        public Int32? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("Height")]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("Thick"), Size(19), Scale(5)]
        public Decimal? Thick
        {
            get { return Fields.Thick[this]; }
            set { Fields.Thick[this] = value; }
        }

        [DisplayName("Size"), Size(19), Scale(5)]
        public Decimal? Size
        {
            get { return Fields.Size[this]; }
            set { Fields.Size[this] = value; }
        }

        [DisplayName("Weight"), Size(19), Scale(5)]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("Volume"), Size(19), Scale(5)]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
        }

        [DisplayName("Auto Quantity")]
        public Int32? AutoQuantity
        {
            get { return Fields.AutoQuantity[this]; }
            set { Fields.AutoQuantity[this] = value; }
        }

        [DisplayName("Auto Length")]
        public Int32? AutoLength
        {
            get { return Fields.AutoLength[this]; }
            set { Fields.AutoLength[this] = value; }
        }

        [DisplayName("Auto Width")]
        public Int32? AutoWidth
        {
            get { return Fields.AutoWidth[this]; }
            set { Fields.AutoWidth[this] = value; }
        }

        [DisplayName("Auto Height")]
        public Int32? AutoHeight
        {
            get { return Fields.AutoHeight[this]; }
            set { Fields.AutoHeight[this] = value; }
        }

        [DisplayName("Auto Size"), Size(19), Scale(5)]
        public Decimal? AutoSize
        {
            get { return Fields.AutoSize[this]; }
            set { Fields.AutoSize[this] = value; }
        }

        [DisplayName("Auto Weight"), Size(19), Scale(5)]
        public Decimal? AutoWeight
        {
            get { return Fields.AutoWeight[this]; }
            set { Fields.AutoWeight[this] = value; }
        }

        [DisplayName("Auto Volume"), Size(19), Scale(5)]
        public Decimal? AutoVolume
        {
            get { return Fields.AutoVolume[this]; }
            set { Fields.AutoVolume[this] = value; }
        }

        [DisplayName("Is Stock")]
        public Int32? IsStock
        {
            get { return Fields.IsStock[this]; }
            set { Fields.IsStock[this] = value; }
        }

        [DisplayName("Stock Date")]
        public DateTime? StockDate
        {
            get { return Fields.StockDate[this]; }
            set { Fields.StockDate[this] = value; }
        }

        [DisplayName("Is Assign")]
        public Int32? IsAssign
        {
            get { return Fields.IsAssign[this]; }
            set { Fields.IsAssign[this] = value; }
        }

        [DisplayName("Assign Date")]
        public DateTime? AssignDate
        {
            get { return Fields.AssignDate[this]; }
            set { Fields.AssignDate[this] = value; }
        }

        [DisplayName("Is Assign Order")]
        public Int32? IsAssignOrder
        {
            get { return Fields.IsAssignOrder[this]; }
            set { Fields.IsAssignOrder[this] = value; }
        }

        [DisplayName("Assign Order Date")]
        public DateTime? AssignOrderDate
        {
            get { return Fields.AssignOrderDate[this]; }
            set { Fields.AssignOrderDate[this] = value; }
        }

        [DisplayName("Is Finish Type")]
        public Int32? IsFinishType
        {
            get { return Fields.IsFinishType[this]; }
            set { Fields.IsFinishType[this] = value; }
        }

        [DisplayName("Notes"), Size(1000)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("Sort Code")]
        public Int32? SortCode
        {
            get { return Fields.SortCode[this]; }
            set { Fields.SortCode[this] = value; }
        }

        [DisplayName("Insert Date")]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Insert User Id")]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Parent Number"), Expression("jParent.[Number]")]
        public String ParentNumber
        {
            get { return Fields.ParentNumber[this]; }
            set { Fields.ParentNumber[this] = value; }
        }
        [DisplayName("Parent Type"), Expression("jParent.[Type]")]
        public Int16? ParentType
        {
            get { return Fields.ParentType[this]; }
            set { Fields.ParentType[this] = value; }
        }
        [DisplayName("Parent Share Type"), Expression("jParent.[ShareType]")]
        public Int16? ParentShareType
        {
            get { return Fields.ParentShareType[this]; }
            set { Fields.ParentShareType[this] = value; }
        }
        [DisplayName("Parent Purchase Date"), Expression("jParent.[PurchaseDate]")]
        public DateTime? ParentPurchaseDate
        {
            get { return Fields.ParentPurchaseDate[this]; }
            set { Fields.ParentPurchaseDate[this] = value; }
        }
        [DisplayName("Parent Supplier Id"), Expression("jParent.[SupplierId]")]
        public Guid? ParentSupplierId
        {
            get { return Fields.ParentSupplierId[this]; }
            set { Fields.ParentSupplierId[this] = value; }
        }
        [DisplayName("Parent Letter Number"), Expression("jParent.[LetterNumber]")]
        public String ParentLetterNumber
        {
            get { return Fields.ParentLetterNumber[this]; }
            set { Fields.ParentLetterNumber[this] = value; }
        }
        [DisplayName("Parent Agent Number"), Expression("jParent.[AgentNumber]")]
        public String ParentAgentNumber
        {
            get { return Fields.ParentAgentNumber[this]; }
            set { Fields.ParentAgentNumber[this] = value; }
        }
        [DisplayName("Parent Pay Way"), Expression("jParent.[PayWay]")]
        public Int16? ParentPayWay
        {
            get { return Fields.ParentPayWay[this]; }
            set { Fields.ParentPayWay[this] = value; }
        }
        [DisplayName("Parent Behalf"), Expression("jParent.[Behalf]")]
        public String ParentBehalf
        {
            get { return Fields.ParentBehalf[this]; }
            set { Fields.ParentBehalf[this] = value; }
        }
        [DisplayName("Parent Bill Lading Number"), Expression("jParent.[BillLadingNumber]")]
        public String ParentBillLadingNumber
        {
            get { return Fields.ParentBillLadingNumber[this]; }
            set { Fields.ParentBillLadingNumber[this] = value; }
        }
        [DisplayName("Parent Bill Lading Date"), Expression("jParent.[BillLadingDate]")]
        public DateTime? ParentBillLadingDate
        {
            get { return Fields.ParentBillLadingDate[this]; }
            set { Fields.ParentBillLadingDate[this] = value; }
        }
        [DisplayName("Parent Arrival Date"), Expression("jParent.[ArrivalDate]")]
        public DateTime? ParentArrivalDate
        {
            get { return Fields.ParentArrivalDate[this]; }
            set { Fields.ParentArrivalDate[this] = value; }
        }
        [DisplayName("Parent Company Ship"), Expression("jParent.[CompanyShip]")]
        public String ParentCompanyShip
        {
            get { return Fields.ParentCompanyShip[this]; }
            set { Fields.ParentCompanyShip[this] = value; }
        }
        [DisplayName("Parent Port Depart"), Expression("jParent.[PortDepart]")]
        public String ParentPortDepart
        {
            get { return Fields.ParentPortDepart[this]; }
            set { Fields.ParentPortDepart[this] = value; }
        }
        [DisplayName("Parent Port Dest"), Expression("jParent.[PortDest]")]
        public String ParentPortDest
        {
            get { return Fields.ParentPortDest[this]; }
            set { Fields.ParentPortDest[this] = value; }
        }
        [DisplayName("Parent Price Terms"), Expression("jParent.[PriceTerms]")]
        public String ParentPriceTerms
        {
            get { return Fields.ParentPriceTerms[this]; }
            set { Fields.ParentPriceTerms[this] = value; }
        }
        [DisplayName("Parent Attachment"), Expression("jParent.[Attachment]")]
        public String ParentAttachment
        {
            get { return Fields.ParentAttachment[this]; }
            set { Fields.ParentAttachment[this] = value; }
        }
        [DisplayName("Parent Notes"), Expression("jParent.[Notes]")]
        public String ParentNotes
        {
            get { return Fields.ParentNotes[this]; }
            set { Fields.ParentNotes[this] = value; }
        }
        [DisplayName("Parent Status"), Expression("jParent.[Status]")]
        public Int16? ParentStatus
        {
            get { return Fields.ParentStatus[this]; }
            set { Fields.ParentStatus[this] = value; }
        }
        [DisplayName("Parent Insert Date"), Expression("jParent.[InsertDate]")]
        public DateTime? ParentInsertDate
        {
            get { return Fields.ParentInsertDate[this]; }
            set { Fields.ParentInsertDate[this] = value; }
        }
        [DisplayName("Parent Insert User Id"), Expression("jParent.[InsertUserId]")]
        public Int32? ParentInsertUserId
        {
            get { return Fields.ParentInsertUserId[this]; }
            set { Fields.ParentInsertUserId[this] = value; }
        }
        [DisplayName("Parent Update Date"), Expression("jParent.[UpdateDate]")]
        public DateTime? ParentUpdateDate
        {
            get { return Fields.ParentUpdateDate[this]; }
            set { Fields.ParentUpdateDate[this] = value; }
        }
        [DisplayName("Parent Update User Id"), Expression("jParent.[UpdateUserId]")]
        public Int32? ParentUpdateUserId
        {
            get { return Fields.ParentUpdateUserId[this]; }
            set { Fields.ParentUpdateUserId[this] = value; }
        }
        [DisplayName("Product Number"), Expression("jProduct.[Number]")]
        public String ProductNumber
        {
            get { return Fields.ProductNumber[this]; }
            set { Fields.ProductNumber[this] = value; }
        }
        [DisplayName("Product Name"), Expression("jProduct.[Name]")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }
        [DisplayName("Product Density"), Expression("jProduct.[Density]")]
        public Decimal? ProductDensity
        {
            get { return Fields.ProductDensity[this]; }
            set { Fields.ProductDensity[this] = value; }
        }
        [DisplayName("Product Place"), Expression("jProduct.[Place]")]
        public String ProductPlace
        {
            get { return Fields.ProductPlace[this]; }
            set { Fields.ProductPlace[this] = value; }
        }
        [DisplayName("Product Attach"), Expression("jProduct.[Attach]")]
        public String ProductAttach
        {
            get { return Fields.ProductAttach[this]; }
            set { Fields.ProductAttach[this] = value; }
        }
        [DisplayName("Product Is Active"), Expression("jProduct.[IsActive]")]
        public Int16? ProductIsActive
        {
            get { return Fields.ProductIsActive[this]; }
            set { Fields.ProductIsActive[this] = value; }
        }
        [DisplayName("Product Insert Date"), Expression("jProduct.[InsertDate]")]
        public DateTime? ProductInsertDate
        {
            get { return Fields.ProductInsertDate[this]; }
            set { Fields.ProductInsertDate[this] = value; }
        }
        [DisplayName("Product Insert User Id"), Expression("jProduct.[InsertUserId]")]
        public Int32? ProductInsertUserId
        {
            get { return Fields.ProductInsertUserId[this]; }
            set { Fields.ProductInsertUserId[this] = value; }
        }
        [DisplayName("Product Update Date"), Expression("jProduct.[UpdateDate]")]
        public DateTime? ProductUpdateDate
        {
            get { return Fields.ProductUpdateDate[this]; }
            set { Fields.ProductUpdateDate[this] = value; }
        }
        [DisplayName("Product Update User Id"), Expression("jProduct.[UpdateUserId]")]
        public Int32? ProductUpdateUserId
        {
            get { return Fields.ProductUpdateUserId[this]; }
            set { Fields.ProductUpdateUserId[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.PurchaseOrderDetailId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Container; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseOrderDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField PurchaseOrderDetailId;
            public GuidField ParentId;
            public StringField Container;
            public StringField BlockNumber;
            public GuidField ProductId;
            public Int32Field Quantity;
            public Int32Field Length;
            public Int32Field Width;
            public Int32Field Height;
            public DecimalField Thick;
            public DecimalField Size;
            public DecimalField Weight;
            public DecimalField Volume;
            public Int32Field AutoQuantity;
            public Int32Field AutoLength;
            public Int32Field AutoWidth;
            public Int32Field AutoHeight;
            public DecimalField AutoSize;
            public DecimalField AutoWeight;
            public DecimalField AutoVolume;
            public Int32Field IsStock;
            public DateTimeField StockDate;
            public Int32Field IsAssign;
            public DateTimeField AssignDate;
            public Int32Field IsAssignOrder;
            public DateTimeField AssignOrderDate;
            public Int32Field IsFinishType;
            public StringField Notes;
            public Int32Field SortCode;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;

            public StringField ParentNumber;
            public Int16Field ParentType;
            public Int16Field ParentShareType;
            public DateTimeField ParentPurchaseDate;
            public GuidField ParentSupplierId;
            public StringField ParentLetterNumber;
            public StringField ParentAgentNumber;
            public Int16Field ParentPayWay;
            public StringField ParentBehalf;
            public StringField ParentBillLadingNumber;
            public DateTimeField ParentBillLadingDate;
            public DateTimeField ParentArrivalDate;
            public StringField ParentCompanyShip;
            public StringField ParentPortDepart;
            public StringField ParentPortDest;
            public StringField ParentPriceTerms;
            public StringField ParentAttachment;
            public StringField ParentNotes;
            public Int16Field ParentStatus;
            public DateTimeField ParentInsertDate;
            public Int32Field ParentInsertUserId;
            public DateTimeField ParentUpdateDate;
            public Int32Field ParentUpdateUserId;

            public StringField ProductNumber;
            public StringField ProductName;
            public DecimalField ProductDensity;
            public StringField ProductPlace;
            public StringField ProductAttach;
            public Int16Field ProductIsActive;
            public DateTimeField ProductInsertDate;
            public Int32Field ProductInsertUserId;
            public DateTimeField ProductUpdateDate;
            public Int32Field ProductUpdateUserId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PurchaseOrderDetail";
            }
        }
    }
}
