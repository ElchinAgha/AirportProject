/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [Airport]    Script Date: 5/13/2018 1:05:21 PM ******/
CREATE DATABASE [Airport]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Airport', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SERVER2018\MSSQL\DATA\Airport.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Airport_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SERVER2018\MSSQL\DATA\Airport_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Airport] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Airport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Airport] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Airport] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Airport] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Airport] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Airport] SET ARITHABORT OFF 
GO
ALTER DATABASE [Airport] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Airport] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Airport] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Airport] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Airport] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Airport] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Airport] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Airport] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Airport] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Airport] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Airport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Airport] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Airport] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Airport] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Airport] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Airport] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Airport] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Airport] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Airport] SET  MULTI_USER 
GO
ALTER DATABASE [Airport] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Airport] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Airport] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Airport] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Airport] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Airport] SET QUERY_STORE = OFF
GO
USE [Airport]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Airport]
GO
/****** Object:  Table [dbo].[Airlines]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airlines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Airline] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flights]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flights](
	[Id] [int] NOT NULL,
	[AirlineId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[GateId] [int] NOT NULL,
	[RunwayId] [int] NOT NULL,
	[TargetDate] [datetime] NOT NULL,
	[Date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gates]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Gate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Gates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Runways]    Script Date: 5/13/2018 1:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Runways](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Runway] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Runways] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Airlines] ON 

INSERT [dbo].[Airlines] ([Id], [Airline], [CountryId]) VALUES (1, N'AZAL', 1)
INSERT [dbo].[Airlines] ([Id], [Airline], [CountryId]) VALUES (2, N'TYT', 2)
SET IDENTITY_INSERT [dbo].[Airlines] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [City], [CountryId]) VALUES (1, N'Baku', 1)
INSERT [dbo].[Cities] ([Id], [City], [CountryId]) VALUES (2, N'Istanbul', 2)
INSERT [dbo].[Cities] ([Id], [City], [CountryId]) VALUES (3, N'Qabala', 1)
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Country]) VALUES (1, N'Azerbaijan')
INSERT [dbo].[Countries] ([Id], [Country]) VALUES (2, N'Turkey')
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Gates] ON 

INSERT [dbo].[Gates] ([Id], [Gate]) VALUES (1, N'A1')
INSERT [dbo].[Gates] ([Id], [Gate]) VALUES (2, N'A2')
INSERT [dbo].[Gates] ([Id], [Gate]) VALUES (3, N'B1')
INSERT [dbo].[Gates] ([Id], [Gate]) VALUES (4, N'B2')
SET IDENTITY_INSERT [dbo].[Gates] OFF
SET IDENTITY_INSERT [dbo].[Runways] ON 

INSERT [dbo].[Runways] ([Id], [Runway]) VALUES (1, N'1')
INSERT [dbo].[Runways] ([Id], [Runway]) VALUES (2, N'2')
SET IDENTITY_INSERT [dbo].[Runways] OFF
ALTER TABLE [dbo].[Airlines]  WITH CHECK ADD  CONSTRAINT [FK_Airlines_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Airlines] CHECK CONSTRAINT [FK_Airlines_Countries]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries]
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD  CONSTRAINT [FK_Flights_Airlines] FOREIGN KEY([AirlineId])
REFERENCES [dbo].[Airlines] ([Id])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_Flights_Airlines]
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD  CONSTRAINT [FK_Flights_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_Flights_Cities]
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD  CONSTRAINT [FK_Flights_Gates] FOREIGN KEY([GateId])
REFERENCES [dbo].[Gates] ([Id])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_Flights_Gates]
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD  CONSTRAINT [FK_Flights_Runways] FOREIGN KEY([RunwayId])
REFERENCES [dbo].[Runways] ([Id])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_Flights_Runways]
GO
USE [master]
GO
ALTER DATABASE [Airport] SET  READ_WRITE 
GO
