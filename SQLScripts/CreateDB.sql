USE [master]
GO

/****** Object:  Database [MakaleApiDb]    Script Date: 30.10.2020 03:33:37 ******/
CREATE DATABASE [MakaleApiDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MakaleApiDb', FILENAME = N'C:\Users\mehmettas\MakaleApiDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MakaleApiDb_log', FILENAME = N'C:\Users\mehmettas\MakaleApiDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MakaleApiDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MakaleApiDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MakaleApiDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MakaleApiDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MakaleApiDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MakaleApiDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [MakaleApiDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MakaleApiDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MakaleApiDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MakaleApiDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MakaleApiDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MakaleApiDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MakaleApiDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MakaleApiDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MakaleApiDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MakaleApiDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MakaleApiDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MakaleApiDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MakaleApiDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MakaleApiDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MakaleApiDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MakaleApiDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MakaleApiDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MakaleApiDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [MakaleApiDb] SET  MULTI_USER 
GO

ALTER DATABASE [MakaleApiDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MakaleApiDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MakaleApiDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MakaleApiDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MakaleApiDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MakaleApiDb] SET QUERY_STORE = OFF
GO

USE [MakaleApiDb]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [MakaleApiDb] SET  READ_WRITE 
GO


