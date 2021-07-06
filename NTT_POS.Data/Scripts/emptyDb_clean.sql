USE [Cridomark_POS]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](60) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[EmailAdd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Denominations]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Denominations](
	[DenominationId] [int] IDENTITY(1,1) NOT NULL,
	[Value] [float] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Denominations] PRIMARY KEY CLUSTERED 
(
	[DenominationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Denominations] ON 

INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (1, 1000, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (2, 500, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (3, 200, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (4, 100, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (5, 50, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (6, 20, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (7, 10, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (8, 5, N'', CAST(N'2020-07-29T00:30:24.923' AS DateTime), NULL, NULL)
INSERT [dbo].[Denominations] ([DenominationId], [Value], [Description], [CreationDate], [ModificationDate], [EndDate]) VALUES (9, 1, N'', CAST(N'2020-07-29T00:30:24.927' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Denominations] OFF
GO

/****** Object:  Table [dbo].[Inventories]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventories](
	[InventoryId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [float] NULL,
	[MinInventory] [int] NULL,
	[MaxInventory] [int] NULL,
	[CriticalInventory] [int] NULL,
	[UOM] [nvarchar](200) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Inventories] PRIMARY KEY CLUSTERED 
(
	[InventoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[LoginHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[IsLoggedOut] [bit] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[UnitName] [nvarchar](50) NOT NULL,
	[MachineName] [nvarchar] (max) NOT NULL,
 CONSTRAINT [PK_LoginHistory] PRIMARY KEY CLUSTERED 
(
	[LoginHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prices]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[PriceId] [int] IDENTITY(1,1) NOT NULL,
	[RetailPrice] [float] NULL,
	[WholesalePrice] [float] NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[PriceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductOrder]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductOrder](
	[ProductOrderId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[OrderStatusId] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_ProductOrder] PRIMARY KEY CLUSTERED 
(
	[ProductOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductOrderDetails]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductOrderDetails](
	[OrderDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[ProductOrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[OrderQuantity] [float] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[FinalUnitCost] [float] NULL,
	[ExpirationDate] [datetime] NULL,
 CONSTRAINT [PK_ProductOrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[PriceId] [int] NOT NULL,
	[Barcode] [nvarchar](16) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[FullDescription] [nvarchar](max) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterActivities]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterActivities](
	[RegisterActivityId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[LoginHistoryId] [int] NOT NULL,
	[RegisterActivityTypeId] [int] NOT NULL,
	[DenominationId] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[RegisterGUID] [nvarchar](36) NOT NULL,
 CONSTRAINT [PK_RegisterActivities] PRIMARY KEY CLUSTERED 
(
	[RegisterActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Returns]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Returns](
	[ReturnId] [int] IDENTITY(1,1) NOT NULL,
	[TransactionDetailId] [int] NOT NULL,
	[Quantity] [float] NOT NULL,
	[ReturnedAmount] [float] NOT NULL,
	[Reason] [nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[UserId] [int] NOT NULL,
	[ReturnStatusId] [int] NOT NULL DEFAULT 1
 CONSTRAINT [PK_Returns] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](60) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[TinNo] [nvarchar](12) NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[ModificationDate] [datetime] NULL,
	[EmailAdd] [nvarchar] (50) NULL,
	[Remarks] [nvarchar] (150) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierProductRef]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierProductRef](
	[XRefId] [int] IDENTITY(1,1) NOT NULL,
	[UnitCost] [float] NULL,
	[SupplierId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_SupplierProductRef] PRIMARY KEY CLUSTERED 
(
	[XRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[TransactionDetailId] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [float] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TransactionDetails] PRIMARY KEY CLUSTERED 
(
	[TransactionDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ReceiptNumber] [nvarchar](15) NOT NULL,
	[TransactionTypeId] [int] NOT NULL,
	[DiscountPercentage] [float] NULL,
	[DiscountAmount] [float] NULL,
	[PaymentAmount] [float] NOT NULL,
	[CustomerId] [int] NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[VoidedBy] [int] NULL,
	WholesaleReason [nvarchar](max) NULL,
	isRetail[bit] NOT NULL DEFAULT 1,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserRoleId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/10/2020 1:22:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[AddedBy] [int] NOT NULL,
	[TempPassword][nvarchar](max) NULL,
	[Disabled][bit] NOT NULL Default 0,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** CREATE INITIAL ADMIN ACCOUNT ******/
SET IDENTITY_INSERT [dbo].[Users] ON 
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Username], [Password], [CreationDate], [ModificationDate], [EndDate], [AddedBy]) VALUES (1, N'Administrator', N'Administrator', N'admin', N'21232f297a57a5a743894a0e4a801fc3', CAST(N'2020-07-29T00:30:27.290' AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 
INSERT [dbo].[UserRoles] ([UserRoleId], [UserId], [RoleId]) VALUES (1,1,1)
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO

/****** Object:  Table [dbo].[OrderStatus]    Script Date: 05/10/2020 1:25:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[OrderStatusId] [int] NOT NULL,
	[OrderStatusName] [varchar](50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterActivityTypes]    Script Date: 05/10/2020 1:25:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterActivityTypes](
	[RegisterActivityTypeId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_RegisterActivityTypes] PRIMARY KEY CLUSTERED 
(
	[RegisterActivityTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 05/10/2020 1:25:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionTypes]    Script Date: 05/10/2020 1:25:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionTypes](
	[TransactionTypeId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_TransactionTypes] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName], [CreationDate], [EndDate]) VALUES (1, N'Pending', CAST(N'2020-08-01T14:03:33.613' AS DateTime), NULL)
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName], [CreationDate], [EndDate]) VALUES (2, N'Received', CAST(N'2020-08-01T14:03:33.613' AS DateTime), NULL)
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName], [CreationDate], [EndDate]) VALUES (3, N'Cancelled', CAST(N'2020-08-01T14:03:33.613' AS DateTime), NULL)
GO
INSERT [dbo].[RegisterActivityTypes] ([RegisterActivityTypeId], [Name], [Description]) VALUES (1, N'Register In', N'Register In')
INSERT [dbo].[RegisterActivityTypes] ([RegisterActivityTypeId], [Name], [Description]) VALUES (2, N'Register Out', N'Register Out')
INSERT [dbo].[RegisterActivityTypes] ([RegisterActivityTypeId], [Name], [Description]) VALUES (3, N'Cash Sweep', N'Cash Sweep')
GO
INSERT [dbo].[Roles] ([RoleId], [Name], [Description]) VALUES (1, N'Administrator', N'POS Administrator')
INSERT [dbo].[Roles] ([RoleId], [Name], [Description]) VALUES (2, N'Supervisor', N'POS Supervisor')
INSERT [dbo].[Roles] ([RoleId], [Name], [Description]) VALUES (3, N'Cashier', N'POS Cashier')
GO
INSERT [dbo].[TransactionTypes] ([TransactionTypeId], [Name], [Description]) VALUES (1, N'Sales', N'Normal Sales')
INSERT [dbo].[TransactionTypes] ([TransactionTypeId], [Name], [Description]) VALUES (2, N'Purchase Order', N'Wholesale Sales')
INSERT [dbo].[TransactionTypes] ([TransactionTypeId], [Name], [Description]) VALUES (3, N'Return', N'Item Returns')
INSERT [dbo].[TransactionTypes] ([TransactionTypeId], [Name], [Description]) VALUES (4, N'Pending', N'Pending Sales')
GO

ALTER TABLE [dbo].[Inventories]  WITH CHECK ADD  CONSTRAINT [FK_Inventories_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Inventories] CHECK CONSTRAINT [FK_Inventories_Products]
GO
ALTER TABLE [dbo].[LoginHistory]  WITH CHECK ADD  CONSTRAINT [FK_LoginHistory_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[LoginHistory] CHECK CONSTRAINT [FK_LoginHistory_Users]
GO
ALTER TABLE [dbo].[Returns]  WITH CHECK ADD  CONSTRAINT [FK_Returns_TransactionDetails] FOREIGN KEY([TransactionDetailId])
REFERENCES [dbo].[TransactionDetails] ([TransactionDetailId])
GO
ALTER TABLE [dbo].[Returns] CHECK CONSTRAINT [FK_Returns_TransactionDetails]
GO
ALTER TABLE [dbo].[Returns]  WITH CHECK ADD  CONSTRAINT [FK_Returns_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Returns] CHECK CONSTRAINT [FK_Returns_Users]
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_TransactionDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[TransactionDetails] CHECK CONSTRAINT [FK_TransactionDetails_Products]
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_TransactionDetails_Transactions] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transactions] ([TransactionId])
GO
ALTER TABLE [dbo].[TransactionDetails] CHECK CONSTRAINT [FK_TransactionDetails_Transactions]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users]
GO


/****** Relationship updates on db 11/19/2020 ******/

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Customer]
GO

ALTER TABLE [dbo].[RegisterActivities]  WITH CHECK ADD  CONSTRAINT [FK_RegisterActivities_RegisterActivityTypes] FOREIGN KEY([RegisterActivityTypeId])
REFERENCES [dbo].[RegisterActivityTypes] ([RegisterActivityTypeId])
GO
ALTER TABLE [dbo].[RegisterActivities] CHECK CONSTRAINT [FK_RegisterActivities_RegisterActivityTypes]
GO

ALTER TABLE [dbo].[ProductOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrder_OrderStatus] FOREIGN KEY([OrderStatusId])
REFERENCES [dbo].[OrderStatus] ([OrderStatusId])
GO
ALTER TABLE [dbo].[ProductOrder] CHECK CONSTRAINT [FK_ProductOrder_OrderStatus]
GO

ALTER TABLE [dbo].[ProductOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrder_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[ProductOrder] CHECK CONSTRAINT [FK_ProductOrder_Supplier]
GO

ALTER TABLE [dbo].[SupplierProductRef]  WITH CHECK ADD  CONSTRAINT [FK_SupplierProductRef_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[SupplierProductRef] CHECK CONSTRAINT [FK_SupplierProductRef_Supplier]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_TransactionTypes] FOREIGN KEY([TransactionTypeId])
REFERENCES [dbo].[TransactionTypes] ([TransactionTypeId])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_TransactionTypes]
GO

ALTER TABLE [dbo].[RegisterActivities]  WITH CHECK ADD  CONSTRAINT [FK_RegisterActivities_Denominations] FOREIGN KEY([DenominationId])
REFERENCES [dbo].[Denominations] ([DenominationId])
GO
ALTER TABLE [dbo].[RegisterActivities] CHECK CONSTRAINT [FK_RegisterActivities_Denominations]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Users]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_VoidedBy] FOREIGN KEY([VoidedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_VoidedBy]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_AddedBy] FOREIGN KEY([AddedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_AddedBy]
GO

/****** Object:  Table [dbo].[PriceHistory]    Script Date: 28/01/2021 7:42:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PriceHistory](
	[PriceHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[PriceId] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PriceHistory] PRIMARY KEY CLUSTERED 
(
	[PriceHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[loginAttempt]    Script Date: 28/01/2021 7:42:38 PM ******/
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



/****** Object:  Table [dbo].[Security]    Script Date: 22/04/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security](
	[SecurityId] [int] IDENTITY(1,1) NOT NULL,
	[SecurityToken][nvarchar](max) NOT NULL,
	[UnitAddress][nvarchar](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[ExpirationDate] [datetime] NOT NULL,
	[LastOpen][datetime] NOT NULL,
	[KeyValue] [nvarchar](max) NULL,
	[Activate][bit] NOT NULL,

 CONSTRAINT [PK_Security] PRIMARY KEY CLUSTERED 
(
	[SecurityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

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