USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetEmploy]    Script Date: 07.09.2025 13:07:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetEmploy]
	@date_from DATE,
	@date_to DATE,
	@status_filter varchar(20)
AS
SELECT date_employ, count(date_employ) FROM persons AS p INNER JOIN status AS s ON p.status = s.id
WHERE date_employ >= @date_from AND date_employ <= @date_to AND s.name = @status_filter
GROUP BY date_employ;

EXEC GetEmploy '2022-01-01', '2024-01-01';
GO

