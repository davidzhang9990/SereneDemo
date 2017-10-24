using System;
using FluentMigrator;

namespace BowenSerene.Migrations.DefaultDB
{
    [Migration(20171024123200)]
    public class DefaultDB_20171024_123200_PurchaseOrder : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("PurchaseOrder")
                .WithColumn("PurchaseOrderId").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Number").AsString(100).NotNullable()
                .WithColumn("Type").AsInt16().NotNullable()
                .WithColumn("ShareType").AsInt16().NotNullable()
                .WithColumn("PurchaseDate").AsDateTime().NotNullable()
                .WithColumn("SupplierId").AsGuid().NotNullable()
                .ForeignKey("FK_PurchaseOrder_SupplierId", "Suppliers", "SupplierId")
                .WithColumn("LetterNumber").AsString(100).Nullable()
                 .WithColumn("AgentNumber").AsString(100).Nullable()
                  .WithColumn("PayWay").AsInt16().NotNullable()
                  .WithColumn("AgentNumber").AsString(100).Nullable()
                  .WithColumn("Behalf").AsString(100).Nullable()
                   .WithColumn("BillLadingNumber").AsString(100).Nullable()
                    .WithColumn("BillLadingDate").AsDateTime().Nullable()
                     .WithColumn("ArrivalDate").AsDateTime().Nullable()
                    .WithColumn("CompanyShip").AsString(100).Nullable()
                    .WithColumn("PortDepart").AsString(100).Nullable()
                     .WithColumn("PortDest").AsString(100).Nullable()
                     .WithColumn("PriceTerms").AsString(100).Nullable()
                      .WithColumn("Attachment").AsString(1000).Nullable()
                     .WithColumn("Notes").AsString(1000).Nullable()
                     .WithColumn("Status").AsInt16().NotNullable()
                     .WithColumn("InsertDate").AsDateTime().Nullable()
                     .WithColumn("InsertUserId").AsInt32().Nullable()
                     .WithColumn("UpdateDate").AsDateTime().Nullable()
                     .WithColumn("UpdateUserId").AsInt32().Nullable();

            Create.Table("PurchaseOrderDetail")
             .WithColumn("PurchaseOrderDetailId").AsGuid().PrimaryKey().NotNullable()
             .WithColumn("ParentId").AsGuid().NotNullable()
             .ForeignKey("FK_PurchaseOrder_ParentId", "PurchaseOrder", "PurchaseOrderId")
             .WithColumn("Container").AsString(50).NotNullable()
             .WithColumn("BlockNumber").AsString(50).NotNullable()
             .WithColumn("ProductId").AsGuid().NotNullable()
             .ForeignKey("FK_PurchaseOrder_ProductId", "Products", "ProductId")
             .WithColumn("Quantity").AsInt32().Nullable().WithDefaultValue(1)
             .WithColumn("Length").AsInt32().Nullable().WithDefaultValue(0)
             .WithColumn("Width").AsInt32().Nullable().WithDefaultValue(0)
             .WithColumn("Height").AsInt32().Nullable().WithDefaultValue(0)
             .WithColumn("Thick").AsDecimal().Nullable().WithDefaultValue(0)
              .WithColumn("Size").AsDecimal().Nullable().WithDefaultValue(0)
               .WithColumn("Weight").AsDecimal().Nullable().WithDefaultValue(0)
                .WithColumn("Volume").AsDecimal().Nullable().WithDefaultValue(0)
                  .WithColumn("AutoQuantity").AsInt32().Nullable().WithDefaultValue(1)
             .WithColumn("AutoLength").AsInt32().Nullable().WithDefaultValue(0)
             .WithColumn("AutoWidth").AsInt32().Nullable().WithDefaultValue(0)
             .WithColumn("AutoHeight").AsInt32().Nullable().WithDefaultValue(0)
              .WithColumn("AutoSize").AsDecimal().Nullable().WithDefaultValue(0)
               .WithColumn("AutoWeight").AsDecimal().Nullable().WithDefaultValue(0)
                .WithColumn("AutoVolume").AsDecimal().Nullable().WithDefaultValue(0)
                  .WithColumn("IsStock").AsInt32().Nullable().WithDefaultValue(0)
                  .WithColumn("StockDate").AsDateTime().Nullable()
                    .WithColumn("IsAssign").AsInt32().Nullable().WithDefaultValue(0)
                  .WithColumn("AssignDate").AsDateTime().Nullable()
                   .WithColumn("IsAssignOrder").AsInt32().Nullable().WithDefaultValue(0)
                  .WithColumn("AssignOrderDate").AsDateTime().Nullable()
                   .WithColumn("IsFinishType").AsInt32().Nullable().WithDefaultValue(0)
                    .WithColumn("Notes").AsString(1000).Nullable()
                    .WithColumn("SortCode").AsInt32().Nullable().WithDefaultValue(0)
                    .WithColumn("InsertDate").AsDateTime().Nullable()
                     .WithColumn("InsertUserId").AsInt32().Nullable()
                     .WithColumn("UpdateDate").AsDateTime().Nullable()
                     .WithColumn("UpdateUserId").AsInt32().Nullable();


        }
    }

}