USE [KARKAS_ORNEK]
GO

/****** Object:  Table [ORNEKLER].[BUTUN_VERI_YAPILARI_2008R2]    Script Date: 07/29/2013 00:08:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [ORNEKLER].[BUTUN_VERI_YAPILARI_2008R2](
	[ButunVeriYapilari2008R2Key] [int] IDENTITY(1,1) NOT NULL,
	[BigIntColumn] [bigint] NULL,
	[BinaryColumn] [binary](50) NULL,
	[BitColumn] [bit] NULL,
	[CharColumn] [char](10) NULL,
	[DateColumn] [date] NULL,
	[DateTimeColumn] [datetime] NULL,
	[DateTime2Column] [datetime2](7) NULL,
	[DateTimeOffsetColumn] [datetimeoffset](7) NULL,
	[DecimalColumn] [decimal](18, 0) NULL,
	[FloatColumn] [float] NULL,
	[GeopgraphyColummn] [geography] NULL,
	[GeometryColumn] [geometry] NULL,
	[HierarchyIdColumn] [hierarchyid] NULL,
	[ImageColumn] [image] NULL,
	[IntColumn] [int] NULL,
	[MoneyColumn] [money] NULL,
	[NCharColumn] [nchar](10) NULL,
	[NTextColumn] [ntext] NULL,
	[NumericColumn] [numeric](18, 0) NULL,
	[NVarcharColumn] [nvarchar](50) NULL,
	[NVarcharMaxColumn] [nvarchar](max) NULL,
	[RealColumn] [real] NULL,
	[smallDateTimeColumn] [smalldatetime] NULL,
	[smallIntColumn] [smallint] NULL,
	[SmallMoneyColumn] [smallmoney] NULL,
	[SqlVariantColumn] [sql_variant] NULL,
	[TextColumn] [text] NULL,
	[TimeColumn] [time](7) NULL,
	[TimestampColumn] [timestamp] NULL,
	[TinyIntColumn] [tinyint] NULL,
	[UniqueIdentifierColumn] [uniqueidentifier] NULL,
	[VarBinaryColumn] [varbinary](50) NULL,
	[VarBinaryMaxColumn] [varbinary](max) NULL,
	[VarCharColumn] [varchar](50) NULL,
	[VarCharMaxColumn] [varchar](max) NULL,
	[XmlColumn] [xml] NULL,
 CONSTRAINT [PK_BUTUN_VERI_YAPILARI_2008R2] PRIMARY KEY CLUSTERED 
(
	[ButunVeriYapilari2008R2Key] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


