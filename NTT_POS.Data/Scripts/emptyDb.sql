USE [Cridomark_POS]
GO

/**NEW UPDATE 5/04/21 **/
/**Changed TIN Number type from int to string(12)**/

Alter table Supplier
Alter Column TinNo nvarchar(12) NULL

/**NEW UPDATE 06/04/21 **/
/**Changed User table and create new table login attempt**/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoginAttempt](
	[LoginAttemptId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate][datetime] NULL,
	[UnitName] [nvarchar](max) NOT NULL,
	[MachineName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LoginAttempt] PRIMARY KEY CLUSTERED 
(
	[LoginAttemptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

alter table Users
Add [TempPassword][nvarchar](max) NULL,
	[Disabled][bit] NOT NULL Default 0

/**NEW UPDATE 14/04/21 **/
/**Change datatype of barcode column on products and barcodelog table**/

Alter table Products
Alter Column Barcode nvarchar(16) NOT NULL


/**NEW UPDATE 20/04/21 **/
/**Add EmailAdd, remarks column in supplier and customer table**/
Alter table supplier
Add [Remarks][nvarchar](150) NULL
Alter table supplier
Add [EmailAdd][nvarchar](50) NULL

Alter table customer
Add [EmailAdd][nvarchar](50) NULL


/****** Object:  Table [dbo].[Security]    Script Date: 22/04/2020 ******/
/**  Add security table for product key/activator  **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security](
	[SecurityId] [int] IDENTITY(1,1) NOT NULL,
	[SecurityToken][nvarchar](max) NOT NULL,
	[UnitAddress][nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[LastOpen][datetime] NOT NULL,
 CONSTRAINT [PK_Security] PRIMARY KEY CLUSTERED 
(
	[SecurityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Security]    Script Date: 23/04/2020 ******/
/**  change datatype of orderQuantity on purchaseorder details table  **/
Alter table ProductOrderDetails
Alter Column OrderQuantity float NOT NULL


/****** Object:  Table [dbo].[ProductOrderDetails]    Script Date: 25/04/2020 ******/
/**  moved product expiration date to purchase order **/
Alter table ProductOrderDetails
Add ExpirationDate datetime NULL


/****** Object:  Table [dbo].[Security]    Script Date: 27/04/2020 ******/
/**  added key to security table **/
Alter table [Security]
Add KeyValue nvarchar(max) NULL ,
	Activate bit NOT NULL,
	ExpirationDate datetime NOT NULL
Alter table [Security]
alter column [EndDate] datetime NULL

alter table [Products]
Drop column [ExpirationDate] 

/**UPDATE DELIVERED TO RECEIVED VALUE**/
Update OrderStatus Set OrderStatusName ='Received' Where OrderStatusId = 2

/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 4/05/2020 ******/
/**  Add company info table for new receipt template **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyBranchDetails](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BranchName][nvarchar](max) NOT NULL,
	[Address][nvarchar](max) NOT NULL,
	[TinNo] [nvarchar](12) NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL
 CONSTRAINT [PK_CompanyBranchDetails] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 8/05/2020 ******/
/** Add reason on wholesale retail and  isRetail column on transaction**/
alter table [Transactions]
add WholesaleReason [nvarchar](max) NULL,
	isRetail[bit] NOT NULL DEFAULT 1

/****** Object:  Table [dbo].[ReturnStatus]    Script Date: 6/05/2020 ******/
/**  Add return status table and add default value **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnStatus](
	[ReturnStatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName][nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL
 CONSTRAINT [PK_ReturnStatus] PRIMARY KEY CLUSTERED 
(
	[ReturnStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[ReturnStatus] ON 
INSERT [dbo].[ReturnStatus] ([ReturnStatusId], [StatusName], [CreationDate], [EndDate]) VALUES (1, N'To Be Reviewed', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL)
INSERT [dbo].[ReturnStatus] ([ReturnStatusId], [StatusName], [CreationDate], [EndDate]) VALUES (2, N'Return To Shelf', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL)
INSERT [dbo].[ReturnStatus] ([ReturnStatusId], [StatusName], [CreationDate], [EndDate]) VALUES (3, N'Discard Item', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ReturnStatus] OFF
GO

/**  Add return status foreign key to returns table**/
  alter table [Returns]
  add [ReturnStatusId] [int] NOT NULL DEFAULT 1


 /**QA - Kules - Charles 1 - Charles 2**/
/***ADD machine name column on login history*/
alter table LoginHistory
add [MachineName] [nvarchar](max) NOT NULL Default 'EMPTY'