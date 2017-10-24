
using BowenSerene.Administration.Entities;
using BowenSerene.Modules.Common.BaseClass;

namespace BowenSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Products]")]
    [DisplayName("品目列表"), InstanceName("品目"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProductsRow : LoggingRow, IIdRow, INameRow, IIsActiveRow
    {
        [DisplayName("Product Id"), PrimaryKey, Insertable(false), Updatable(false)]
        public Guid? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("编号"), Size(100), NotNull, QuickSearch]
        public String Number
        {
            get { return Fields.Number[this]; }
            set { Fields.Number[this] = value; }
        }

        [DisplayName("品名"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("密度"), Size(19), Scale(2), NotNull]
        public Decimal? Density
        {
            get { return Fields.Density[this]; }
            set { Fields.Density[this] = value; }
        }

        [DisplayName("产地"), Size(100), NotNull]
        public String Place
        {
            get { return Fields.Place[this]; }
            set { Fields.Place[this] = value; }
        }

        [DisplayName("附件"), Size(1000), MultipleImageUploadEditor(FilenameFormat = "Products/AttachImages/~")]
        public String Attach
        {
            get { return Fields.Attach[this]; }
            set { Fields.Attach[this] = value; }
        }

        [DisplayName("状态"), NotNull, DefaultValue(RowActive.Active),QuickFilter()]
        public RowActive? IsActive
        {
            get { return (RowActive?)Fields.IsActive[this]; }
            set { Fields.IsActive[this] = (Int16?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Number; }
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get { return Fields.IsActive; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductsRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField ProductId;
            public StringField Number;
            public StringField Name;
            public DecimalField Density;
            public StringField Place;
            public StringField Attach;
            public Int16Field IsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Products";
            }
        }
    }
}
