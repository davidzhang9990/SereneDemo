
namespace BowenSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[InspectionDetail]")]
    [DisplayName("Inspection Detail"), InstanceName("Inspection Detail"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class InspectionDetailRow : Row, IIdRow
    {
        [DisplayName("Inspection Detail Id"), Identity]
        public Int32? InspectionDetailId
        {
            get { return Fields.InspectionDetailId[this]; }
            set { Fields.InspectionDetailId[this] = value; }
        }

        [DisplayName("Parent"), NotNull, ForeignKey("[dbo].[Inspection]", "InspectId"), LeftJoin("jParent")]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("采购明细"), NotNull, ForeignKey("[dbo].[PurchaseOrderDetail]", "OrderDetailId"), LeftJoin("jOrderDetail"), TextualField("OrderDetailContainer")]
        public Int32? OrderDetailId
        {
            get { return Fields.OrderDetailId[this]; }
            set { Fields.OrderDetailId[this] = value; }
        }

        [DisplayName("货柜号"), Expression("jOrderDetail.[Container]")]
        public String Container
        {
            get { return Fields.Container[this]; }
            set { Fields.Container[this] = value; }
        }
        [DisplayName("荒料号"), Expression("jOrderDetail.[BlockNumber]")]
        public String BlockNumber
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("品目名"), NotMapped]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("品目"), Expression("jOrderDetail.[ProductId]")]
        [LookupEditor(typeof(ProductsRow))]
        public Guid? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }
        [DisplayName("数量"), Expression("jOrderDetail.[Quantity]")]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }
        [DisplayName("长"), Expression("jOrderDetail.[Length]")]
        public Int32? Length
        {
            get { return Fields.Length[this]; }
            set { Fields.Length[this] = value; }
        }
        [DisplayName("宽"), Expression("jOrderDetail.[Width]")]
        public Int32? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }
        [DisplayName("高"), Expression("jOrderDetail.[Height]")]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }
        [DisplayName("厚度"), Expression("jOrderDetail.[Thick]")]
        public Decimal? Thick
        {
            get { return Fields.Thick[this]; }
            set { Fields.Thick[this] = value; }
        }
        [DisplayName("面积"), Expression("jOrderDetail.[Size]")]
        public Decimal? Size
        {
            get { return Fields.Size[this]; }
            set { Fields.Size[this] = value; }
        }
        [DisplayName("重量"), Expression("jOrderDetail.[Weight]")]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }
        [DisplayName("体积"), Expression("jOrderDetail.[Volume]")]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
        }
        [DisplayName("验收数量"), Expression("jOrderDetail.[AutoQuantity]")]
        public Int32? AutoQuantity
        {
            get { return Fields.AutoQuantity[this]; }
            set { Fields.AutoQuantity[this] = value; }
        }
        [DisplayName("Order Detail Auto Length"), Expression("jOrderDetail.[AutoLength]")]
        public Int32? AutoLength
        {
            get { return Fields.AutoLength[this]; }
            set { Fields.AutoLength[this] = value; }
        }
        [DisplayName("Order Detail Auto Width"), Expression("jOrderDetail.[AutoWidth]")]
        public Int32? AutoWidth
        {
            get { return Fields.AutoWidth[this]; }
            set { Fields.AutoWidth[this] = value; }
        }
        [DisplayName("Order Detail Auto Height"), Expression("jOrderDetail.[AutoHeight]")]
        public Int32? AutoHeight
        {
            get { return Fields.AutoHeight[this]; }
            set { Fields.AutoHeight[this] = value; }
        }
        [DisplayName("Order Detail Auto Size"), Expression("jOrderDetail.[AutoSize]")]
        public Decimal? AutoSize
        {
            get { return Fields.AutoSize[this]; }
            set { Fields.AutoSize[this] = value; }
        }
        [DisplayName("Order Detail Auto Weight"), Expression("jOrderDetail.[AutoWeight]")]
        public Decimal? AutoWeight
        {
            get { return Fields.AutoWeight[this]; }
            set { Fields.AutoWeight[this] = value; }
        }
        [DisplayName("Order Detail Auto Volume"), Expression("jOrderDetail.[AutoVolume]")]
        public Decimal? AutoVolume
        {
            get { return Fields.AutoVolume[this]; }
            set { Fields.AutoVolume[this] = value; }
        }
        [DisplayName("Order Detail Is Stock"), Expression("jOrderDetail.[IsStock]")]
        public Int32? IsStock
        {
            get { return Fields.IsStock[this]; }
            set { Fields.IsStock[this] = value; }
        }
        [DisplayName("Order Detail Stock Date"), Expression("jOrderDetail.[StockDate]")]
        public DateTime? StockDate
        {
            get { return Fields.StockDate[this]; }
            set { Fields.StockDate[this] = value; }
        }
        [DisplayName("指派状态"), Expression("jOrderDetail.[IsAssign]")]
        public Int32? IsAssign
        {
            get { return Fields.IsAssign[this]; }
            set { Fields.IsAssign[this] = value; }
        }
        [DisplayName("指派日期"), Expression("jOrderDetail.[AssignDate]")]
        public DateTime? AssignDate
        {
            get { return Fields.AssignDate[this]; }
            set { Fields.AssignDate[this] = value; }
        }
        [DisplayName("验收状态"), Expression("jOrderDetail.[IsAssignOrder]")]
        public Int32? IsAssignOrder
        {
            get { return Fields.IsAssignOrder[this]; }
            set { Fields.IsAssignOrder[this] = value; }
        }
        [DisplayName("验收日期"), Expression("jOrderDetail.[AssignOrderDate]")]
        public DateTime? AssignOrderDate
        {
            get { return Fields.AssignOrderDate[this]; }
            set { Fields.AssignOrderDate[this] = value; }
        }
        [DisplayName("完成面"), Expression("jOrderDetail.[IsFinishType]")]
        public Int32? IsFinishType
        {
            get { return Fields.IsFinishType[this]; }
            set { Fields.IsFinishType[this] = value; }
        }
        [DisplayName("描述"), Expression("jOrderDetail.[Notes]")]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }
        [DisplayName("排序"), Expression("jOrderDetail.[SortCode]")]
        public Int32? SortCode
        {
            get { return Fields.SortCode[this]; }
            set { Fields.SortCode[this] = value; }
        }

        [DisplayName("类别"), Expression("jOrderDetail.[Category]")]
        public String Category
        {
            get { return Fields.Category[this]; }
            set { Fields.Category[this] = value; }
        }
        [DisplayName("矿口"), Expression("jOrderDetail.[Mine]")]
        public String Mine
        {
            get { return Fields.Mine[this]; }
            set { Fields.Mine[this] = value; }
        }
        [DisplayName("等级"), Expression("jOrderDetail.[Grade]")]
        public String Grade
        {
            get { return Fields.Grade[this]; }
            set { Fields.Grade[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.InspectionDetailId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InspectionDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field InspectionDetailId;
            public Int32Field ParentId;
            public Int32Field OrderDetailId;
            public StringField Container;
            public StringField BlockNumber;
            public GuidField ProductId;
            public StringField ProductName;
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
            public StringField Category;
            public StringField Mine;
            public StringField Grade;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.InspectionDetail";
            }
        }
    }
}
