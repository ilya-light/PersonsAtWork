USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetDeps]    Script Date: 07.09.2025 13:07:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDeps] AS
SELECT name FROM deps;

GO

