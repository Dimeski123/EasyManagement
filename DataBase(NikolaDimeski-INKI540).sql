USE [master]
GO
/****** Object:  Database [LoginSystem]    Script Date: 9/27/2020 10:16:45 PM ******/
CREATE DATABASE [LoginSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LoginSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoginSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoginSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoginSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoginSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoginSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoginSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoginSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoginSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoginSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoginSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoginSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoginSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoginSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoginSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoginSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoginSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoginSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoginSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoginSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoginSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoginSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoginSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoginSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoginSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [LoginSystem] SET  MULTI_USER 
GO
ALTER DATABASE [LoginSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoginSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoginSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoginSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoginSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoginSystem', N'ON'
GO
ALTER DATABASE [LoginSystem] SET QUERY_STORE = OFF
GO
USE [LoginSystem]
GO
/****** Object:  Table [dbo].[Balances]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balances](
	[Balance] [float] NOT NULL,
	[MounthlyExpenses] [float] NULL,
	[Standing] [float] NULL,
 CONSTRAINT [PK_Balances] PRIMARY KEY CLUSTERED 
(
	[Balance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directors]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surename] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surename] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
	[Proffesion] [varchar](50) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surename] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Balances] ([Balance], [MounthlyExpenses], [Standing]) VALUES (0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Directors] ON 

INSERT [dbo].[Directors] ([ID], [Name], [Surename], [Username], [Password]) VALUES (1, N'admin', N'admin', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Directors] OFF
GO
SET IDENTITY_INSERT [dbo].[Managers] ON 

INSERT [dbo].[Managers] ([ID], [Name], [Surename], [Username], [Password]) VALUES (2, N'Manager1', N'Manager1LN', N'AdminM', N'AdminMPW')
INSERT [dbo].[Managers] ([ID], [Name], [Surename], [Username], [Password]) VALUES (3, N'Name1', N'Surename1', N'Username1', N'Password1')
INSERT [dbo].[Managers] ([ID], [Name], [Surename], [Username], [Password]) VALUES (4, N'Name2', N'Surename2', N'Username2', N'Password2')
INSERT [dbo].[Managers] ([ID], [Name], [Surename], [Username], [Password]) VALUES (5, N'blabla', N'blabla', N'Username', N'Password')
INSERT [dbo].[Managers] ([ID], [Name], [Surename], [Username], [Password]) VALUES (6, N'Nikola', N'Dimeski', N'Username1', N'Pw1')
SET IDENTITY_INSERT [dbo].[Managers] OFF
GO
/****** Object:  StoredProcedure [dbo].[BalanceAdd]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BalanceAdd]
@Balance int
AS
	INSERT INTO Balances (Balance) VALUES (@Balance)
GO
/****** Object:  StoredProcedure [dbo].[DirectorAdd]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DirectorAdd]
@Name varchar(50),
@Surename varchar(50),
@Username varchar(50),
@Password varchar(50)
AS
	INSERT INTO Directors(Name,Surename,Username,Password) VALUES (@Name,@Surename,@Username,@Password)
GO
/****** Object:  StoredProcedure [dbo].[EmployeesAdd]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EmployeesAdd]
@Name varchar(50),
@Surename varchar(50),
@Salary int,
@Proffesion varchar(50)
AS
	INSERT INTO Employees(Name,Surename,Salary,Proffesion) VALUES (@Name,@Surename,@Salary,@Proffesion)
GO
/****** Object:  StoredProcedure [dbo].[ManagerAdd]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ManagerAdd]
@Name varchar(50),
@Surename varchar(50),
@Username varchar(50),
@Password varchar(50)
AS
	INSERT INTO Managers(Name,Surename,Username,Password) 
	VALUES (@Name,@Surename,@Username,@Password)
GO
/****** Object:  StoredProcedure [dbo].[MounthlyAdd]    Script Date: 9/27/2020 10:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MounthlyAdd] 
@MounthlyExpenses float
AS
	INSERT INTO Balances (MounthlyExpenses) VALUES (@MounthlyExpenses)
GO
USE [master]
GO
ALTER DATABASE [LoginSystem] SET  READ_WRITE 
GO
