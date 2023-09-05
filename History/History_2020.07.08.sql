/****** Object:  StoredProcedure [dbo].[spProdBarati]    Script Date: 2020-07-08 2:10:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spProdBarati]') AND type IN (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spProdBarati] AS' 
END
GO

-- =============================================
-- Author:		Merab aghniashvili
-- Create date: 07-07-2020
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[spProdBarati] 
	-- Add the parameters for the stored procedure here
	@D1 DATE, 
	@D2 DATE,
	@IdProd NVARCHAR(150),
	@IdOrg INT
AS
BEGIN
	
	DECLARE @tbl TABLE (
		IdProd NVARCHAR(150),
		Prod NVARCHAR(350),
		Data DATE,
		IdProek INT,
		IdProekSector INT, 
		ProekSectorZone NVARCHAR(50),
		Shem NUMERIC(18,2),
		Gas NUMERIC(18,2)
	)

	--შემოსავალი
	INSERT INTO @tbl(IdProek,IdProekSector,ProekSectorZone,IdProd, Prod, Data, Shem)
	SELECT IdProek,IdProekSector,ProekSectorZone,IdProd,Prod,Data,SUM(Raod) 
	FROM dbo.Shem1 INNER JOIN dbo.Shem2 ON Shem2.IdShem1 = Shem1.IdShem1
	WHERE Data BETWEEN @D1 AND @D2 AND IdProd = @IdProd AND (IdOrg = @IdOrg OR @IdOrg = 0)
	GROUP BY IdProd,Prod,Data,IdProek,IdProekSector,ProekSectorZone

	--გასავალი
	INSERT INTO @tbl(IdProek,IdProekSector,ProekSectorZone,IdProd, Prod, Data, Gas)
	SELECT IdProek,IdProekSector,ProekSectorZone,IdProd,Prod,Data,SUM(Raod) 
	FROM dbo.Gas1 INNER JOIN dbo.Gas2 ON Gas2.IdGas1 = Gas1.IdGas1
	WHERE Data BETWEEN @D1 AND @D2 AND IdProd = @IdProd AND (IdOrg = @IdOrg OR @IdOrg = 0)
	GROUP BY IdProd,Prod,Data,IdProek,IdProekSector,ProekSectorZone

	SELECT IdProd, Prod, Data, IdProek, IdProekSector, ProekSectorZone, Shem,Gas FROM @tbl
	ORDER BY Data,IdProd

END
GO


/****** Object:  View [dbo].[ShemView]    Script Date: 2020-07-08 2:37:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[ShemView]
AS
SELECT        dbo.Shem1.IdShem1, dbo.Shem1.Data, dbo.Shem2.IdShem2, dbo.Shem2.IdProd, dbo.Shem2.Raod, dbo.ShemT.IdShemT, dbo.ShemT.ShemT, dbo.Proek.IdProek, dbo.Proek.Proek, dbo.ProekT.IdProekT, dbo.ProekT.ProekT, 
                         dbo.Org.IdOrg, dbo.Org.Org, dbo.OrgT.IdOrgT, dbo.OrgT.OrgT, dbo.Org.Sagad, dbo.Org.Address, dbo.Org.Email, dbo.Org.Direk, dbo.Org.Contact, dbo.Shem1.Shen, dbo.Shem1.TotalOcupatedArea, dbo.Shem1.Zedd, 
                         dbo.Shem1.KeepengData1, dbo.Shem1.KeepengData2, dbo.Shem2.UN, dbo.Shem2.CD, dbo.Shem2.CD1, dbo.ProekSector.IdProekSector, dbo.ProekSector.ProekSector, dbo.Shem2.ProekSectorZone, dbo.Shem2.Prod, 
                         dbo.Shem2.PartNumber, dbo.Unit.IdUnit, dbo.Unit.Unit, dbo.Shem2.CompRaod, dbo.Shem2.RaodInBox, dbo.Shem2.Palet, dbo.Shem2.Weight, dbo.Shem2.Fasi, dbo.Shem2.Cnumber, dbo.Shem2.Anumber, 
                         dbo.Shem2.Shen AS Expr1, dbo.Valuta.IdValuta, dbo.Valuta.Valuta, dbo.CustomClearanceMode.IdCustomClearanceMode, dbo.CustomClearanceMode.CustomClearanceMode
FROM            dbo.Shem1 INNER JOIN
                         dbo.Shem2 ON dbo.Shem1.IdShem1 = dbo.Shem2.IdShem1 INNER JOIN
                         dbo.ShemT ON dbo.Shem1.IdShemT = dbo.ShemT.IdShemT INNER JOIN
                         dbo.Proek ON dbo.Shem1.IdProek = dbo.Proek.IdProek INNER JOIN
                         dbo.Org ON dbo.Shem1.IdOrg = dbo.Org.IdOrg INNER JOIN
                         dbo.OrgT ON dbo.Org.IdOrgT = dbo.OrgT.IdOrgT INNER JOIN
                         dbo.ProekT ON dbo.Proek.IdProekT = dbo.ProekT.IdProekT INNER JOIN
                         dbo.ProekSector ON dbo.Shem2.IdProekSector = dbo.ProekSector.IdProekSector INNER JOIN
                         dbo.Unit ON dbo.Shem2.IdUnit = dbo.Unit.IdUnit INNER JOIN
                         dbo.Valuta ON dbo.Shem2.IdValuta = dbo.Valuta.IdValuta INNER JOIN
                         dbo.CustomClearanceMode ON dbo.Shem2.IdCustomClearanceMode = dbo.CustomClearanceMode.IdCustomClearanceMode
GO

/****** Object:  View [dbo].[GasView]    Script Date: 2020-07-08 2:39:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[GasView]
AS
SELECT        dbo.Gas1.IdGas1, dbo.Gas1.Data, dbo.Gas1.Shen, dbo.Gas2.IdGas2, dbo.Gas2.IdProd, dbo.Gas2.Raod, dbo.GasT.IdGasT, dbo.GasT.GasT, dbo.Gas2.UN, dbo.Gas2.CD, dbo.Gas2.CD1, dbo.Proek.IdProek, dbo.Proek.Proek, 
                         dbo.ProekT.IdProekT, dbo.ProekT.ProekT, dbo.Org.IdOrg, dbo.Org.Org, dbo.Org.Sagad, dbo.Org.Address, dbo.Org.Email, dbo.Org.Direk, dbo.Org.Contact, dbo.OrgT.IdOrgT, dbo.OrgT.OrgT, dbo.Gas2.ProekSectorZone, 
                         dbo.ProekSector.ProekSector, dbo.ProekSector.IdProekSector, dbo.Gas1.TotalOcupatedArea
FROM            dbo.Gas1 INNER JOIN
                         dbo.Gas2 ON dbo.Gas1.IdGas1 = dbo.Gas2.IdGas1 INNER JOIN
                         dbo.GasT ON dbo.Gas1.IdGasT = dbo.GasT.IdGasT INNER JOIN
                         dbo.Proek ON dbo.Gas1.IdProek = dbo.Proek.IdProek INNER JOIN
                         dbo.ProekT ON dbo.Proek.IdProekT = dbo.ProekT.IdProekT INNER JOIN
                         dbo.Org ON dbo.Gas1.IdOrg = dbo.Org.IdOrg INNER JOIN
                         dbo.OrgT ON dbo.Org.IdOrgT = dbo.OrgT.IdOrgT INNER JOIN
                         dbo.ProekSector ON dbo.Gas2.IdProekSector = dbo.ProekSector.IdProekSector
GO


/****** Object:  Table [dbo].[AgceraT]    Script Date: 2020-07-08 4:25:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AgceraT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AgceraT](
	[IdAgceraT] [smallint] IDENTITY(1,1) NOT NULL,
	[AgceraT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AgceraT] PRIMARY KEY CLUSTERED 
(
	[IdAgceraT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO



/****** Object:  Table [dbo].[Agcera1]    Script Date: 2020-07-08 4:39:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agcera1]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Agcera1](
	[IdAgcera1] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[IdOrg] [int] NOT NULL,
	[IdProek] [smallint] NOT NULL,
	[IdAgceraT] [smallint] NOT NULL,
	[Shen] [nvarchar](150) NOT NULL,
	[UN] [nvarchar](50) NOT NULL,
	[CD] [smalldatetime] NOT NULL,
	[CD1] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Agcera1] PRIMARY KEY CLUSTERED 
(
	[IdAgcera1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Agcera1_CD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Agcera1] ADD  CONSTRAINT [DF_Agcera1_CD]  DEFAULT (getdate()) FOR [CD]
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Agcera1_CD1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Agcera1] ADD  CONSTRAINT [DF_Agcera1_CD1]  DEFAULT (getdate()) FOR [CD1]
END
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_AgceraT]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1]  WITH CHECK ADD  CONSTRAINT [FK_Agcera1_AgceraT] FOREIGN KEY([IdAgceraT])
REFERENCES [dbo].[AgceraT] ([IdAgceraT])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_AgceraT]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1] CHECK CONSTRAINT [FK_Agcera1_AgceraT]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_Org]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1]  WITH CHECK ADD  CONSTRAINT [FK_Agcera1_Org] FOREIGN KEY([IdOrg])
REFERENCES [dbo].[Org] ([IdOrg])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_Org]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1] CHECK CONSTRAINT [FK_Agcera1_Org]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_Proek]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1]  WITH CHECK ADD  CONSTRAINT [FK_Agcera1_Proek] FOREIGN KEY([IdProek])
REFERENCES [dbo].[Proek] ([IdProek])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera1_Proek]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera1]'))
ALTER TABLE [dbo].[Agcera1] CHECK CONSTRAINT [FK_Agcera1_Proek]
GO

/****** Object:  Table [dbo].[Agcera2]    Script Date: 2020-07-08 4:33:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agcera2]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Agcera2](
	[IdAgcera2] [int] IDENTITY(1,1) NOT NULL,
	[IdAgcera1] [int] NOT NULL,
	[IdProekSector] [smallint] NOT NULL,
	[ProekSectorZone] [nvarchar](150) NOT NULL,
	[IdProd] [nvarchar](150) NOT NULL,
	[Prod] [nvarchar](250) NOT NULL,
	[Raod] [numeric](18, 2) NOT NULL,
	[UN] [nvarchar](50) NOT NULL,
	[CD] [smalldatetime] NOT NULL,
	[CD1] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Agcera2] PRIMARY KEY CLUSTERED 
(
	[IdAgcera2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Agcera2_CD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Agcera2] ADD  CONSTRAINT [DF_Agcera2_CD]  DEFAULT (getdate()) FOR [CD]
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Agcera2_CD1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Agcera2] ADD  CONSTRAINT [DF_Agcera2_CD1]  DEFAULT (getdate()) FOR [CD1]
END
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera2_Agcera1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera2]'))
ALTER TABLE [dbo].[Agcera2]  WITH CHECK ADD  CONSTRAINT [FK_Agcera2_Agcera1] FOREIGN KEY([IdAgcera1])
REFERENCES [dbo].[Agcera1] ([IdAgcera1])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera2_Agcera1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera2]'))
ALTER TABLE [dbo].[Agcera2] CHECK CONSTRAINT [FK_Agcera2_Agcera1]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera2_ProekSector]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera2]'))
ALTER TABLE [dbo].[Agcera2]  WITH CHECK ADD  CONSTRAINT [FK_Agcera2_ProekSector] FOREIGN KEY([IdProekSector])
REFERENCES [dbo].[ProekSector] ([IdProekSector])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Agcera2_ProekSector]') AND parent_object_id = OBJECT_ID(N'[dbo].[Agcera2]'))
ALTER TABLE [dbo].[Agcera2] CHECK CONSTRAINT [FK_Agcera2_ProekSector]
GO

/****** Object:  View [dbo].[Agcera1View]    Script Date: 2020-07-08 4:40:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Agcera1View]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[Agcera1View]
AS
SELECT        dbo.Agcera1.IdAgcera1, dbo.Agcera1.Data, dbo.Agcera1.Shen, dbo.Agcera1.UN, dbo.Agcera1.CD, dbo.Agcera1.CD1, dbo.AgceraT.IdAgceraT, dbo.AgceraT.AgceraT, dbo.Proek.IdProek, dbo.Proek.Proek, dbo.ProekT.IdProekT, 
                         dbo.ProekT.ProekT, dbo.Org.IdOrg, dbo.Org.Org
FROM            dbo.Agcera1 INNER JOIN
                         dbo.AgceraT ON dbo.Agcera1.IdAgceraT = dbo.AgceraT.IdAgceraT INNER JOIN
                         dbo.Proek ON dbo.Agcera1.IdProek = dbo.Proek.IdProek INNER JOIN
                         dbo.ProekT ON dbo.Proek.IdProekT = dbo.ProekT.IdProekT INNER JOIN
                         dbo.Org ON dbo.Agcera1.IdOrg = dbo.Org.IdOrg
' 
GO

/****** Object:  View [dbo].[Agcera2View]    Script Date: 2020-07-08 4:34:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Agcera2View]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[Agcera2View]
AS
SELECT        dbo.Agcera2.IdAgcera2, dbo.Agcera2.IdAgcera1, dbo.Agcera2.ProekSectorZone, dbo.Agcera2.Raod, dbo.Agcera2.UN, dbo.Agcera2.CD, dbo.Agcera2.CD1, dbo.ProekSector.IdProekSector, dbo.ProekSector.ProekSector, 
                         dbo.Agcera2.IdProd, dbo.Agcera2.Prod
FROM            dbo.Agcera2 INNER JOIN
                         dbo.ProekSector ON dbo.Agcera2.IdProekSector = dbo.ProekSector.IdProekSector
' 
GO

/****** Object:  View [dbo].[AgceraView]    Script Date: 2020-07-08 4:41:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[AgceraView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[AgceraView]
AS
SELECT        dbo.Agcera1.IdAgcera1, dbo.Agcera1.Data, dbo.Agcera2.IdAgcera2, dbo.Agcera2.ProekSectorZone, dbo.Agcera2.Raod, dbo.Agcera1.Shen, dbo.Agcera2.UN, dbo.Agcera2.CD, dbo.Agcera2.CD1, dbo.ProekSector.IdProekSector, 
                         dbo.ProekSector.ProekSector, dbo.Proek.IdProek, dbo.Proek.Proek, dbo.AgceraT.IdAgceraT, dbo.AgceraT.AgceraT, dbo.Agcera2.IdProd, dbo.Agcera2.Prod, dbo.Org.IdOrg, dbo.Org.Org
FROM            dbo.Agcera1 INNER JOIN
                         dbo.Agcera2 ON dbo.Agcera1.IdAgcera1 = dbo.Agcera2.IdAgcera1 INNER JOIN
                         dbo.AgceraT ON dbo.Agcera1.IdAgceraT = dbo.AgceraT.IdAgceraT INNER JOIN
                         dbo.Proek ON dbo.Agcera1.IdProek = dbo.Proek.IdProek INNER JOIN
                         dbo.ProekSector ON dbo.Agcera2.IdProekSector = dbo.ProekSector.IdProekSector INNER JOIN
                         dbo.Org ON dbo.Agcera1.IdOrg = dbo.Org.IdOrg
' 
GO

