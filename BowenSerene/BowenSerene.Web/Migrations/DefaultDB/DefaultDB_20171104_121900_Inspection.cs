using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171104121900)]
    public class DefaultDB_20171104_121900_Inspection : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Inspection", "InspectId", s => s
                 .WithColumn("ParentId").AsGuid().NotNullable()
                 .ForeignKey("FK_Inspection_PurchaseOrder_ParentId", "PurchaseOrder", "PurchaseOrderId")
                 .WithColumn("UserId").AsInt32().NotNullable()
                 .ForeignKey("FK_Inspection_Users_UserId", "Users", "UserId")
                 .WithColumn("InsertDate").AsDateTime().Nullable()
                 .WithColumn("InsertUserId").AsInt32().Nullable()
                 .WithColumn("UpdateDate").AsDateTime().Nullable()
                 .WithColumn("UpdateUserId").AsInt32().Nullable()
                 );

            this.CreateTableWithId32("InspectionDetail", "InspectionDetailId", s => s
                 .WithColumn("ParentId").AsInt32().NotNullable()
                 .ForeignKey("FK_Inspection_ParentId", "Inspection", "InspectId")
                 .WithColumn("OrderDetailId").AsInt32().NotNullable()
                 .ForeignKey("FK_Inspection_PurchaseOrderDetail_OrderDetailId", "PurchaseOrderDetail", "OrderDetailId"));
        }
    }

}