CREATE TABLE [dbo].[AuditLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Action] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NOT NULL CONSTRAINT [DF_AuditLog_ChangedOn]  DEFAULT (getdate()),
	[TableName] [varchar](50) NOT NULL,
	[RowId] [int] NOT NULL,
	[Module] [varchar](500) NULL,
	[Page] [varchar](500) NULL,
	[Changes] [varchar](max) NULL,
 CONSTRAINT [PK_AuditLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


CREATE PROCEDURE [dbo].[Common_AuditLog]
	 @UserId                  INT
    ,@UserName				  VARCHAR(50)
	,@Action				  VARCHAR(50)
    ,@TableName				  VARCHAR(50)
	,@RowId					  INT
    ,@Module				  VARCHAR(50) = NULL
    ,@Page					  VARCHAR(50) = NULL
    ,@Changes				  VARCHAR(MAX) = NULL
AS
BEGIN
INSERT INTO [dbo].[AuditLog]
           ([UserId]
           ,[UserName]
		   ,[Action]
           ,[ChangedOn]
           ,[TableName]
           ,[RowId]
           ,[Module]
           ,[Page]
           ,[Changes])
     VALUES
           (
		    @UserId    
		   ,@UserName
		   ,@Action
		   ,GetDate()	
		   ,@TableName	
		   ,@RowId		
		   ,@Module	
		   ,@Page		
		   ,@Changes	
		   )
END
GO