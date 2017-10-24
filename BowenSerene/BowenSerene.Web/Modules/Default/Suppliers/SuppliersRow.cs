
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

    [ConnectionKey("Default"), TableName("[dbo].[Suppliers]")]
    [DisplayName("供应商列表"), InstanceName("供应商"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SuppliersRow : LoggingRow, IIdRow, INameRow, IIsActiveRow
    {
        [DisplayName("Supplier Id"), PrimaryKey]
        public Guid? SupplierId
        {
            get { return Fields.SupplierId[this]; }
            set { Fields.SupplierId[this] = value; }
        }

        [DisplayName("编号"), Size(100), NotNull, QuickSearch]
        public String Number
        {
            get { return Fields.Number[this]; }
            set { Fields.Number[this] = value; }
        }

        [DisplayName("名称"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("地区"), Size(100), NotNull]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("简称"), Size(100)]
        public String Suffix
        {
            get { return Fields.Suffix[this]; }
            set { Fields.Suffix[this] = value; }
        }

        [DisplayName("产地"), Size(100), NotNull]
        public String Place
        {
            get { return Fields.Place[this]; }
            set { Fields.Place[this] = value; }
        }

        [DisplayName("备注"), Size(1000)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("状态"), NotNull, DefaultValue(RowActive.Active), QuickFilter()]
        public RowActive? IsActive
        {
            get { return (RowActive?)Fields.IsActive[this]; }
            set { Fields.IsActive[this] = (Int16?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.SupplierId; }
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

        public SuppliersRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField SupplierId;
            public StringField Number;
            public StringField Name;
            public StringField Country;
            public StringField Suffix;
            public StringField Place;
            public StringField Notes;
            public Int16Field IsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Suppliers";
            }
        }
    }
}
