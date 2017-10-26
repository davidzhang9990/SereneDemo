
using BowenSerene.Administration.Entities;

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
    public sealed class PurchaseOrderDetailRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("明细Key"), PrimaryKey]
        public Guid? PurchaseOrderDetailId
        {
            get { return Fields.PurchaseOrderDetailId[this]; }
            set { Fields.PurchaseOrderDetailId[this] = value; }
        }

        [DisplayName("主表Key"), NotNull, ForeignKey("[dbo].[PurchaseOrder]", "PurchaseOrderId"), LeftJoin("jParent"), TextualField("ParentNumber")]
        public Guid? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("货柜号"), Size(50), NotNull, QuickSearch]
        public String Container
        {
            get { return Fields.Container[this]; }
            set { Fields.Container[this] = value; }
        }

        [DisplayName("荒料号"), Size(50), NotNull]
        public String BlockNumber
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("品目"), NotNull, ForeignKey("[dbo].[Products]", "ProductId"), LeftJoin("jProduct"), LookupInclude]
        [LookupEditor(typeof(ProductsRow), InplaceAdd = true)]
        public Guid? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("类别"), Size(50)]
        public String Category
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("矿口"), Size(50)]
        public String Mine
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("等级"), Size(50)]
        public String Grade
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("数量")]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("长")]
        public Int32? Length
        {
            get { return Fields.Length[this]; }
            set { Fields.Length[this] = value; }
        }

        [DisplayName("宽")]
        public Int32? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("高")]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("厚度"), Size(19), Scale(5)]
        public Decimal? Thick
        {
            get { return Fields.Thick[this]; }
            set { Fields.Thick[this] = value; }
        }

        [DisplayName("面积"), Size(19), Scale(5)]
        public Decimal? Size
        {
            get { return Fields.Size[this]; }
            set { Fields.Size[this] = value; }
        }

        [DisplayName("重量"), Size(19), Scale(5)]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("体积"), Size(19), Scale(5), Expression("(t0.[Length] * t0.[Width] *t0.[Height])")]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
        }

        [DisplayName("验收数量")]
        public Int32? AutoQuantity
        {
            get { return Fields.AutoQuantity[this]; }
            set { Fields.AutoQuantity[this] = value; }
        }

        [DisplayName("验收长度")]
        public Int32? AutoLength
        {
            get { return Fields.AutoLength[this]; }
            set { Fields.AutoLength[this] = value; }
        }

        [DisplayName("验收宽度")]
        public Int32? AutoWidth
        {
            get { return Fields.AutoWidth[this]; }
            set { Fields.AutoWidth[this] = value; }
        }

        [DisplayName("验收高度")]
        public Int32? AutoHeight
        {
            get { return Fields.AutoHeight[this]; }
            set { Fields.AutoHeight[this] = value; }
        }

        [DisplayName("验收面积"), Size(19), Scale(5)]
        public Decimal? AutoSize
        {
            get { return Fields.AutoSize[this]; }
            set { Fields.AutoSize[this] = value; }
        }

        [DisplayName("验收重量"), Size(19), Scale(5)]
        public Decimal? AutoWeight
        {
            get { return Fields.AutoWeight[this]; }
            set { Fields.AutoWeight[this] = value; }
        }

        [DisplayName("验收体积"), Size(19), Scale(5)]
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

        [DisplayName("完成面"), NotNull, ForeignKey("[dbo].[ProductFinishType]", "FinishTypeId"), LeftJoin("jFinishType"), LookupInclude]
        [LookupEditor(typeof(ProductFinishTypeRow), InplaceAdd = true)]
        public Guid? IsFinishType
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("备注"), Size(1000)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("排序")]
        public Int32? SortCode
        {
            get { return Fields.SortCode[this]; }
            set { Fields.SortCode[this] = value; }
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

        public class RowFields : LoggingRowFields
        {
            public GuidField PurchaseOrderDetailId;
            public GuidField ParentId;
            public StringField Container;
            public StringField BlockNumber;
            public GuidField ProductId;
            public StringField Category;
            public StringField Mine;
            public StringField Grade;
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


            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PurchaseOrderDetail";
            }
        }
    }
}
