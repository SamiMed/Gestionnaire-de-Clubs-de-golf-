USE [master]
GO
/****** Object:  Database [BDB56Projet22]    Script Date: 12/15/2021 11:38:03 PM ******/
CREATE DATABASE [BDB56Projet22]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDB56Projet22', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDB56Projet22.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDB56Projet22_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDB56Projet22_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDB56Projet22] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDB56Projet22].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDB56Projet22] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDB56Projet22] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDB56Projet22] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDB56Projet22] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDB56Projet22] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDB56Projet22] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDB56Projet22] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDB56Projet22] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDB56Projet22] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDB56Projet22] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDB56Projet22] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDB56Projet22] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDB56Projet22] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDB56Projet22] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDB56Projet22] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDB56Projet22] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDB56Projet22] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDB56Projet22] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDB56Projet22] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDB56Projet22] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDB56Projet22] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDB56Projet22] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDB56Projet22] SET RECOVERY FULL 
GO
ALTER DATABASE [BDB56Projet22] SET  MULTI_USER 
GO
ALTER DATABASE [BDB56Projet22] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDB56Projet22] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDB56Projet22] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDB56Projet22] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDB56Projet22] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDB56Projet22] SET QUERY_STORE = OFF
GO
USE [BDB56Projet22]
GO
/****** Object:  Table [dbo].[Abonnements]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abonnements](
	[Id] [nvarchar](10) NOT NULL,
	[DateAbonnement] [date] NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Prenom] [nvarchar](50) NOT NULL,
	[Sexe] [varchar](1) NOT NULL,
	[DateNaissance] [date] NOT NULL,
	[NoCivique] [int] NOT NULL,
	[Rue] [nvarchar](50) NOT NULL,
	[Ville] [nvarchar](50) NOT NULL,
	[IdProvince] [varchar](2) NOT NULL,
	[CodePostal] [nvarchar](50) NOT NULL,
	[Telephone] [varchar](10) NOT NULL,
	[Cellulaire] [varchar](10) NULL,
	[Courriel] [nvarchar](50) NOT NULL,
	[NoTypeAbonnement] [int] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_Abonnements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dependants]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dependants](
	[Id] [varchar](60) NOT NULL,
	[Nom] [nvarchar](30) NOT NULL,
	[Prenom] [nvarchar](30) NOT NULL,
	[Sexe] [varchar](1) NOT NULL,
	[DateNaissance] [date] NOT NULL,
	[IdAbonnement] [nvarchar](10) NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dependants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Depenses]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depenses](
	[No] [int] NOT NULL,
	[IdAbonnement] [nvarchar](10) NOT NULL,
	[DateDepense] [date] NOT NULL,
	[Montant] [money] NOT NULL,
	[NoService] [int] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_Depenses] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employes]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employes](
	[No] [int] NOT NULL,
	[MotDePasse] [nvarchar](50) NOT NULL,
	[Nom] [nvarchar](30) NOT NULL,
	[Prenom] [nvarchar](30) NOT NULL,
	[Sexe] [varchar](1) NOT NULL,
	[Age] [int] NOT NULL,
	[NoCivique] [int] NOT NULL,
	[Rue] [nvarchar](50) NOT NULL,
	[Ville] [nvarchar](50) NOT NULL,
	[IdProvince] [varchar](2) NOT NULL,
	[CodePostal] [varchar](6) NOT NULL,
	[Telephone] [varchar](10) NOT NULL,
	[Cellulaire] [varchar](10) NULL,
	[Courriel] [nvarchar](50) NOT NULL,
	[SalaireHoraire] [money] NOT NULL,
	[NoTypeEmploye] [int] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoEmployes] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartiesJouees]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartiesJouees](
	[IdAbonnement] [nvarchar](10) NOT NULL,
	[NoTerrain] [int] NOT NULL,
	[DatePartie] [date] NOT NULL,
	[Pointage] [int] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_IdAbonnementNoTerrainDatePartie] PRIMARY KEY CLUSTERED 
(
	[IdAbonnement] ASC,
	[NoTerrain] ASC,
	[DatePartie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrixDepensesAbonnements]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrixDepensesAbonnements](
	[NoTypeAbonnement] [int] NOT NULL,
	[Annee] [date] NOT NULL,
	[Prix] [money] NOT NULL,
	[DepensesObligatoires] [money] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoTypeAbonnementAnnee] PRIMARY KEY CLUSTERED 
(
	[NoTypeAbonnement] ASC,
	[Annee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[Id] [varchar](2) NOT NULL,
	[Nom] [nvarchar](20) NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_IdProvinces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reabonnements]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reabonnements](
	[IdAbonnement] [nvarchar](10) NOT NULL,
	[DateRenouvellement] [date] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_IdAbonnementDateRenouvellement] PRIMARY KEY CLUSTERED 
(
	[IdAbonnement] ASC,
	[DateRenouvellement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[No] [int] NOT NULL,
	[TypeService] [nvarchar](50) NOT NULL,
	[NoEmploye] [int] NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoServices] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terrains]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terrains](
	[No] [int] NOT NULL,
	[Nom] [nvarchar](30) NOT NULL,
	[NombreTrous] [int] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoTerrains] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypesAbonnement]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypesAbonnement](
	[No] [int] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoTypesAbonnement] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypesEmploye]    Script Date: 12/15/2021 11:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypesEmploye](
	[No] [int] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Remarque] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoTypesEmploye] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Abonnements]  WITH CHECK ADD  CONSTRAINT [FK_Abonnements_IdProvince] FOREIGN KEY([IdProvince])
REFERENCES [dbo].[Provinces] ([Id])
GO
ALTER TABLE [dbo].[Abonnements] CHECK CONSTRAINT [FK_Abonnements_IdProvince]
GO
ALTER TABLE [dbo].[Abonnements]  WITH CHECK ADD  CONSTRAINT [FK_Abonnements_NoTypeAbonnement] FOREIGN KEY([NoTypeAbonnement])
REFERENCES [dbo].[TypesAbonnement] ([No])
GO
ALTER TABLE [dbo].[Abonnements] CHECK CONSTRAINT [FK_Abonnements_NoTypeAbonnement]
GO
ALTER TABLE [dbo].[Dependants]  WITH CHECK ADD  CONSTRAINT [FK_Dependants_IdAbonnement] FOREIGN KEY([IdAbonnement])
REFERENCES [dbo].[Abonnements] ([Id])
GO
ALTER TABLE [dbo].[Dependants] CHECK CONSTRAINT [FK_Dependants_IdAbonnement]
GO
ALTER TABLE [dbo].[Depenses]  WITH CHECK ADD  CONSTRAINT [FK_Depenses_IdAbonnement] FOREIGN KEY([IdAbonnement])
REFERENCES [dbo].[Abonnements] ([Id])
GO
ALTER TABLE [dbo].[Depenses] CHECK CONSTRAINT [FK_Depenses_IdAbonnement]
GO
ALTER TABLE [dbo].[Depenses]  WITH CHECK ADD  CONSTRAINT [FK_Depenses_NoService] FOREIGN KEY([NoService])
REFERENCES [dbo].[Services] ([No])
GO
ALTER TABLE [dbo].[Depenses] CHECK CONSTRAINT [FK_Depenses_NoService]
GO
ALTER TABLE [dbo].[Employes]  WITH CHECK ADD  CONSTRAINT [FK_Employes_IdProvince] FOREIGN KEY([IdProvince])
REFERENCES [dbo].[Provinces] ([Id])
GO
ALTER TABLE [dbo].[Employes] CHECK CONSTRAINT [FK_Employes_IdProvince]
GO
ALTER TABLE [dbo].[Employes]  WITH CHECK ADD  CONSTRAINT [FK_Employes_NoTypeEmploye] FOREIGN KEY([NoTypeEmploye])
REFERENCES [dbo].[TypesEmploye] ([No])
GO
ALTER TABLE [dbo].[Employes] CHECK CONSTRAINT [FK_Employes_NoTypeEmploye]
GO
ALTER TABLE [dbo].[PartiesJouees]  WITH CHECK ADD  CONSTRAINT [FK_PartiesJouees_IdAbonnement] FOREIGN KEY([IdAbonnement])
REFERENCES [dbo].[Abonnements] ([Id])
GO
ALTER TABLE [dbo].[PartiesJouees] CHECK CONSTRAINT [FK_PartiesJouees_IdAbonnement]
GO
ALTER TABLE [dbo].[PartiesJouees]  WITH CHECK ADD  CONSTRAINT [FK_PartiesJouees_NoTerrain] FOREIGN KEY([NoTerrain])
REFERENCES [dbo].[Terrains] ([No])
GO
ALTER TABLE [dbo].[PartiesJouees] CHECK CONSTRAINT [FK_PartiesJouees_NoTerrain]
GO
ALTER TABLE [dbo].[PrixDepensesAbonnements]  WITH CHECK ADD  CONSTRAINT [FK_PrixDepensesAbonnements_NoTypeAbonnement] FOREIGN KEY([NoTypeAbonnement])
REFERENCES [dbo].[TypesAbonnement] ([No])
GO
ALTER TABLE [dbo].[PrixDepensesAbonnements] CHECK CONSTRAINT [FK_PrixDepensesAbonnements_NoTypeAbonnement]
GO
ALTER TABLE [dbo].[Reabonnements]  WITH CHECK ADD  CONSTRAINT [FK_Reabonnements_IdAbonnement] FOREIGN KEY([IdAbonnement])
REFERENCES [dbo].[Abonnements] ([Id])
GO
ALTER TABLE [dbo].[Reabonnements] CHECK CONSTRAINT [FK_Reabonnements_IdAbonnement]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_NoEmploye] FOREIGN KEY([NoEmploye])
REFERENCES [dbo].[Employes] ([No])
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_NoEmploye]
GO
ALTER TABLE [dbo].[Abonnements]  WITH CHECK ADD  CONSTRAINT [CK_SexeAbonnements] CHECK  (([Sexe] like 'H' OR [Sexe] like 'F'))
GO
ALTER TABLE [dbo].[Abonnements] CHECK CONSTRAINT [CK_SexeAbonnements]
GO
ALTER TABLE [dbo].[Dependants]  WITH CHECK ADD  CONSTRAINT [CK_SexeDependants] CHECK  (([Sexe] like 'H' OR [Sexe] like 'F'))
GO
ALTER TABLE [dbo].[Dependants] CHECK CONSTRAINT [CK_SexeDependants]
GO
ALTER TABLE [dbo].[Employes]  WITH CHECK ADD  CONSTRAINT [CK_SexeEmployes] CHECK  (([Sexe] like 'H' OR [Sexe] like 'F'))
GO
ALTER TABLE [dbo].[Employes] CHECK CONSTRAINT [CK_SexeEmployes]
GO
USE [master]
GO
ALTER DATABASE [BDB56Projet22] SET  READ_WRITE 
GO
