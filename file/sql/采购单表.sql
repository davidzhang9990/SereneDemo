
IF EXISTS  (SELECT  * FROM dbo.SysObjects WHERE ID = object_id(N'[PurchaseOrder]') AND OBJECTPROPERTY(ID, 'IsTable') = 1) 

drop table [dbo].[PurchaseOrder]

GO

CREATE TABLE [dbo].[PurchaseOrder](
	[Id] [varchar](50) NOT NULL,
	[Number] [varchar](50) NOT NULL,
	[Type] int NULL,
	[ShareType] int NULL,
	[Status] [int] default 0  NULL,
	[IsPay] [int] default 0  NULL,
	[DeleteMark] [int] default 0  NULL,
	[BuyUserId] [varchar](50) NULL,
	[PurchaseDate] [datetime] NULL,
	[SupplierId] [varchar](50) NULL,
	[SupplierNumber] [varchar](50) NULL,
	[LetterNumber] [varchar](50) NULL,
	[EstimateTotal] decimal(20,2) NULL,
	[ReckonTotal] decimal(20,2) NULL,
	[TotalSize] decimal(20,3) NULL,
	[TotalWeight] decimal(20,2) NULL,
	[TotalVolume] decimal(20,2) NULL,
	[TotalContainer] int NULL,
	[TotalBuyCount] int NULL,
	[TotalPieceCount] int NULL,
	[Notes] [varchar](1000) NULL,
	[AgentNumber] [varchar](1000) NULL,
	[PayWay] [int] default 0  NULL,
	[Behalf] [varchar](1000) NULL,
	[Ocean] decimal(20,2) NULL,
	[Description] [varchar](1000) NULL,
	[Attachment] [varchar](max) NULL,
	[BillLadingNumber] [varchar](50) NULL,
	[BillLadingDate] [datetime] NULL,
	[ArrivalDate] [datetime] NULL,
	[CompanyShip] [varchar](50) NULL,
	[PortDepart] [varchar](50) NULL,
	[PortDest] [varchar](50) NULL,
	[PriceTerms] [int] default 0  NULL,
	[OrganizeId] [varchar](50) NULL,
	[InsertUserId] [int] default 0  NULL,
	[InsertDate] [datetime] NULL,
	[UpdateUserId] [int] default 0  NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

CREATE NONCLUSTERED INDEX [IDX_PurchaseOrder_Number]
    ON [dbo].[PurchaseOrder]([Number] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrder_Type]
    ON [dbo].[PurchaseOrder]([Type] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrder_ShareType]
    ON [dbo].[PurchaseOrder]([ShareType] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrder_PurchaseDate]
    ON [dbo].[PurchaseOrder]([PurchaseDate] DESC);
GO

--为表添加描述信息
exec sp_addextendedproperty N'MS_Description', N'采购订单表', N'user', N'dbo', N'table', N'PurchaseOrder', NULL, NULL

exec sp_addextendedproperty N'MS_Description', N'内码', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Id'
exec sp_addextendedproperty N'MS_Description', N'采购单编号', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Number'
exec sp_addextendedproperty N'MS_Description', N'类型 （0：荒料 1：板材）', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Type'
exec sp_addextendedproperty N'MS_Description', N'分摊类型 （0：无  1：重量分摊 2：体积分摊）', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ShareType'
exec sp_addextendedproperty N'MS_Description', N'订单状态（0：制单中 1：已制单 2：已入库）', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Status'
exec sp_addextendedproperty N'MS_Description', N'支付状态（0：未支付 1：支付中 2：支付完成）', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'IsPay'
exec sp_addextendedproperty N'MS_Description', N'采购日期', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PurchaseDate'
exec sp_addextendedproperty N'MS_Description', N'采购员', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BuyUserId'
exec sp_addextendedproperty N'MS_Description', N'供货商主键', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'SupplierId'
exec sp_addextendedproperty N'MS_Description', N'供货商编号', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'SupplierNumber'
exec sp_addextendedproperty N'MS_Description', N'信用证号', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'LetterNumber'
exec sp_addextendedproperty N'MS_Description', N'预估金额', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'EstimateTotal'
exec sp_addextendedproperty N'MS_Description', N'结算金额', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ReckonTotal'
exec sp_addextendedproperty N'MS_Description', N'总面积', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalSize'
exec sp_addextendedproperty N'MS_Description', N'总重量', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalWeight'
exec sp_addextendedproperty N'MS_Description', N'总体积', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalVolume'
exec sp_addextendedproperty N'MS_Description', N'总货柜数', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalContainer'
exec sp_addextendedproperty N'MS_Description', N'总荒料数', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalBuyCount'
exec sp_addextendedproperty N'MS_Description', N'总片数', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalPieceCount'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Notes'
exec sp_addextendedproperty N'MS_Description', N'进口代理', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'AgentNumber'
exec sp_addextendedproperty N'MS_Description', N'付款方式', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PayWay'
exec sp_addextendedproperty N'MS_Description', N'贷代', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Behalf'
exec sp_addextendedproperty N'MS_Description', N'海运费', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Ocean'
exec sp_addextendedproperty N'MS_Description', N'采购描述', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Description'
exec sp_addextendedproperty N'MS_Description', N'附件列表', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Attachment'
exec sp_addextendedproperty N'MS_Description', N'提单号', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BillLadingNumber'
exec sp_addextendedproperty N'MS_Description', N'提单日期', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BillLadingDate'
exec sp_addextendedproperty N'MS_Description', N'预计到货日期', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ArrivalDate'
exec sp_addextendedproperty N'MS_Description', N'船公司', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'CompanyShip'
exec sp_addextendedproperty N'MS_Description', N'启运港', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PortDepart'
exec sp_addextendedproperty N'MS_Description', N'目的港', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PortDest'
exec sp_addextendedproperty N'MS_Description', N'价格条款', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PriceTerms'
exec sp_addextendedproperty N'MS_Description', N'所属公司', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'OrganizeId'
exec sp_addextendedproperty N'MS_Description', N'删除标识', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'DeleteMark'

exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'InsertUserId'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'InsertDate'
exec sp_addextendedproperty N'MS_Description', N'修改人', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'UpdateUserId'
exec sp_addextendedproperty N'MS_Description', N'修改时间', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'UpdateDate'

GO

IF EXISTS  (SELECT  * FROM dbo.SysObjects WHERE ID = object_id(N'[PurchaseOrderDetail]') AND OBJECTPROPERTY(ID, 'IsTable') = 1) 

drop table [dbo].[PurchaseOrderDetail]

GO

CREATE TABLE [dbo].[PurchaseOrderDetail](
	[Id] [varchar](50) NOT NULL,
	[ParentId] [varchar](50) NOT NULL,
	[ContainerNumber] [varchar](50)  NULL,
	[BlockNumber] [varchar](50)  NULL,
	[ProNumber] [varchar](50)  NULL,
	[ProName] [varchar](50)  NULL,
	[ProType] [varchar](50)  NULL,
	[ProMine] [varchar](50)  NULL,
	[ProGrade] [varchar](50)  NULL,
	[ProDensity] decimal(20,2) NULL,
	[BuyCount] int  NULL,
	[Length] int  NULL,
	[Width] int  NULL,
	[Height] int  NULL,
	[Thick] decimal(20,2) NULL,
	[Size] decimal(20,3) NULL,
	[Weight] decimal(20,2) NULL,
	[Volume] decimal(20,2) NULL,
	[IsStock] int  NULL,
	[StockDate] [datetime] NULL,
	[WarehouseNumber] [varchar](50) NULL,
	[AutoBuyCount] int  NULL,
	[AutoLength] int  NULL,
	[AutoWidth] int  NULL,
	[AutoHeight] int  NULL,
	[AutoSize] decimal(20,3) NULL,
	[AutoWeight] decimal(20,2) NULL,
	[AutoVolume] decimal(20,2) NULL,
	[AutoGrade] [varchar](50)  NULL,
	[IsFinishType] [int] default 0  NULL,
	[Notes] [varchar](1000) NULL,
	[SortCode] [int] NULL,
	[IsAssignOrder] int NULL,
	[AssignOrderDate] [datetime] NULL,
	[IsAssign] int NULL,
	[AssignDate] [datetime] NULL,
	[AssignUserId] [varchar](50) NULL,
	[AssignUserName] [varchar](50) NULL,
	[InsertUserId] [int] default 0  NULL,
	[InsertDate] [datetime] NULL,
	[UpdateUserId] [int] default 0  NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ParentId]
    ON [dbo].[PurchaseOrderDetail]([ParentId] ASC);
GO

CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_SortCode]
    ON [dbo].[PurchaseOrderDetail]([SortCode] ASC);
