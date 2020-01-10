USE [EFCoreDDD]
GO

/****** Object:  Table [dbo].[Enrollment]    Script Date: 1/9/2020 11:16:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Enrollment](
	[EnrollmentID] [bigint] IDENTITY(1,1) NOT NULL,
	[CourseID] [bigint] NOT NULL,
	[StudentID] [bigint] NOT NULL,
	[Grade] [int] NOT NULL,
 CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Course]
GO

ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO

ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Student]
GO
