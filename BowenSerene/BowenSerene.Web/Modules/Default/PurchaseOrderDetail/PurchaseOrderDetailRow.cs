
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
        [DisplayName("Id"), Size(50), PrimaryKey, QuickSearch]
        public String Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Parent Id"), Size(50), NotNull]
        public String ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Container Number"), Size(50)]
        public String ContainerNumber
        {
            get { return Fields.ContainerNumber[this]; }
            set { Fields.ContainerNumber[this] = value; }
        }

        [DisplayName("Block Number"), Size(50)]
        public String BlockNumber
        {
            get { return Fields.BlockNumber[this]; }
            set { Fields.BlockNumber[this] = value; }
        }

        [DisplayName("Pro Number"), Size(50)]
        public String ProNumber
        {
            get { return Fields.ProNumber[this]; }
            set { Fields.ProNumber[this] = value; }
        }

        [DisplayName("Pro Name"), Size(50)]
        public String ProName
        {
            get { return Fields.ProName[this]; }
            set { Fields.ProName[this] = value; }
        }

        [DisplayName("Pro Type"), Size(50)]
        public String ProType
        {
            get { return Fields.ProType[this]; }
            set { Fields.ProType[this] = value; }
        }

        [DisplayName("Pro Mine"), Size(50)]
        public String ProMine
        {
            get { return Fields.ProMine[this]; }
            set { Fields.ProMine[this] = value; }
        }

        [DisplayName("Pro Grade"), Size(50)]
        public String ProGrade
        {
            get { return Fields.ProGrade[this]; }
            set { Fields.ProGrade[this] = value; }
        }

        [DisplayName("Pro Density"), Size(20), Scale(2)]
        public Decimal? ProDensity
        {
            get { return Fields.ProDensity[this]; }
            set { Fields.ProDensity[this] = value; }
        }

        [DisplayName("Buy Count")]
        public Int32? BuyCount
        {
            get { return Fields.BuyCount[this]; }
            set { Fields.BuyCount[this] = value; }
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

        [DisplayName("Thick"), Size(20), Scale(2)]
        public Decimal? Thick
        {
            get { return Fields.Thick[this]; }
            set { Fields.Thick[this] = value; }
        }

        [DisplayName("Size"), Size(20), Scale(3)]
        public Decimal? Size
        {
            get { return Fields.Size[this]; }
            set { Fields.Size[this] = value; }
        }

        [DisplayName("Weight"), Size(20), Scale(2)]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("Volume"), Size(20), Scale(2)]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
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

        [DisplayName("Warehouse Number"), Size(50)]
        public String WarehouseNumber
        {
            get { return Fields.WarehouseNumber[this]; }
            set { Fields.WarehouseNumber[this] = value; }
        }

        [DisplayName("Auto Buy Count")]
        public Int32? AutoBuyCount
        {
            get { return Fields.AutoBuyCount[this]; }
            set { Fields.AutoBuyCount[this] = value; }
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

        [DisplayName("Auto Size"), Size(20), Scale(3)]
        public Decimal? AutoSize
        {
            get { return Fields.AutoSize[this]; }
            set { Fields.AutoSize[this] = value; }
        }

        [DisplayName("Auto Weight"), Size(20), Scale(2)]
        public Decimal? AutoWeight
        {
            get { return Fields.AutoWeight[this]; }
            set { Fields.AutoWeight[this] = value; }
        }

        [DisplayName("Auto Volume"), Size(20), Scale(2)]
        public Decimal? AutoVolume
        {
            get { return Fields.AutoVolume[this]; }
            set { Fields.AutoVolume[this] = value; }
        }

        [DisplayName("Auto Grade"), Size(50)]
        public String AutoGrade
        {
            get { return Fields.AutoGrade[this]; }
            set { Fields.AutoGrade[this] = value; }
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

        [DisplayName("Assign User Id"), Size(50)]
        public String AssignUserId
        {
            get { return Fields.AssignUserId[this]; }
            set { Fields.AssignUserId[this] = value; }
        }

        [DisplayName("Assign User Name"), Size(50)]
        public String AssignUserName
        {
            get { return Fields.AssignUserName[this]; }
            set { Fields.AssignUserName[this] = value; }
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

        public PurchaseOrderDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Id;
            public StringField ParentId;
            public StringField ContainerNumber;
            public StringField BlockNumber;
            public StringField ProNumber;
            public StringField ProName;
            public StringField ProType;
            public StringField ProMine;
            public StringField ProGrade;
            public DecimalField ProDensity;
            public Int32Field BuyCount;
            public Int32Field Length;
            public Int32Field Width;
            public Int32Field Height;
            public DecimalField Thick;
            public DecimalField Size;
            public DecimalField Weight;
            public DecimalField Volume;
            public Int32Field IsStock;
            public DateTimeField StockDate;
            public StringField WarehouseNumber;
            public Int32Field AutoBuyCount;
            public Int32Field AutoLength;
            public Int32Field AutoWidth;
            public Int32Field AutoHeight;
            public DecimalField AutoSize;
            public DecimalField AutoWeight;
            public DecimalField AutoVolume;
            public StringField AutoGrade;
            public Int32Field IsFinishType;
            public StringField Notes;
            public Int32Field SortCode;
            public Int32Field IsAssignOrder;
            public DateTimeField AssignOrderDate;
            public Int32Field IsAssign;
            public DateTimeField AssignDate;
            public StringField AssignUserId;
            public StringField AssignUserName;
            public Int32Field InsertUserId;
            public DateTimeField InsertDate;
            public Int32Field UpdateUserId;
            public DateTimeField UpdateDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PurchaseOrderDetail";
            }
        }
    }
}
