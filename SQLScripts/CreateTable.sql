USE [MakaleApiDb]
GO

/****** Object:  Table [dbo].[Article]    Script Date: 30.10.2020 03:34:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Detail] [nvarchar](max) NOT NULL,
	[Permalink] [nvarchar](50) NOT NULL,
	[File1] [nvarchar](50) NULL,
	[File2] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[isActive] [bit] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