GO

CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ProNumber]
    ON [dbo].[PurchaseOrderDetail]([ProNumber] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ProName]
    ON [dbo].[PurchaseOrderDetail]([ProName] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ProType]
    ON [dbo].[PurchaseOrderDetail]([ProType] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ProMine]
    ON [dbo].[PurchaseOrderDetail]([ProMine] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_ProGrade]
    ON [dbo].[PurchaseOrderDetail]([ProGrade] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_AutoGrade]
    ON [dbo].[PurchaseOrderDetail]([AutoGrade] ASC);
GO
CREATE NONCLUSTERED INDEX [IDX_PurchaseOrderDetail_InsertDate]
    ON [dbo].[PurchaseOrderDetail]([InsertDate] ASC);
GO
--为表添加描述信息
exec sp_addextendedproperty N'MS_Description', N'采购订单明细表', N'user', N'dbo', N'table', N'PurchaseOrderDetail', NULL, NULL

exec sp_addextendedproperty N'MS_Description', N'内码', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Id'
exec sp_addextendedproperty N'MS_Description', N'采购单编号', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ParentId'
exec sp_addextendedproperty N'MS_Description', N'货柜号', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ContainerNumber'
exec sp_addextendedproperty N'MS_Description', N'荒料号', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'BlockNumber'
exec sp_addextendedproperty N'MS_Description', N'商品编号', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProNumber'
exec sp_addextendedproperty N'MS_Description', N'商品名称', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProName'
exec sp_addextendedproperty N'MS_Description', N'商品类别', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProType'
exec sp_addextendedproperty N'MS_Description', N'商品矿口', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProMine'
exec sp_addextendedproperty N'MS_Description', N'商品等级', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProGrade'
exec sp_addextendedproperty N'MS_Description', N'验收等级', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoGrade'
exec sp_addextendedproperty N'MS_Description', N'商品密度', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProDensity'
exec sp_addextendedproperty N'MS_Description', N'数量', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'BuyCount'
exec sp_addextendedproperty N'MS_Description', N'长', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Length'
exec sp_addextendedproperty N'MS_Description', N'宽', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Width'
exec sp_addextendedproperty N'MS_Description', N'高', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Height'
exec sp_addextendedproperty N'MS_Description', N'厚度', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Thick'
exec sp_addextendedproperty N'MS_Description', N'面积', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Size'
exec sp_addextendedproperty N'MS_Description', N'重量', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Weight'
exec sp_addextendedproperty N'MS_Description', N'体积', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Volume'
exec sp_addextendedproperty N'MS_Description', N'是否入库', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsStock'
exec sp_addextendedproperty N'MS_Description', N'入库日期', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'StockDate'
exec sp_addextendedproperty N'MS_Description', N'仓库', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'WarehouseNumber'
exec sp_addextendedproperty N'MS_Description', N'数量', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoBuyCount'
exec sp_addextendedproperty N'MS_Description', N'长', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoLength'
exec sp_addextendedproperty N'MS_Description', N'宽', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoWidth'
exec sp_addextendedproperty N'MS_Description', N'高', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoHeight'
exec sp_addextendedproperty N'MS_Description', N'面积', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoSize'
exec sp_addextendedproperty N'MS_Description', N'重量', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoWeight'
exec sp_addextendedproperty N'MS_Description', N'体积', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoVolume'
exec sp_addextendedproperty N'MS_Description', N'完成面', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsFinishType'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Notes'
exec sp_addextendedproperty N'MS_Description', N'排序', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'SortCode'
exec sp_addextendedproperty N'MS_Description', N'是否验货', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsAssignOrder'
exec sp_addextendedproperty N'MS_Description', N'验货时间', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignOrderDate'
exec sp_addextendedproperty N'MS_Description', N'是否指派', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsAssign'
exec sp_addextendedproperty N'MS_Description', N'指派时间', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignDate'
exec sp_addextendedproperty N'MS_Description', N'验收人', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignUserId'
exec sp_addextendedproperty N'MS_Description', N'验收人姓名', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignUserName'
exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'InsertUserId'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'InsertDate'
exec sp_addextendedproperty N'MS_Description', N'修改人', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'UpdateUserId'
exec sp_addextendedproperty N'MS_Description', N'修改时间', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'UpdateDate'


GO