CREATE DATABASE [EFCoreDDD]
go
USE [EFCoreDDD]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 11/19/2019 4:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/19/2019 4:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[FavoriteCourseID] [bigint] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Course] ON 

GO
INSERT [dbo].[Course] ([CourseID], [Name]) VALUES (1, N'Calculus')
GO
INSERT [dbo].[Course] ([CourseID], [Name]) VALUES (2, N'Chemistry')
GO
INSERT [dbo].[Course] ([CourseID], [Name]) VALUES (3, N'Literature')
GO
INSERT [dbo].[Course] ([CourseID], [Name]) VALUES (4, N'Trigonometry')
GO
INSERT [dbo].[Course] ([CourseID], [Name]) VALUES (5, N'Microeconomics')
GO
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

GO
INSERT [dbo].[Student] ([StudentID], [Name], [Email], [FavoriteCourseID]) VALUES (1, N'Alice', N'alice@gmail.com', 2)
GO
INSERT [dbo].[Student] ([StudentID], [Name], [Email], [FavoriteCourseID]) VALUES (2, N'Bob', N'bob@outlook.com', 2)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Course] FOREIGN KEY([FavoriteCourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Course]
GO
