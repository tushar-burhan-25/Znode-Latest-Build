IF EXISTS (SELECT TOP 1 1 FROM SYSDATABASES WHERE Name = 'Znode_Multifront_Payment_90')
BEGIN 
	DECLARE @EEEE NVARCHAR(max)= 'USE [Znode_Multifront_Payment_90]'
	EXEC (@EEEE)
 PRINT '"Znode_Multifront_Payment_90" is already exists. ';
 SET NOEXEC ON ;
END 
GO
USE [master]
GO
/****** Object:  Database [Znode_Multifront_Payment_90]    Script Date: 5/18/2017 12:58:52 PM ******/
CREATE DATABASE [Znode_Multifront_Payment_90]
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ARITHABORT ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET RECOVERY FULL 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET  MULTI_USER 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Znode_Multifront_Payment_90]
GO
/****** Object:  Table [dbo].[ZNodeActivityLog]    Script Date: 5/18/2017 12:58:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodeActivityLog](
	[ActivityLogId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentSettingId] [int] NULL,
	[PortalID] [int] NULL,
	[URL] [nvarchar](max) NULL,
	[Data1] [nvarchar](255) NULL,
	[Data2] [nvarchar](255) NULL,
	[Data3] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[LongData] [nvarchar](max) NULL,
	[Source] [nvarchar](255) NULL,
	[Target] [nvarchar](255) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZNodeActivityLog] PRIMARY KEY CLUSTERED 
(
	[ActivityLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZNodeDomain]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodeDomain](
	[DomainId] [int] IDENTITY(1,1) NOT NULL,
	[PortalId] [int] NOT NULL,
	[DomainName] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ApiKey] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZNodeDomain] PRIMARY KEY CLUSTERED 
(
	[DomainId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZnodePaymentAddress]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZnodePaymentAddress](
	[CreditCardAddressId] [uniqueidentifier] NOT NULL,
	[CardHolderFirstName] [varchar](60) NULL,
	[CardHolderLastName] [varchar](60) NULL,
	[AddressLine1] [varchar](200) NULL,
	[AddressLine2] [varchar](200) NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](100) NULL,
	[Country] [varchar](100) NULL,
	[ZipCode] [varchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZnodePaymentAddress] PRIMARY KEY CLUSTERED 
(
	[CreditCardAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZnodePaymentCustomers]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZnodePaymentCustomers](
	[CustomersGUID] [uniqueidentifier] NOT NULL,
	[FisrtName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZnodePaymentCustomers] PRIMARY KEY CLUSTERED 
(
	[CustomersGUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZNodePaymentGateway]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodePaymentGateway](
	[PaymentGatewayId] [int] IDENTITY(1,1) NOT NULL,
	[GatewayName] [varchar](max) NOT NULL,
	[WebsiteURL] [varchar](max) NULL,
	[ClassName] [varchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_SC_Gateway] PRIMARY KEY CLUSTERED 
(
	[PaymentGatewayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZnodePaymentMethods]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZnodePaymentMethods](
	[PaymentGUID] [uniqueidentifier] NOT NULL,
	[Token] [varchar](max) NULL,
	[CreditCardLastFourDigit] [varchar](100) NULL,
	[CreditCardExpMonth] [int] NULL,
	[CreditCardExpYear] [int] NULL,
	[CreditCardAddressId] [uniqueidentifier] NULL,
	[PaymentSettingID] [int] NULL,
	[CustomersGUID] [uniqueidentifier] NULL,
	[CustomerProfileId] [nvarchar](64) NULL,
	[CreditCardImageUrl] [nvarchar](200) NULL,
	[IsSaveCreditCard] [bit] NOT NULL,
	[CardType] [varchar](50) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZnodePaymentMethods] PRIMARY KEY CLUSTERED 
(
	[PaymentGUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZNodePaymentSetting]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodePaymentSetting](
	[PaymentSettingId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeId] [int] NOT NULL,
	[PaymentGatewayId] [int] NULL,
	[EnableVisa] [bit] NULL,
	[EnableMasterCard] [bit] NULL,
	[EnableAmex] [bit] NULL,
	[EnableDiscover] [bit] NULL,
	[EnableRecurringPayments] [bit] NULL,
	[EnableVault] [bit] NULL,
	[IsActive] [bit] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[PreAuthorize] [bit] NOT NULL,
	[IsRMACompatible] [bit] NULL,
	[TestMode] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[EnablePODocUpload] [bit] NOT NULL,
	[IsPODocRequired] [bit] NOT NULL,
 CONSTRAINT [PK_SC_PaymentSetting] PRIMARY KEY CLUSTERED 
(
	[PaymentSettingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZNodePaymentSettingCredential]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodePaymentSettingCredential](
	[PaymentSettingCredentialId] [int] IDENTITY(1,1) NOT NULL,
	[Partner] [nvarchar](max) NULL,
	[Vendor] [nvarchar](max) NULL,
	[TestMode] [bit] NOT NULL,
	[PaymentSettingId] [int] NULL,
	[GatewayUsername] [nvarchar](max) NULL,
	[GatewayPassword] [nvarchar](max) NULL,
	[TransactionKey] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ZNodePaymentSettingCredential] PRIMARY KEY CLUSTERED 
(
	[PaymentSettingCredentialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZNodePaymentType]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZNodePaymentType](
	[PaymentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_SC_PaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZnodeTransactions]    Script Date: 5/18/2017 12:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZnodeTransactions](
	[GUID] [uniqueidentifier] NOT NULL,
	[CustomerProfileId] [nvarchar](max) NULL,
	[CustomerPaymentId] [nvarchar](max) NULL,
	[TransactionId] [nvarchar](max) NULL,
	[TransactionDate] [datetime] NULL,
	[CaptureTransactionDate] [datetime] NULL,
	[RefundTransactionDate] [datetime] NULL,
	[ResponseText] [nvarchar](max) NULL,
	[ResponseCode] [nvarchar](50) NULL,
	[Custom1] [nvarchar](max) NULL,
	[RefundTransactionId] [nvarchar](max) NULL,
	[CaptureTransactionId] [nvarchar](max) NULL,
	[Amount] [money] NULL,
	[PaymentSettingId] [int] NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[SubscriptionId] [nvarchar](max) NULL,
	[PaymentStatusId] [int] NULL,
	[RefundAmount] [numeric](12, 6) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Znode_Transactions] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ZNodePaymentGateway] ON 

INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (1, N'Authorize.Net', N'http://www.authorize.net', N'AuthorizeNetCustomerProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (4, N'Stripe', N'', N'StripeCustomerProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (5, N'Paypal', N'http://www.paypal.com', N'PaypalCustomerProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (6, N'Chase Paymentech', N'https://securevar.paymentech.com/manager', N'PaymentTechProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (7, N'WorldPay', N'http://www.wordlpay.com', N'SecureNetCustomerProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (8, N'Braintree', N'https://www.braintreepayments.com/', N'BraintreeProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentGateway] ([PaymentGatewayId], [GatewayName], [WebsiteURL], [ClassName], [CreatedDate], [ModifiedDate]) VALUES (9, N'PayFlow', N'http://www.manager.paypal.com', N'PayFlowCustomerProvider', CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
SET IDENTITY_INSERT [dbo].[ZNodePaymentGateway] OFF
SET IDENTITY_INSERT [dbo].[ZNodePaymentSetting] ON 

INSERT [dbo].[ZNodePaymentSetting] ([PaymentSettingId], [PaymentTypeId], [PaymentGatewayId], [EnableVisa], [EnableMasterCard], [EnableAmex], [EnableDiscover], [EnableRecurringPayments], [EnableVault], [IsActive], [DisplayOrder], [PreAuthorize], [IsRMACompatible], [TestMode], [CreatedDate], [ModifiedDate], [EnablePODocUpload], [IsPODocRequired]) VALUES (1, 4, NULL, NULL, NULL, NULL, NULL, 0, 0, 1, 1, 0, NULL, 0, CAST(N'2017-03-31T00:00:00.000' AS DateTime), CAST(N'2017-03-31T00:00:00.000' AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[ZNodePaymentSetting] OFF
SET IDENTITY_INSERT [dbo].[ZNodePaymentType] ON 

INSERT [dbo].[ZNodePaymentType] ([PaymentTypeId], [Name], [Description], [IsActive], [CreatedDate], [ModifiedDate]) VALUES (1, N'Credit Card', N'Credit Card', 1, CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentType] ([PaymentTypeId], [Name], [Description], [IsActive], [CreatedDate], [ModifiedDate]) VALUES (2, N'Purchase Order', N'Purchase Order', 1, CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentType] ([PaymentTypeId], [Name], [Description], [IsActive], [CreatedDate], [ModifiedDate]) VALUES (3, N'Paypal Express', N'Paypal Express', 1, CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
INSERT [dbo].[ZNodePaymentType] ([PaymentTypeId], [Name], [Description], [IsActive], [CreatedDate], [ModifiedDate]) VALUES (4, N'COD', N'Charge On Delivery', 1, CAST(N'2016-07-29T13:46:19.620' AS DateTime), CAST(N'2016-07-29T13:46:19.620' AS DateTime))
SET IDENTITY_INSERT [dbo].[ZNodePaymentType] OFF
ALTER TABLE [dbo].[ZNodeDomain] ADD  CONSTRAINT [DF_ZNodeDomain_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ZNodeDomain] ADD  CONSTRAINT [DF_ZNodeDomain_ApiKey]  DEFAULT (CONVERT([nvarchar](200),newid(),(0))) FOR [ApiKey]
GO
ALTER TABLE [dbo].[ZnodePaymentCustomers] ADD  CONSTRAINT [DF_ZnodePaymentCustomers_CustomersGUID]  DEFAULT (newid()) FOR [CustomersGUID]
GO
ALTER TABLE [dbo].[ZnodePaymentMethods] ADD  CONSTRAINT [DF_ZnodePaymentMethods]  DEFAULT ((0)) FOR [IsSaveCreditCard]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_EnableRecurringPayments]  DEFAULT ((0)) FOR [EnableRecurringPayments]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_EnableVault]  DEFAULT ((0)) FOR [EnableVault]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_PreAuthorize]  DEFAULT ((0)) FOR [PreAuthorize]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_TestMode]  DEFAULT ((0)) FOR [TestMode]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_EnablePODocUpload]  DEFAULT ((0)) FOR [EnablePODocUpload]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] ADD  CONSTRAINT [DF_ZNodePaymentSetting_IsPODocRequired]  DEFAULT ((0)) FOR [IsPODocRequired]
GO
ALTER TABLE [dbo].[ZNodePaymentSettingCredential] ADD  CONSTRAINT [DF_ZNodePaymentSettingCredential_TestMode]  DEFAULT ((0)) FOR [TestMode]
GO
ALTER TABLE [dbo].[ZNodePaymentType] ADD  CONSTRAINT [DF_SC_PaymentType_ActiveInd]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ZnodePaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_ZnodePaymentMethods_CreditCardAddressId] FOREIGN KEY([CreditCardAddressId])
REFERENCES [dbo].[ZnodePaymentAddress] ([CreditCardAddressId])
GO
ALTER TABLE [dbo].[ZnodePaymentMethods] CHECK CONSTRAINT [FK_ZnodePaymentMethods_CreditCardAddressId]
GO
ALTER TABLE [dbo].[ZnodePaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_ZnodePaymentMethods_CustomersGUID] FOREIGN KEY([CustomersGUID])
REFERENCES [dbo].[ZnodePaymentCustomers] ([CustomersGUID])
GO
ALTER TABLE [dbo].[ZnodePaymentMethods] CHECK CONSTRAINT [FK_ZnodePaymentMethods_CustomersGUID]
GO
ALTER TABLE [dbo].[ZnodePaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_ZnodePaymentMethods_PaymentSettingID] FOREIGN KEY([PaymentSettingID])
REFERENCES [dbo].[ZNodePaymentSetting] ([PaymentSettingId])
GO
ALTER TABLE [dbo].[ZnodePaymentMethods] CHECK CONSTRAINT [FK_ZnodePaymentMethods_PaymentSettingID]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting]  WITH CHECK ADD  CONSTRAINT [FK_SC_PaymentSetting_SC_Gateway] FOREIGN KEY([PaymentGatewayId])
REFERENCES [dbo].[ZNodePaymentGateway] ([PaymentGatewayId])
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] CHECK CONSTRAINT [FK_SC_PaymentSetting_SC_Gateway]
GO
ALTER TABLE [dbo].[ZNodePaymentSetting]  WITH CHECK ADD  CONSTRAINT [FK_ZNodePaymentSetting_ZNodePaymentType] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[ZNodePaymentType] ([PaymentTypeId])
GO
ALTER TABLE [dbo].[ZNodePaymentSetting] CHECK CONSTRAINT [FK_ZNodePaymentSetting_ZNodePaymentType]
GO
ALTER TABLE [dbo].[ZNodePaymentSettingCredential]  WITH CHECK ADD  CONSTRAINT [FK_ZNodePaymentSettingCredential_ZNodePaymentSetting] FOREIGN KEY([PaymentSettingId])
REFERENCES [dbo].[ZNodePaymentSetting] ([PaymentSettingId])
GO
ALTER TABLE [dbo].[ZNodePaymentSettingCredential] CHECK CONSTRAINT [FK_ZNodePaymentSettingCredential_ZNodePaymentSetting]
GO
ALTER TABLE [dbo].[ZnodeTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Znode_Transactions_ZNodePaymentSetting] FOREIGN KEY([PaymentSettingId])
REFERENCES [dbo].[ZNodePaymentSetting] ([PaymentSettingId])
GO
ALTER TABLE [dbo].[ZnodeTransactions] CHECK CONSTRAINT [FK_Znode_Transactions_ZNodePaymentSetting]
GO
USE [master]
GO
ALTER DATABASE [Znode_Multifront_Payment_90] SET  READ_WRITE 
GO
