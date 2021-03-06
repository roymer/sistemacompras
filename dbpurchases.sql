USE [master]
GO
/****** Object:  Database [purchases]    Script Date: 29/6/2020 13:53:01 ******/
CREATE DATABASE [purchases]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'purchases', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\purchases.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'purchases_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\purchases_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [purchases] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [purchases].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [purchases] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [purchases] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [purchases] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [purchases] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [purchases] SET ARITHABORT OFF 
GO
ALTER DATABASE [purchases] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [purchases] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [purchases] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [purchases] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [purchases] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [purchases] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [purchases] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [purchases] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [purchases] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [purchases] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [purchases] SET  DISABLE_BROKER 
GO
ALTER DATABASE [purchases] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [purchases] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [purchases] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [purchases] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [purchases] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [purchases] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [purchases] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [purchases] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [purchases] SET  MULTI_USER 
GO
ALTER DATABASE [purchases] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [purchases] SET DB_CHAINING OFF 
GO
ALTER DATABASE [purchases] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [purchases] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [purchases]
GO
/****** Object:  Table [dbo].[Buy_db]    Script Date: 29/6/2020 13:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buy_db](
	[date_buy] [date] NULL,
	[total_buy] [varchar](50) NULL,
	[obseration_buy] [varchar](50) NULL,
	[state_buy] [varchar](50) NULL,
	[Buy_db_ID] [numeric](28, 0) IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
 CONSTRAINT [Buy_db_PK] PRIMARY KEY CLUSTERED 
(
	[Buy_db_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BuyDetail]    Script Date: 29/6/2020 13:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BuyDetail](
	[amount_bd] [varchar](50) NULL,
	[price_bd] [varchar](30) NULL,
	[subtotal_bd] [varchar](30) NULL,
	[Product_id_prod] [int] NOT NULL,
	[Buy_db_Buy_db_ID] [numeric](28, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PayDetail]    Script Date: 29/6/2020 13:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PayDetail](
	[date_pd] [date] NULL,
	[pay_pd] [varchar](50) NULL,
	[bank_pd] [varchar](30) NULL,
	[Buy_db_Buy_db_ID] [numeric](28, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 29/6/2020 13:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[id_prod] [int] NOT NULL,
	[name_prod] [varchar](30) NULL,
	[description_prod] [varchar](50) NULL,
	[Provider_id_prov] [int] NOT NULL,
 CONSTRAINT [Product_PK] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 29/6/2020 13:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provider](
	[id_prov] [int] NOT NULL,
	[name_prov] [varchar](25) NULL,
	[country_prov] [varchar](25) NULL,
	[swift] [varchar](25) NULL,
 CONSTRAINT [Provider_PK] PRIMARY KEY CLUSTERED 
(
	[id_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BuyDetail]  WITH CHECK ADD  CONSTRAINT [BuyDetail_Buy_db_FK] FOREIGN KEY([Buy_db_Buy_db_ID])
REFERENCES [dbo].[Buy_db] ([Buy_db_ID])
GO
ALTER TABLE [dbo].[BuyDetail] CHECK CONSTRAINT [BuyDetail_Buy_db_FK]
GO
ALTER TABLE [dbo].[BuyDetail]  WITH CHECK ADD  CONSTRAINT [BuyDetail_Product_FK] FOREIGN KEY([Product_id_prod])
REFERENCES [dbo].[Product] ([id_prod])
GO
ALTER TABLE [dbo].[BuyDetail] CHECK CONSTRAINT [BuyDetail_Product_FK]
GO
ALTER TABLE [dbo].[PayDetail]  WITH CHECK ADD  CONSTRAINT [PayDetail_Buy_db_FK] FOREIGN KEY([Buy_db_Buy_db_ID])
REFERENCES [dbo].[Buy_db] ([Buy_db_ID])
GO
ALTER TABLE [dbo].[PayDetail] CHECK CONSTRAINT [PayDetail_Buy_db_FK]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [Product_Provider_FK] FOREIGN KEY([Provider_id_prov])
REFERENCES [dbo].[Provider] ([id_prov])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [Product_Provider_FK]
GO
USE [master]
GO
ALTER DATABASE [purchases] SET  READ_WRITE 
GO
