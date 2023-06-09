USE [master]
GO
/****** Object:  Database [Bioskop]    Script Date: 2/3/2023 7:47:18 PM ******/
CREATE DATABASE [Bioskop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bioskop', FILENAME = N'C:\Users\cikam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Bioskop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bioskop_log', FILENAME = N'C:\Users\cikam\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Bioskop.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bioskop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bioskop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bioskop] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Bioskop] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Bioskop] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Bioskop] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Bioskop] SET ARITHABORT ON 
GO
ALTER DATABASE [Bioskop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bioskop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bioskop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bioskop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bioskop] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Bioskop] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Bioskop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bioskop] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Bioskop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bioskop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bioskop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bioskop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bioskop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bioskop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bioskop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bioskop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bioskop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bioskop] SET RECOVERY FULL 
GO
ALTER DATABASE [Bioskop] SET  MULTI_USER 
GO
ALTER DATABASE [Bioskop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bioskop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bioskop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bioskop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bioskop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bioskop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bioskop] SET QUERY_STORE = OFF
GO
USE [Bioskop]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[sifra] [varchar](50) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BioskopskaSala]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BioskopskaSala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[naziv_sale] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BioskopskaSala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv_filma] [varchar](50) NOT NULL,
	[opis_filma] [varchar](50) NULL,
	[trajanje_u_minutima] [int] NOT NULL,
	[datum_premijere] [date] NULL,
	[reziser_id] [int] NOT NULL,
	[zanr_id] [int] NOT NULL,
	[administrator_id] [int] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Karta]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Karta](
	[korisnik_id] [int] NOT NULL,
	[projekcija_id] [int] NOT NULL,
	[karta_id] [int] IDENTITY(1,1) NOT NULL,
	[sala_id] [int] NOT NULL,
	[sediste_id] [int] NOT NULL,
 CONSTRAINT [PK_Karta] PRIMARY KEY CLUSTERED 
(
	[projekcija_id] ASC,
	[korisnik_id] ASC,
	[karta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[datum_rodjenja] [date] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[sifra] [varchar](50) NOT NULL,
	[poeni] [int] NULL,
 CONSTRAINT [PK__Korisnik__3214EC0739B604DD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjekcijaFilma]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjekcijaFilma](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[datum_projekcije] [datetime] NOT NULL,
	[cena_karte] [numeric](10, 2) NOT NULL,
	[tip_projekcije] [int] NOT NULL,
	[sala_id] [int] NOT NULL,
	[film_id] [int] NOT NULL,
 CONSTRAINT [PK_ProjekcijaFilma] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[korisnik_id] [int] NOT NULL,
	[projekcija_id] [int] NOT NULL,
	[datum_rezervacije] [datetime] NOT NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[korisnik_id] ASC,
	[projekcija_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reziser]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reziser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reziser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sediste]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sediste](
	[sala_id] [int] NOT NULL,
	[sediste_id] [int] IDENTITY(1,1) NOT NULL,
	[red] [int] NOT NULL,
	[kolona] [int] NOT NULL,
 CONSTRAINT [PK_Sediste] PRIMARY KEY CLUSTERED 
(
	[sala_id] ASC,
	[sediste_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zanr]    Script Date: 2/3/2023 7:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zanr](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime_zanra] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Zanr] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([id], [email], [sifra], [ime], [prezime]) VALUES (1, N'234', N'234', N'Milan', N'Srdic')
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[BioskopskaSala] ON 

INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (5003, N'Arafat')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (5004, N'Smoki')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (5005, N'Delta City')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (6004, N'Beo meo')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (7004, N'Macak')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (9004, N'Galerija TC')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (10006, N'Martinic')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (10007, N'Novi sad')
INSERT [dbo].[BioskopskaSala] ([Id], [naziv_sale]) VALUES (10008, N'Roda Mega')
SET IDENTITY_INSERT [dbo].[BioskopskaSala] OFF
GO
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (6002, N'Petparacke price', N'Dobar film, jako dobar', 180, CAST(N'2023-02-03' AS Date), 1, 9, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (7002, N'Prokletnici', N'Medju boljima', 100, CAST(N'2023-02-03' AS Date), 1, 3, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (7003, N'Ulicni psi', N'Hit iz 1992. godine', 144, CAST(N'2023-02-05' AS Date), 1, 9, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (7004, N'Toma', N'Film o liku i delu Tomice Zdravkovica', 200, CAST(N'2023-07-12' AS Date), 5, 4, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (7005, N'Montevideo, vidimo se!', N'Najbolji srpski film u istoriji.', 123, CAST(N'2008-05-14' AS Date), 5, 10, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (8002, N'Nevidljivi svedok', N'odlicna radnja, plot twist na nivou', 158, CAST(N'2023-02-23' AS Date), 9, 13, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (9002, N'Toma', N'', 12, CAST(N'2023-02-02' AS Date), 1, 1, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (10002, N'Rane', N'', 111, CAST(N'2021-07-12' AS Date), 2, 9, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (11002, N'Dobri Momci', N'Jako dobri momci', 333, CAST(N'2023-03-15' AS Date), 3, 8, 1)
INSERT [dbo].[Film] ([id], [naziv_filma], [opis_filma], [trajanje_u_minutima], [datum_premijere], [reziser_id], [zanr_id], [administrator_id]) VALUES (11003, N'Doni Darko', N'Ozbiljan film', 4, CAST(N'2023-02-03' AS Date), 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Film] OFF
GO
SET IDENTITY_INSERT [dbo].[Karta] ON 

INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 11005, 19013, 5003, 14051)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 11005, 21013, 5003, 14052)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (2, 11005, 19014, 5003, 14053)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 11005, 21014, 5003, 14054)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 11006, 19015, 5003, 14051)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 11006, 19016, 5003, 14052)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 12005, 20017, 5003, 14056)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (1, 13005, 21015, 5003, 14054)
INSERT [dbo].[Karta] ([korisnik_id], [projekcija_id], [karta_id], [sala_id], [sediste_id]) VALUES (2, 13005, 21016, 5003, 14058)
SET IDENTITY_INSERT [dbo].[Karta] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([Id], [ime], [prezime], [datum_rodjenja], [email], [sifra], [poeni]) VALUES (1, N'Milan', N'Srdic', CAST(N'2000-06-05' AS Date), N'miki@gmail.com', N'123', 0)
INSERT [dbo].[Korisnik] ([Id], [ime], [prezime], [datum_rodjenja], [email], [sifra], [poeni]) VALUES (2, N'Jelena', N'Subotic', CAST(N'2000-08-15' AS Date), N'jeca@gmail.com', N'1', 9)
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjekcijaFilma] ON 

INSERT [dbo].[ProjekcijaFilma] ([id], [datum_projekcije], [cena_karte], [tip_projekcije], [sala_id], [film_id]) VALUES (11005, CAST(N'2023-02-04T01:20:19.000' AS DateTime), CAST(500.00 AS Numeric(10, 2)), 0, 5003, 6002)
INSERT [dbo].[ProjekcijaFilma] ([id], [datum_projekcije], [cena_karte], [tip_projekcije], [sala_id], [film_id]) VALUES (11006, CAST(N'2023-02-03T01:30:35.000' AS DateTime), CAST(555.00 AS Numeric(10, 2)), 0, 5003, 7002)
INSERT [dbo].[ProjekcijaFilma] ([id], [datum_projekcije], [cena_karte], [tip_projekcije], [sala_id], [film_id]) VALUES (12005, CAST(N'2023-03-15T07:44:51.000' AS DateTime), CAST(456.00 AS Numeric(10, 2)), 0, 5003, 11002)
INSERT [dbo].[ProjekcijaFilma] ([id], [datum_projekcije], [cena_karte], [tip_projekcije], [sala_id], [film_id]) VALUES (13005, CAST(N'2023-03-15T20:07:46.000' AS DateTime), CAST(456.00 AS Numeric(10, 2)), 0, 5003, 11002)
SET IDENTITY_INSERT [dbo].[ProjekcijaFilma] OFF
GO
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (1, 11005, CAST(N'2023-02-03T01:23:32.977' AS DateTime))
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (1, 11006, CAST(N'2023-02-03T01:28:57.640' AS DateTime))
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (1, 12005, CAST(N'2023-02-03T12:46:17.090' AS DateTime))
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (1, 13005, CAST(N'2023-02-03T14:09:19.990' AS DateTime))
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (2, 11005, CAST(N'2023-02-03T01:23:41.263' AS DateTime))
INSERT [dbo].[Rezervacija] ([korisnik_id], [projekcija_id], [datum_rezervacije]) VALUES (2, 13005, CAST(N'2023-02-03T14:09:28.753' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Reziser] ON 

INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (1, N'Quentin', N'Tarantino')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (2, N'Srdjan', N'Dragojevic')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (3, N'Martin', N'Skorseze')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (4, N'Stanley', N'Kubrick')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (5, N'Dragan', N'Bjelogrlic')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (6, N'Milos', N'Forman')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (7, N'Peter', N'Jackson')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (8, N'Steven', N'Spielberg')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (9, N'Oriol', N'Paulo')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (10, N'James', N'Cameron')
INSERT [dbo].[Reziser] ([id], [ime], [prezime]) VALUES (11, N'Christopher', N'Nolan')
SET IDENTITY_INSERT [dbo].[Reziser] OFF
GO
SET IDENTITY_INSERT [dbo].[Sediste] ON 

INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14051, 1, 1)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14052, 1, 3)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14053, 1, 4)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14054, 1, 5)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14055, 2, 1)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14056, 2, 2)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14057, 2, 3)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14058, 2, 4)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14059, 3, 1)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14060, 3, 2)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14061, 3, 3)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14062, 3, 4)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14063, 3, 5)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14064, 4, 1)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14065, 4, 2)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14066, 4, 3)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14067, 4, 4)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14068, 4, 5)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14069, 5, 1)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14070, 5, 2)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14071, 5, 3)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14072, 5, 4)
INSERT [dbo].[Sediste] ([sala_id], [sediste_id], [red], [kolona]) VALUES (5003, 14073, 5, 5)
SET IDENTITY_INSERT [dbo].[Sediste] OFF
GO
SET IDENTITY_INSERT [dbo].[Zanr] ON 

INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (1, N'avantura')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (2, N'animacija')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (3, N'akcija')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (4, N'biografski')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (5, N'vestern')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (6, N'deciji')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (7, N'dokumentarni')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (8, N'drama')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (9, N'krimi')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (10, N'komedija')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (11, N'ljubavni')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (12, N'sci-fi')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (13, N'triler')
INSERT [dbo].[Zanr] ([id], [ime_zanra]) VALUES (14, N'horor')
SET IDENTITY_INSERT [dbo].[Zanr] OFF
GO
/****** Object:  Index [karta_unique]    Script Date: 2/3/2023 7:47:18 PM ******/
ALTER TABLE [dbo].[Karta] ADD  CONSTRAINT [karta_unique] UNIQUE NONCLUSTERED 
(
	[projekcija_id] ASC,
	[sala_id] ASC,
	[sediste_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [email_jedinstven]    Script Date: 2/3/2023 7:47:18 PM ******/
ALTER TABLE [dbo].[Korisnik] ADD  CONSTRAINT [email_jedinstven] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [jedankorisnik]    Script Date: 2/3/2023 7:47:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [jedankorisnik] ON [dbo].[Rezervacija]
(
	[korisnik_id] ASC,
	[projekcija_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [sediste_unique]    Script Date: 2/3/2023 7:47:18 PM ******/
ALTER TABLE [dbo].[Sediste] ADD  CONSTRAINT [sediste_unique] UNIQUE NONCLUSTERED 
(
	[sala_id] ASC,
	[red] ASC,
	[kolona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnik] ADD  CONSTRAINT [DF__Korisnik__poeni__276EDEB3]  DEFAULT ((0)) FOR [poeni]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_Administrator] FOREIGN KEY([administrator_id])
REFERENCES [dbo].[Administrator] ([id])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_Administrator]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_Reziser] FOREIGN KEY([reziser_id])
REFERENCES [dbo].[Reziser] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_Reziser]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_Zanr] FOREIGN KEY([zanr_id])
REFERENCES [dbo].[Zanr] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_Zanr]
GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [FK_Karta_Rezervacija] FOREIGN KEY([korisnik_id], [projekcija_id])
REFERENCES [dbo].[Rezervacija] ([korisnik_id], [projekcija_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [FK_Karta_Rezervacija]
GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [FK_Karta_Sediste] FOREIGN KEY([sala_id], [sediste_id])
REFERENCES [dbo].[Sediste] ([sala_id], [sediste_id])
GO
ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [FK_Karta_Sediste]
GO
ALTER TABLE [dbo].[ProjekcijaFilma]  WITH CHECK ADD  CONSTRAINT [FK_ProjekcijaFilma_BioskopskaSala] FOREIGN KEY([sala_id])
REFERENCES [dbo].[BioskopskaSala] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProjekcijaFilma] CHECK CONSTRAINT [FK_ProjekcijaFilma_BioskopskaSala]
GO
ALTER TABLE [dbo].[ProjekcijaFilma]  WITH CHECK ADD  CONSTRAINT [FK_ProjekcijaFilma_Film] FOREIGN KEY([film_id])
REFERENCES [dbo].[Film] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProjekcijaFilma] CHECK CONSTRAINT [FK_ProjekcijaFilma_Film]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Korisnik] FOREIGN KEY([korisnik_id])
REFERENCES [dbo].[Korisnik] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Korisnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_ProjekcijaFilma] FOREIGN KEY([projekcija_id])
REFERENCES [dbo].[ProjekcijaFilma] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_ProjekcijaFilma]
GO
ALTER TABLE [dbo].[Sediste]  WITH CHECK ADD  CONSTRAINT [FK_Sediste_BioskopskaSala] FOREIGN KEY([sala_id])
REFERENCES [dbo].[BioskopskaSala] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sediste] CHECK CONSTRAINT [FK_Sediste_BioskopskaSala]
GO
USE [master]
GO
ALTER DATABASE [Bioskop] SET  READ_WRITE 
GO
