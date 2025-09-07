USE [personsdb]
GO

/****** Object:  StoredProcedure [dbo].[GetPosts]    Script Date: 07.09.2025 13:08:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPosts] AS
SELECT name FROM posts;

GO

