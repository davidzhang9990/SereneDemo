
using System.Collections.Generic;
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

    [ConnectionKey("Default"), TableName("[dbo].[Inspection]")]
    [DisplayName("验收单管理"), InstanceName("验收单"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class InspectionRow : LoggingRow, IIdRow
    {
        [DisplayName("Inspect Id"), Identity]
        public Int32? InspectId
        {
            get { return Fields.InspectId[this]; }
            set { Fields.InspectId[this] = value; }
        }

        [DisplayName("采购单"), NotNull, ForeignKey("[dbo].[PurchaseOrder]", "PurchaseOrderId"), LeftJoin("jParent"), TextualField("ParentNumber")]
        public Guid? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("验货人"), NotNull, ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUser"), TextualField("UserUsername")]
        [LookupEditor(typeof(UserRow))]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("采购单号"), Expression("jParent.[Number]")]
        public String ParentNumber
        {
            get { return Fields.ParentNumber[this]; }
            set { Fields.ParentNumber[this] = value; }
        }
        [DisplayName("采购类型"), Expression("jParent.[Type]")]
        public PurchaseType? ParentType
        {
            get { return (PurchaseType?)Fields.ParentType[this]; }
            set { Fields.ParentType[this] = (Int16?)value; }
        }
        [DisplayName("分摊类型"), Expression("jParent.[ShareType]")]
        public PurchaseShareType? ParentShareType
        {
            get { return (PurchaseShareType?)Fields.ParentShareType[this]; }
            set { Fields.ParentShareType[this] = (Int16?)value; }
        }
        [DisplayName("采购日期"), Expression("jParent.[PurchaseDate]")]
        public DateTime? ParentPurchaseDate
        {
            get { return Fields.ParentPurchaseDate[this]; }
            set { Fields.ParentPurchaseDate[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ParentId", IncludeColumns = "ProductId")]
        [DisplayName("明细"), NotMapped]
        public List<InspectionDetailRow> OrderDetailsList
        {
            get { return Fields.OrderDetailsList[this]; }
            set { Fields.OrderDetailsList[this] = value; }
        }

        [DisplayName("供应商"), Expression("jParent.[SupplierId]")]
        [LookupEditor(typeof(SuppliersRow))]
        public Guid? ParentSupplierId
        {
            get { return Fields.ParentSupplierId[this]; }
            set { Fields.ParentSupplierId[this] = value; }
        }
        [DisplayName("描述"), Expression("jParent.[Notes]")]
        public String ParentNotes
        {
            get { return Fields.ParentNotes[this]; }
            set { Fields.ParentNotes[this] = value; }
        }
        [DisplayName("制单人"), Expression("jParent.[InsertUserId]")]
        public Int32? ParentInsertUserId
        {
            get { return Fields.ParentInsertUserId[this]; }
            set { Fields.ParentInsertUserId[this] = value; }
        }
        [DisplayName("User Username"), Expression("jUser.[Username]")]
        public String UserUsername
        {
            get { return Fields.UserUsername[this]; }
            set { Fields.UserUsername[this] = value; }
        }
        [DisplayName("User Display Name"), Expression("jUser.[DisplayName]")]
        public String UserDisplayName
        {
            get { return Fields.UserDisplayName[this]; }
            set { Fields.UserDisplayName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.InspectId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InspectionRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field InspectId;
            public GuidField ParentId;
            public Int32Field UserId;
            public StringField ParentNumber;
            public Int16Field ParentType;
            public Int16Field ParentShareType;
            public DateTimeField ParentPurchaseDate;
            public RowListField<InspectionDetailRow> OrderDetailsList;
            public GuidField ParentSupplierId;
            public StringField ParentNotes;
            public Int32Field ParentInsertUserId;
            public StringField UserUsername;
            public StringField UserDisplayName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Inspection";
            }
        }
    }
}
