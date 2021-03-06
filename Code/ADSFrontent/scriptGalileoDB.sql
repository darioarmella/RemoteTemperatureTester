USE [GalileoDB]
GO
/****** Object:  Table [dbo].[Sensor]    Script Date: 05/06/2016 02:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sensor](
	[SensorId] [int] NOT NULL,
	[DeviceId] [int] NOT NULL,
 CONSTRAINT [PK_Sensor] PRIMARY KEY CLUSTERED 
(
	[SensorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 05/06/2016 02:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventDevice]    Script Date: 05/06/2016 02:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EventDevice](
	[EventDevice] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[LocationId] [int] NOT NULL,
	[CustomerIdentification] [varchar](50) NOT NULL,
	[DeviceId] [int] NOT NULL,
 CONSTRAINT [PK_EventDevice] PRIMARY KEY CLUSTERED 
(
	[EventDevice] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Device]    Script Date: 05/06/2016 02:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceId] [int] NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
