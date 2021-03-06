USE [master]
GO
/****** Object:  Database [Generala]    Script Date: 18/11/2016 21:48:09 ******/
CREATE DATABASE [Generala]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Generala', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Generala.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Generala_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Generala_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Generala] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Generala].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Generala] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Generala] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Generala] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Generala] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Generala] SET ARITHABORT OFF 
GO
ALTER DATABASE [Generala] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Generala] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Generala] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Generala] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Generala] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Generala] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Generala] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Generala] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Generala] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Generala] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Generala] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Generala] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Generala] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Generala] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Generala] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Generala] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Generala] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Generala] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Generala] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Generala] SET  MULTI_USER 
GO
ALTER DATABASE [Generala] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Generala] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Generala] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Generala] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Generala]
GO
/****** Object:  StoredProcedure [dbo].[CalcularJugadorID]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CalcularJugadorID]
AS
BEGIN
	declare @id int = (select count(*) from JUGADOR)
	IF @id > 0
	BEGIN
		set @id = (select max(id) from JUGADOR)
	END
	set @id += 1
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[CalcularPartidoID]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CalcularPartidoID]
AS
BEGIN
	declare @id int = (select count(*) from PARTIDO_JUGADOR)
	IF @id > 0
	BEGIN
		set @id = (select max(id_partido) from PARTIDO_JUGADOR)
	END
	set @id += 1
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[ConseguirJugadorID]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ConseguirJugadorID]
	@user_name varchar(50)
AS
BEGIN
	SELECT id FROM JUGADOR where user_name = @user_name
END

GO
/****** Object:  StoredProcedure [dbo].[ControlLogin]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ControlLogin]
	@user_name varchar(50), @password varchar(50)
AS
BEGIN
	SELECT COUNT(*) FROM JUGADOR WHERE user_name = @user_name and password = @password
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarJugador]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarJugador]
	-- Add the parameters for the stored procedure here
	@id int, @user varchar(50), @password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	INSERT INTO JUGADOR (id,user_name,password) VALUES (@id,@user,@password) 
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarPartido]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarPartido]
	@id_jugador int, @id_partido int, @puntaje int,
	@resultado varchar(1), @tiempo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    -- Insert statements for procedure here
	INSERT INTO PARTIDO_JUGADOR(id_jugador,id_partido,puntaje,resultado,tiempo) VALUES (@id_jugador,@id_partido,@puntaje, @resultado, @tiempo) 
END

GO
/****** Object:  StoredProcedure [dbo].[PromedioVictorias]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PromedioVictorias]
AS
BEGIN
select jugador, (select user_name from JUGADOR where id = jugador) as username, total jugadas,
	total_ganados, (total_ganados * 100 / total) promedio_victorias
	from (
	select id_jugador as jugador, 
	count(1) as total, 
	sum(IIF(resultado = 'G',1,0)) as total_ganados
	from PARTIDO_JUGADOR 
	group by id_jugador
	)
result
END

GO
/****** Object:  StoredProcedure [dbo].[TiempoJugado]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TiempoJugado]
	
AS
BEGIN
  SELECT ID_JUGADOR, (SELECT USER_NAME FROM JUGADOR WHERE ID = ID_JUGADOR) AS USERNAME, SUM(TIEMPO) AS TIEMPO_SEGUNDOS FROM PARTIDO_JUGADOR GROUP BY ID_JUGADOR
END

GO
/****** Object:  StoredProcedure [dbo].[VerificarExistenciaJugador]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[VerificarExistenciaJugador]
	@user_name varchar(50)
AS
BEGIN
    -- Insert statements for procedure here
	SELECT COUNT(*) FROM JUGADOR WHERE user_name = @user_name
END

GO
/****** Object:  StoredProcedure [dbo].[VictoriasDerrotasEmpates]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[VictoriasDerrotasEmpates]
	
AS
BEGIN
	select jugador, (select user_name from JUGADOR where id = jugador) as username, total jugadas,
	ganados, empatados, perdidos
	from (
	select id_jugador as jugador, 
	count(1) as total, 
	sum(IIF(resultado = 'G',1,0)) as ganados,
	sum(IIF(resultado = 'E',1,0)) as empatados,
	sum(IIF(resultado = 'P',1,0)) as perdidos
	from PARTIDO_JUGADOR 
	group by id_jugador
)
result
END

GO
/****** Object:  Table [dbo].[JUGADOR]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JUGADOR](
	[id] [int] NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_JUGADOR] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PARTIDO_JUGADOR]    Script Date: 18/11/2016 21:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PARTIDO_JUGADOR](
	[id_jugador] [int] NULL,
	[id_partido] [int] NULL,
	[puntaje] [int] NULL,
	[resultado] [varchar](1) NULL,
	[tiempo] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[JUGADOR] ([id], [user_name], [password]) VALUES (1, N'Cristian', N'pass')
INSERT [dbo].[JUGADOR] ([id], [user_name], [password]) VALUES (2, N'Juan', N'juancho')
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (1, 1, 10040, N'G', 56)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (2, 1, 16, N'P', 56)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (1, 2, 10065, N'P', 495)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (2, 2, 168, N'G', 495)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (1, 3, 10003, N'P', 18)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (2, 3, 6, N'G', 18)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (1, 4, 10006, N'G', 20)
INSERT [dbo].[PARTIDO_JUGADOR] ([id_jugador], [id_partido], [puntaje], [resultado], [tiempo]) VALUES (2, 4, 4, N'P', 20)
USE [master]
GO
ALTER DATABASE [Generala] SET  READ_WRITE 
GO
