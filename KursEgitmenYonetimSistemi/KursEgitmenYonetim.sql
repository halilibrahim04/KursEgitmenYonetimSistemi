USE [master]
GO
/****** Object:  Database [KursEgitmenYonetim]    Script Date: 9.06.2025 00:05:53 ******/
CREATE DATABASE [KursEgitmenYonetim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KursEgitmenYonetim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\KursEgitmenYonetim.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KursEgitmenYonetim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\KursEgitmenYonetim_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [KursEgitmenYonetim] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KursEgitmenYonetim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KursEgitmenYonetim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ARITHABORT OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KursEgitmenYonetim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KursEgitmenYonetim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KursEgitmenYonetim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KursEgitmenYonetim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET RECOVERY FULL 
GO
ALTER DATABASE [KursEgitmenYonetim] SET  MULTI_USER 
GO
ALTER DATABASE [KursEgitmenYonetim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KursEgitmenYonetim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KursEgitmenYonetim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KursEgitmenYonetim] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KursEgitmenYonetim] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KursEgitmenYonetim] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'KursEgitmenYonetim', N'ON'
GO
ALTER DATABASE [KursEgitmenYonetim] SET QUERY_STORE = ON
GO
ALTER DATABASE [KursEgitmenYonetim] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [KursEgitmenYonetim]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 9.06.2025 00:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egitmen]    Script Date: 9.06.2025 00:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egitmen](
	[EgitmenID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](100) NULL,
	[UzmanlikAlani] [nvarchar](50) NULL,
	[BildigiDiller] [nvarchar](200) NULL,
	[KullandigiMalzemeler] [nvarchar](200) NULL,
	[CalabildigiEnstrumanlar] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[EgitmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 9.06.2025 00:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[KursID] [int] IDENTITY(1,1) NOT NULL,
	[KursAdi] [nvarchar](100) NULL,
	[KursTuru] [nvarchar](50) NULL,
	[Dil] [nvarchar](50) NULL,
	[Seviye] [nvarchar](50) NULL,
	[ProgramlamaDili] [nvarchar](50) NULL,
	[Zorluk] [nvarchar](50) NULL,
	[EgitmenID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KursID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD FOREIGN KEY([EgitmenID])
REFERENCES [dbo].[Egitmen] ([EgitmenID])
GO
USE [master]
GO
ALTER DATABASE [KursEgitmenYonetim] SET  READ_WRITE 
GO
