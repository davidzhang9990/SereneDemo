
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

    [ConnectionKey("Default"), TableName("[dbo].[ProductFinishType]")]
    [DisplayName("完成面"), InstanceName("类型"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.ProductFinishType")]
    public sealed class ProductFinishTypeRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Finish Type Id"), PrimaryKey]
        public Guid? FinishTypeId
        {
            get { return Fields.FinishTypeId[this]; }
            set { Fields.FinishTypeId[this] = value; }
        }

        [DisplayName("名称"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("排序")]
        public Int32? SortCode
        {
            get { return Fields.SortCode[this]; }
            set { Fields.SortCode[this] = value; }
        }
        [DisplayName("状态"), NotNull, DefaultValue(RowActive.Active), QuickFilter()]
        public RowActive? IsActive
        {
            get { return (RowActive?)Fields.IsActive[this]; }
            set { Fields.IsActive[this] = (Int16?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.FinishTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductFinishTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public GuidField FinishTypeId;
            public StringField Name;
            public Int32Field SortCode;
            public Int16Field IsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.ProductFinishType";
            }
        }
    }
}
