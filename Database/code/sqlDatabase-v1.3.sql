/**** Database script created 2019-03-04  by Eric Romagna  ****/

USE [master]
GO
/****** Object:  Database [Ontario Musicians db]    Script Date: 2018-03-04  ******/
CREATE DATABASE [OntarioMusicians]

GO
ALTER DATABASE [OntarioMusicians] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OntarioMusicians].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OntarioMusicians] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OntarioMusicians] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OntarioMusicians] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OntarioMusicians] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OntarioMusicians] SET ARITHABORT OFF 
GO
ALTER DATABASE [OntarioMusicians] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OntarioMusicians] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OntarioMusicians] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OntarioMusicians] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OntarioMusicians] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OntarioMusicians] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OntarioMusicians] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OntarioMusicians] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OntarioMusicians] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OntarioMusicians] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OntarioMusicians] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OntarioMusicians] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OntarioMusicians] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OntarioMusicians] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OntarioMusicians] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OntarioMusicians] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OntarioMusicians] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OntarioMusicians] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OntarioMusicians] SET  MULTI_USER 
GO
ALTER DATABASE [OntarioMusicians] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OntarioMusicians] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OntarioMusicians] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OntarioMusicians] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OntarioMusicians] SET DELAYED_DURABILITY = DISABLED 
GO

