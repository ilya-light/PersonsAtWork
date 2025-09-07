USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetStatuses]    Script Date: 07.09.2025 13:08:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetStatuses] AS
SELECT name FROM status;

GO

