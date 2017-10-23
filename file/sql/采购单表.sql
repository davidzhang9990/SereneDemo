
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

--Ϊ�����������Ϣ
exec sp_addextendedproperty N'MS_Description', N'�ɹ�������', N'user', N'dbo', N'table', N'PurchaseOrder', NULL, NULL

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Id'
exec sp_addextendedproperty N'MS_Description', N'�ɹ������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Number'
exec sp_addextendedproperty N'MS_Description', N'���� ��0������ 1����ģ�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Type'
exec sp_addextendedproperty N'MS_Description', N'��̯���� ��0����  1��������̯ 2�������̯��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ShareType'
exec sp_addextendedproperty N'MS_Description', N'����״̬��0���Ƶ��� 1�����Ƶ� 2������⣩', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Status'
exec sp_addextendedproperty N'MS_Description', N'֧��״̬��0��δ֧�� 1��֧���� 2��֧����ɣ�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'IsPay'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PurchaseDate'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�Ա', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BuyUserId'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'SupplierId'
exec sp_addextendedproperty N'MS_Description', N'�����̱��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'SupplierNumber'
exec sp_addextendedproperty N'MS_Description', N'����֤��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'LetterNumber'
exec sp_addextendedproperty N'MS_Description', N'Ԥ�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'EstimateTotal'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ReckonTotal'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalSize'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalWeight'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalVolume'
exec sp_addextendedproperty N'MS_Description', N'�ܻ�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalContainer'
exec sp_addextendedproperty N'MS_Description', N'�ܻ�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalBuyCount'
exec sp_addextendedproperty N'MS_Description', N'��Ƭ��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'TotalPieceCount'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Notes'
exec sp_addextendedproperty N'MS_Description', N'���ڴ���', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'AgentNumber'
exec sp_addextendedproperty N'MS_Description', N'���ʽ', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PayWay'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Behalf'
exec sp_addextendedproperty N'MS_Description', N'���˷�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Ocean'
exec sp_addextendedproperty N'MS_Description', N'�ɹ�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Description'
exec sp_addextendedproperty N'MS_Description', N'�����б�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'Attachment'
exec sp_addextendedproperty N'MS_Description', N'�ᵥ��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BillLadingNumber'
exec sp_addextendedproperty N'MS_Description', N'�ᵥ����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'BillLadingDate'
exec sp_addextendedproperty N'MS_Description', N'Ԥ�Ƶ�������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'ArrivalDate'
exec sp_addextendedproperty N'MS_Description', N'����˾', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'CompanyShip'
exec sp_addextendedproperty N'MS_Description', N'���˸�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PortDepart'
exec sp_addextendedproperty N'MS_Description', N'Ŀ�ĸ�', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PortDest'
exec sp_addextendedproperty N'MS_Description', N'�۸�����', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'PriceTerms'
exec sp_addextendedproperty N'MS_Description', N'������˾', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'OrganizeId'
exec sp_addextendedproperty N'MS_Description', N'ɾ����ʶ', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'DeleteMark'

exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'InsertUserId'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'InsertDate'
exec sp_addextendedproperty N'MS_Description', N'�޸���', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'UpdateUserId'
exec sp_addextendedproperty N'MS_Description', N'�޸�ʱ��', N'user', N'dbo', N'table', N'PurchaseOrder', N'column', N'UpdateDate'

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
--Ϊ�����������Ϣ
exec sp_addextendedproperty N'MS_Description', N'�ɹ�������ϸ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', NULL, NULL

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Id'
exec sp_addextendedproperty N'MS_Description', N'�ɹ������', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ParentId'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ContainerNumber'
exec sp_addextendedproperty N'MS_Description', N'���Ϻ�', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'BlockNumber'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProNumber'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProName'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProType'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProMine'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ�ȼ�', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProGrade'
exec sp_addextendedproperty N'MS_Description', N'���յȼ�', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoGrade'
exec sp_addextendedproperty N'MS_Description', N'��Ʒ�ܶ�', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'ProDensity'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'BuyCount'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Length'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Width'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Height'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Thick'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Size'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Weight'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Volume'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsStock'
exec sp_addextendedproperty N'MS_Description', N'�������', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'StockDate'
exec sp_addextendedproperty N'MS_Description', N'�ֿ�', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'WarehouseNumber'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoBuyCount'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoLength'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoWidth'
exec sp_addextendedproperty N'MS_Description', N'��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoHeight'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoSize'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoWeight'
exec sp_addextendedproperty N'MS_Description', N'���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AutoVolume'
exec sp_addextendedproperty N'MS_Description', N'�����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsFinishType'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'Notes'
exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'SortCode'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ����', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsAssignOrder'
exec sp_addextendedproperty N'MS_Description', N'���ʱ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignOrderDate'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ�ָ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'IsAssign'
exec sp_addextendedproperty N'MS_Description', N'ָ��ʱ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignDate'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignUserId'
exec sp_addextendedproperty N'MS_Description', N'����������', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'AssignUserName'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'InsertUserId'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'InsertDate'
exec sp_addextendedproperty N'MS_Description', N'�޸���', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'UpdateUserId'
exec sp_addextendedproperty N'MS_Description', N'�޸�ʱ��', N'user', N'dbo', N'table', N'PurchaseOrderDetail', N'column', N'UpdateDate'


GO