USE [OntarioMusicians]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[memberId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
    [lastName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[associationDate] [date] NULL,
	[email] [varchar](50) NOT NULL,
	[request][int] NOT NULL,
	[balanceDue][bit],
	[balance][int] NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[memberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 


GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[statusId] [int] NOT NULL,
	[statusType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[statusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
/****** Object:  Table person musicAssociation  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personMusicAssociation](
	[personMusicAssociationId] [int] NOT NULL,
	[memberId] [int] NOT NULL,
	[memberName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[MusicAssociationName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_personMusicAssociation] PRIMARY KEY CLUSTERED 
(
	[personMusicAssociationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musicAssociation](
	[musicAssociationId] [int] NOT NULL,
	[musicAssociationName] [varchar](50) NOT NULL,
	[genre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_musicAssociation] PRIMARY KEY CLUSTERED 
(
	[musicAssociationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personInstrument](
	[personInstrumentId] [int] NOT NULL,
	[personID] [int] NOT NULL,
	[instrumentId] [int] NOT NULL,
	[memberName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[instrumentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_personInstrument] PRIMARY KEY CLUSTERED 
(
	[personInstrumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instrument](
	[instrumentId] [int] NOT NULL,
	[instrumentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_instrument] PRIMARY KEY CLUSTERED 
(
	[instrumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phone](
	[phoneNumber] [int] NOT NULL,
	[phoneType] [varchar](50) NOT NULL,
	[memberId] [int] NOT NULL,
 CONSTRAINT [PK_phone] PRIMARY KEY CLUSTERED 
(
	[phoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table status  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phoneType](
	[phoneTypeId] [int] NOT NULL,
	[phoneType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_phoneType] PRIMARY KEY CLUSTERED 
(
	[phoneTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/******* Inserting Values   *******/

GO
SET IDENTITY_INSERT [dbo].[person] ON 

INSERT [dbo].[person] ([memberId], [firstName], [lastName], [password], [associationDate], [email], [request], [balanceDue], [balance], [statusId]) VALUES (1, N'Jimmy', N'Page', N'hello',CAST(N'1970-01-23T00:00:00.000' AS DateTime),N'jpage@lz.com',0,0,0,1)
INSERT [dbo].[person] ([memberId], [firstName], [lastName], [password], [associationDate], [email], [request], [balanceDue], [balance], [statusId]) VALUES (2, N'Freddie', N'Mercury',N'hello',CAST(N'1977-01-23T00:00:00.000' AS DateTime),N'freddiw@queen.com',1,1,0,2)
INSERT [dbo].[person] ([memberId], [firstName], [lastName], [password], [associationDate], [email], [request], [balanceDue], [balance], [statusId]) VALUES (3, N'Kurt', N'Cobain',N'hello',CAST(N'1990-01-23T00:00:00.000' AS DateTime),N'kurt@nirvana.com',-1,0,0,3)

SET IDENTITY_INSERT [dbo].[person] OFF
GO


INSERT [dbo].[status] ([statusId], [statusType]) VALUES (1, N'Administrator')
INSERT [dbo].[status] ([statusId], [statusType]) VALUES (2, N'Member')
INSERT [dbo].[status] ([statusId], [statusType]) VALUES (3, N'User')


GO

INSERT [dbo].[personMusicAssociation] ([personMusicAssociationId], [memberId], [memberName], [lastName], [MusicAssociationName]) VALUES (1,2, N'Freddie', N'Mercury',N'Queen')
INSERT [dbo].[personMusicAssociation] ([personMusicAssociationId], [memberId], [memberName], [lastName], [MusicAssociationName]) VALUES (2,1, N'Jimmy', N'Page',N'Led Zepellin')
INSERT [dbo].[personMusicAssociation] ([personMusicAssociationId], [memberId], [memberName], [lastName], [MusicAssociationName]) VALUES (3,3, N'Kurt',  N'Cobbain',N'Nirvana')


GO

INSERT [dbo].[musicAssociation] ([musicAssociationId], [musicAssociationName], [genre]) VALUES (1, N'Queen',N'Rock')
INSERT [dbo].[musicAssociation] ([musicAssociationId], [musicAssociationName], [genre]) VALUES (2, N'Led Zeppelin',N'Rock')
INSERT [dbo].[musicAssociation] ([musicAssociationId], [musicAssociationName], [genre]) VALUES (3, N'Nirvana',N'Rock')


GO

INSERT [dbo].[personInstrument] ([personInstrumentId], [personID], [instrumentId], [memberName], [lastName], [instrumentName]) VALUES (1,1,1, N'Jimmy', N'Page',N'Guitar')
INSERT [dbo].[personInstrument] ([personInstrumentId], [personID], [instrumentId], [memberName], [lastName], [instrumentName]) VALUES (2,2,2, N'Freddie', N'Mercury',N'Vocal')
INSERT [dbo].[personInstrument] ([personInstrumentId], [personID], [instrumentId], [memberName], [lastName], [instrumentName]) VALUES (3,3,2, N'Kurt', N'Cobain',N'Guitar')
INSERT [dbo].[personInstrument] ([personInstrumentId], [personID], [instrumentId], [memberName], [lastName], [instrumentName]) VALUES (4,3,1, N'Kurt', N'Cobain',N'Vocal')


GO

INSERT [dbo].[instrument] ([instrumentId], [instrumentName]) VALUES (1,N'Guitar')
INSERT [dbo].[instrument] ([instrumentId], [instrumentName]) VALUES (2,N'Vocal')
INSERT [dbo].[instrument] ([instrumentId], [instrumentName]) VALUES (3,N'Drums')
INSERT [dbo].[instrument] ([instrumentId], [instrumentName]) VALUES (4,N'Bass')


GO

INSERT [dbo].[phone] ([phoneNumber], [phoneType], [memberId]) VALUES (1231231234,N'Mobile',1)
INSERT [dbo].[phone] ([phoneNumber], [phoneType], [memberId]) VALUES (33415727,N'Work',1)
INSERT [dbo].[phone] ([phoneNumber], [phoneType], [memberId]) VALUES (12101827,N'Mobile',2)
INSERT [dbo].[phone] ([phoneNumber], [phoneType], [memberId]) VALUES (55278890,N'Mobile',3)


GO

INSERT [dbo].[phoneType] ([phoneTypeId], [phoneType]) VALUES (1,N'Mobile')
INSERT [dbo].[phoneType] ([phoneTypeId], [phoneType]) VALUES (2,N'Work')
INSERT [dbo].[phoneType] ([phoneTypeId], [phoneType]) VALUES (3,N'Bakery')













