USE [master]
GO
/****** Object:  Database [project]    Script Date: 09/12/2023 23:45:37 ******/
CREATE DATABASE [project] ON  PRIMARY 
( NAME = N'project', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SATYAMSHAKYA\MSSQL\DATA\project.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'project_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SATYAMSHAKYA\MSSQL\DATA\project_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [project] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [project] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [project] SET ANSI_NULLS OFF
GO
ALTER DATABASE [project] SET ANSI_PADDING OFF
GO
ALTER DATABASE [project] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [project] SET ARITHABORT OFF
GO
ALTER DATABASE [project] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [project] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [project] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [project] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [project] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [project] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [project] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [project] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [project] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [project] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [project] SET  DISABLE_BROKER
GO
ALTER DATABASE [project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [project] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [project] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [project] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [project] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [project] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [project] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [project] SET  READ_WRITE
GO
ALTER DATABASE [project] SET RECOVERY SIMPLE
GO
ALTER DATABASE [project] SET  MULTI_USER
GO
ALTER DATABASE [project] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [project] SET DB_CHAINING OFF
GO
USE [project]
GO
/****** Object:  Table [dbo].[suggetion]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[suggetion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[msg] [varchar](50) NULL,
	[suggetiondate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[suggetion] ON
INSERT [dbo].[suggetion] ([id], [name], [mob], [email], [msg], [suggetiondate]) VALUES (7, N'bnzcASBN', N'372376', N'bnsd@sdf', N'sdnASDNM,', N'9/11/2023 5:28:51 PM')
SET IDENTITY_INSERT [dbo].[suggetion] OFF
/****** Object:  Table [dbo].[registration]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[profile] [varchar](max) NULL,
	[qualification] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[district] [varchar](50) NULL,
	[dob] [varchar](50) NULL,
	[regdate] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
 CONSTRAINT [PK_registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[registration] ON
INSERT [dbo].[registration] ([id], [name], [mob], [gender], [email], [profile], [qualification], [address], [district], [dob], [regdate], [pass]) VALUES (23, N'satyam ', N'9559', N'female', N'sat@gmail.com', N'Picsart_22-07-21_19-41-17-604-01.jpeg', N'b.tech', N'j', N's1', N'0111-01-12', N'9/12/2023 11:35:08 AM', N'Admin@1')
INSERT [dbo].[registration] ([id], [name], [mob], [gender], [email], [profile], [qualification], [address], [district], [dob], [regdate], [pass]) VALUES (24, N'SAN', N'132789', N'Male', N'admin@gmail.com', N'Picsart_22-07-21_19-41-17-604-01.jpeg', N'B.tech', N'DS', N'DAS', N'2211-12-12', N'9/10/2023 1:26:14 PM', N'Admin@123')
SET IDENTITY_INSERT [dbo].[registration] OFF
/****** Object:  Table [dbo].[ptable]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ptable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[query] [varchar](50) NULL,
	[contactdate] [varchar](50) NULL,
 CONSTRAINT [PK_ptable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ptable] ON
INSERT [dbo].[ptable] ([id], [name], [mob], [email], [address], [query], [contactdate]) VALUES (9, N'dsnm', N'32563398', N'hs@a', N'sdnabns', N'eddjk', N'9/12/2023 10:56:57 PM')
INSERT [dbo].[ptable] ([id], [name], [mob], [email], [address], [query], [contactdate]) VALUES (12, N'sak', N'33', N's@w', N'snm', N'dsn', N'9/11/2023 5:02:52 PM')
INSERT [dbo].[ptable] ([id], [name], [mob], [email], [address], [query], [contactdate]) VALUES (13, N'g', N'7', N'fv@b', N'bn', N'n', N'9/12/2023 10:55:08 PM')
SET IDENTITY_INSERT [dbo].[ptable] OFF
/****** Object:  Table [dbo].[login]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[email] [varchar](50) NOT NULL,
	[pass] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[login] ([email], [pass]) VALUES (N'admin@gmail.com', N'satyam')
/****** Object:  Table [dbo].[inquiry]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inquiry](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[query] [varchar](50) NULL,
	[inquirydate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[inquiry] ON
INSERT [dbo].[inquiry] ([id], [name], [mob], [email], [query], [inquirydate]) VALUES (10, N'assahagh', N'234783438', N'asn@sd', N'sdff', N'9/11/2023 5:14:39 PM')
SET IDENTITY_INSERT [dbo].[inquiry] OFF
/****** Object:  Table [dbo].[feedback]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[feedback](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[msg] [varchar](50) NULL,
	[feedbackdate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[feedback] ON
INSERT [dbo].[feedback] ([id], [name], [mob], [email], [msg], [feedbackdate]) VALUES (9, N's', N'2', N'snb@cbn', N's', N'9/11/2023 6:03:32 PM')
SET IDENTITY_INSERT [dbo].[feedback] OFF
/****** Object:  Table [dbo].[complain]    Script Date: 09/12/2023 23:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[complain](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mob] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[msg] [varchar](50) NULL,
	[comlaindate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[complain] ON
INSERT [dbo].[complain] ([id], [name], [mob], [email], [msg], [comlaindate]) VALUES (9, N'asdghad', N'37848937', N'd@s', N'saasn', N'9/11/2023 6:02:28 PM')
INSERT [dbo].[complain] ([id], [name], [mob], [email], [msg], [comlaindate]) VALUES (10, N'bnsadd', N'123723', N'sb@sv', N'dbnd', N'9/11/2023 5:54:53 PM')
SET IDENTITY_INSERT [dbo].[complain] OFF
