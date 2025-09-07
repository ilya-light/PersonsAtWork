USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetUneploy]    Script Date: 07.09.2025 13:08:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUneploy]
	@date_from DATE,
	@date_to DATE,
	@status_filter varchar(20)
AS
SELECT date_uneploy, count(date_uneploy) FROM persons AS p INNER JOIN status AS s ON p.status = s.id
WHERE date_uneploy >= @date_from AND date_uneploy <= @date_to AND s.name = @status_filter
GROUP BY date_uneploy;
GO

