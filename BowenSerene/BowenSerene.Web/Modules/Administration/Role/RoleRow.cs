
namespace BowenSerene.Administration.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using Modules.Common.BaseClass;

    [ConnectionKey("Default"), DisplayName("Roles"), InstanceName("Role"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Security)]
    [ModifyPermission(PermissionKeys.Security)]
    [LookupScript("Administration.Role")]
    public sealed class RoleRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Role Id"), Identity, ForeignKey("Roles", "RoleId"), LeftJoin("jRole")]
        public Int32? RoleId
        {
            get { return Fields.RoleId[this]; }
            set { Fields.RoleId[this] = value; }
        }

        [NotNull, Insertable(false), Updatable(false), IgnoreAuditLog]
        [ForeignKey("[dbo].[Users]", "Id"), LeftJoin("jCreatedByUserDetails"), TextualField("CreatedByUserName")]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Role Name"), Size(100), NotNull, QuickSearch]
        public String RoleName
        {
            get { return Fields.RoleName[this]; }
            set { Fields.RoleName[this] = value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.RoleId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RoleName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RoleRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field RoleId;
            public StringField RoleName;

            public RowFields()
                : base("Roles")
            {
                LocalTextPrefix = "Administration.Role";
            }
        }
    }
}