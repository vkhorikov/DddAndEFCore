USE [EFCoreDDD]
GO
BEGIN TRANSACTION
GO
CREATE TABLE [dbo].[Suffix](
	[SuffixID] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Suffix] PRIMARY KEY CLUSTERED 
(
	[SuffixID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[Suffix] ([SuffixID], [Name]) VALUES (1, N'Jr')
INSERT [dbo].[Suffix] ([SuffixID], [Name]) VALUES (2, N'Sr')

ALTER TABLE dbo.Student ADD
	[NameSuffixID] [bigint] NULL

ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Suffix] FOREIGN KEY([NameSuffixID])
REFERENCES [dbo].[Suffix] ([SuffixID])

COMMIT
GO