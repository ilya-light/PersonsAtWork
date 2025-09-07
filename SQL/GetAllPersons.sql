USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetAllPersons]    Script Date: 07.09.2025 13:06:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllPersons]
	@OrderByColumn NVARCHAR(20) = ''
AS
BEGIN
	SELECT p.second_name as second_name, p.first_name AS first_name, p.last_name as last_name, s.name AS status, d.name, posts.name, p.date_employ, p.date_uneploy FROM persons AS p
	INNER JOIN status AS s ON p.status = s.id
	INNER JOIN deps AS d ON p.status = d.id
	INNER JOIN posts ON p.status = posts.id
END;
GO

