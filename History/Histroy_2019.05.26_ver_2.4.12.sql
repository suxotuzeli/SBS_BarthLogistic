/*
ვერსია 2.4.12

1) ჩაემატა TBC და BOG ტერმინალებთან ინტეგრაცია
2) Offline ვერსიისთვის ჩაემატა შესაბამისი ველები
3) დაემატა სასწორის ჩატვირთვის ფუნქცია
4) დაემატა პროცედურები რომლებიც აკლდა
5) ჩაემატა DPrint მხარდაჭერა
*/

UPDATE dbo.Versia SET Versia = '2.4.12'
GO

IF NOT EXISTS (SELECT * FROM dbo.FiscalPrinter WHERE IdFiscalPrinter = 4)
BEGIN
	INSERT INTO dbo.FiscalPrinter(IdFiscalPrinter, FiscalPrinter, PrinterClass)
	VALUES(4,N'TBC Terminal',N'FiscalPrinterType.TBC')
END
GO

IF NOT EXISTS (SELECT * FROM dbo.FiscalPrinter WHERE IdFiscalPrinter = 5)
BEGIN
	INSERT INTO dbo.FiscalPrinter(IdFiscalPrinter, FiscalPrinter, PrinterClass)
	VALUES(5,N'BOG Terminal',N'FiscalPrinterType.BOG')
END
GO

IF NOT EXISTS (SELECT * FROM dbo.FiscalPrinter WHERE IdFiscalPrinter = 6)
BEGIN
	INSERT INTO dbo.FiscalPrinter(IdFiscalPrinter, FiscalPrinter, PrinterClass)
	VALUES(6,N'Liberty Terminal',N'FiscalPrinterType.TBC')
END
GO

IF NOT EXISTS (SELECT * FROM dbo.FiscalPrinter WHERE IdFiscalPrinter = 7)
BEGIN
	INSERT INTO FiscalPrinter(IdFiscalPrinter,FiscalPrinter,PrinterClass)
    VALUES (7, N'DPrint','FiscalPrinterType.DPrint')
END
GO

IF COL_LENGTH('Salaro','BanckTerminalSerial') IS NULL
BEGIN
	ALTER TABLE dbo.Salaro ADD BanckTerminalSerial NVARCHAR(50) NOT NULL DEFAULT ''
END
GO

IF COL_LENGTH('Salaro','PrintTerminalCheckOnFiscalPrinter') IS NULL
BEGIN
	ALTER TABLE dbo.Salaro ADD PrintTerminalCheckOnFiscalPrinter BIT NOT NULL DEFAULT 0
END
GO

IF COL_LENGTH('Salaro','IdSalaroForTerminalPrinter') IS NULL
BEGIN
	ALTER TABLE dbo.Salaro ADD IdSalaroForTerminalPrinter INT NOT NULL DEFAULT 1
END
GO


ALTER VIEW [dbo].[SalaroView]
AS
SELECT        dbo.Salaro.IdSalaro, dbo.Salaro.Salaro, dbo.Salaro.IsFiskaluri, dbo.SalaroT.IdSalaroT, dbo.SalaroT.SalaroT, dbo.Salaro.SalaroZeddPrefics, dbo.Salaro.SalaroZeddNum, dbo.Salaro.ModzSalaroZeddPrefics, 
                         dbo.Salaro.ModzSalaroZeddNum, dbo.Salaro.WithoutCash, dbo.Salaro.BanckTerminalSerial, dbo.Salaro.FiscalPrinterCOM, dbo.FiscalPrinter.FiscalPrinter, dbo.FiscalPrinter.IdFiscalPrinter,
						 dbo.Salaro.PrintTerminalCheckOnFiscalPrinter
FROM            dbo.Salaro INNER JOIN
                         dbo.SalaroT ON dbo.Salaro.IdSalaroT = dbo.SalaroT.IdSalaroT INNER JOIN
                         dbo.FiscalPrinter ON dbo.Salaro.IdFiscalPrinter = dbo.FiscalPrinter.IdFiscalPrinter
GO

IF NOT EXISTS (SELECT * FROM dbo.AdminCnobari WHERE FieldName = 'BanckTerminalSerial')
BEGIN
	INSERT INTO dbo.AdminCnobari(FieldName, NameGeo, NameEng, NameRus, Active, Shen, NameTur)
	VALUES('BanckTerminalSerial',N'ტერმინალის სერიული ნომერი',N'Terminal serial number',N'Серийный номер терминала',1,'',N'Terminal seri numarası')
END
GO

IF NOT EXISTS (SELECT * FROM dbo.AdminCnobari WHERE FieldName = 'SalaroForTerminalPrinter')
BEGIN
	INSERT INTO dbo.AdminCnobari(FieldName, NameGeo, NameEng, NameRus, Active, Shen, NameTur)
	VALUES('SalaroForTerminalPrinter',N'დასაბეჭდი სალარო',N'Terminal Printer',N'Терминальный принтер',1,'',N'Terminal Yazıcı')
END
GO

IF NOT EXISTS (SELECT * FROM dbo.AdminCnobari WHERE FieldName = 'PrintTerminalCheckOnFiscalPrinter')
BEGIN
	INSERT INTO dbo.AdminCnobari(FieldName, NameGeo, NameEng, NameRus, Active, Shen, NameTur)
	VALUES('PrintTerminalCheckOnFiscalPrinter',N'ტერმინალის ბეჭდვა სალარო აპარატზე',N'Print the terminal check on cash register',N'Распечатайте чек терминала на кассе',1,'',N'Yazar kasadaki terminal kontrolünü yazdır')
END
GO


IF COL_LENGTH('Real1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Real1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Real1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Sal','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Sal ADD IdOnMainServer INT
	ALTER TABLE dbo.Sal ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Shes1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Shes1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Shes1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Dabr1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Dabr1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Dabr1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('MDabr1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.MDabr1 ADD IdOnMainServer INT
	ALTER TABLE dbo.MDabr1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Gad','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Gad ADD IdOnMainServer INT
	ALTER TABLE dbo.Gad ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Gadadeba1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Gadadeba1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Gadadeba1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Agcera1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Agcera1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Agcera1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Carm1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Carm1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Carm1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Modz1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Modz1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Modz1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('MomcShek1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.MomcShek1 ADD IdOnMainServer INT
	ALTER TABLE dbo.MomcShek1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('VaucherReal','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.VaucherReal ADD IdOnMainServer INT
	ALTER TABLE dbo.VaucherReal ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('VaucherSal','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.VaucherSal ADD IdOnMainServer INT
	ALTER TABLE dbo.VaucherSal ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Shem1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Shem1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Shem1 ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('Gas1','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.Gas1 ADD IdOnMainServer INT
	ALTER TABLE dbo.Gas1 ADD RecordHash NVARCHAR(MAX)
END
GO


IF COL_LENGTH('XModz','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.XModz ADD IdOnMainServer INT
	ALTER TABLE dbo.XModz ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('XGas','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.XGas ADD IdOnMainServer INT
	ALTER TABLE dbo.XGas ADD RecordHash NVARCHAR(MAX)
END
GO

IF COL_LENGTH('XShem','IdOnMainServer') IS NULL
BEGIN
	ALTER TABLE dbo.XShem ADD IdOnMainServer INT
	ALTER TABLE dbo.XShem ADD RecordHash NVARCHAR(MAX)
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SascoriModel')
BEGIN
	CREATE TABLE [dbo].[SascoriModel](
		[IdSascoriModel] [INT] NOT NULL,
		[SascoriModel] [NVARCHAR](50) NOT NULL,
	 CONSTRAINT [PK_SascoriModel] PRIMARY KEY CLUSTERED 
	(
		[IdSascoriModel] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO

GRANT SELECT ON dbo.SascoriModel TO SBS_Market
GO

IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 1)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(1,N'DIGI')
END
IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 2)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(2,N'Bizerba')
END
IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 3)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(3,N'Shtrih-M')
END
IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 4)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(4,N'CAS - ES')
END
IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 5)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(5,N'CAS - NET')
END
IF NOT EXISTS (SELECT * FROM dbo.SascoriModel WHERE IdSascoriModel = 6)
BEGIN
    INSERT INTO dbo.SascoriModel(IdSascoriModel, SascoriModel) VALUES(6,N'LP Admin')
END
GO

ALTER PROCEDURE dbo.spCheckNashtiAgcera
	@D			DATETIME, 
	@IdProek	INT, 
	@OnlyAgcera BIT, 
	@IdProdT	SMALLINT, 
	@IdProdS	SMALLINT, 
	@IdMomc		SMALLINT
AS
SET NOCOUNT ON
DECLARE @IdAgcera1 INT
SELECT @IdAgcera1 = MIN(IdAgcera1) FROM Agcera1 WHERE Data = @D AND IdProek = @IdProek

DECLARE @FG SMALLINT
SELECT TOP 1 @FG = FG FROM Proek INNER JOIN Gvari ON Gvari.IdGvari = Proek.IdGvari
WHERE IdProek = @IdProek 

CREATE TABLE #A
(
	IdProd		NVARCHAR(40) COLLATE SQL_Latin1_General_CP1_CI_AS, 
	Prod		NVARCHAR(250) COLLATE SQL_Latin1_General_CP1_CI_AS, 
	Agcera		NUMERIC(12, 3) DEFAULT 0, 
	Nashti		NUMERIC(12, 3) DEFAULT 0, 
	Fasi		NUMERIC(12, 3) DEFAULT 0, 
	Fasi10		NUMERIC(12, 3) DEFAULT 0, 
	IsAgcera	BIT, 
	Momc		NVARCHAR(300)
)
DECLARE @cmd NVARCHAR(MAX) =


'INSERT INTO #A (IdProd, Prod, Agcera, Nashti, Fasi, Fasi10, IsAgcera, Momc)
SELECT IdProd, Prod, SUM(Raod), 0, Fasi'+CAST(@FG AS NVARCHAR(10))+', Fasi10, 1, Momc
FROM AgceraView
WHERE IdAgcera1 IN (SELECT IdAgcera1 FROM Agcera1 WHERE Data = ''' +CAST(@D AS NVARCHAR(25))+ ''')
AND IdProek = ' + CAST(@IdProek AS NVARCHAR(10)) + ' AND IsVirtual = 0
		AND (' + CAST(@IdProdS AS NVARCHAR(10)) + ' = 0 OR IdProdS = ' + CAST(@IdProdS AS NVARCHAR(10)) + ')
		AND (' + CAST(@IdProdT AS NVARCHAR(10)) + ' = 0 OR IdProdT = ' + CAST(@IdProdT AS NVARCHAR(10)) + ')
		AND (' + CAST(@IdMomc AS NVARCHAR(10)) + ' = 0 OR IdMomc = ' + CAST(@IdMomc AS NVARCHAR(10)) + ')
GROUP BY IdProd, Prod, Fasi'+CAST(@FG AS NVARCHAR(10))+', Fasi10, Momc

IF( ' + CAST(@OnlyAgcera AS NVARCHAR(10)) + ' = 1)
BEGIN
	
	INSERT INTO #A (IdProd, Prod, Agcera, Nashti, Fasi, Fasi10, IsAgcera, Momc)
	SELECT IdProd, Prod, 0, Raod, Fasi'+CAST(@FG AS NVARCHAR(10))+', Fasi10, 1, Momc
	FROM AgceraNashtiView
	WHERE IdProd IN (SELECT IdProd FROM #A) AND IsVirtual = 0
	AND IdAgcera1 = ' + CAST(@IdAgcera1 AS NVARCHAR(10)) + '
	
END
ELSE
BEGIN

	INSERT INTO #A (IdProd, Prod, Agcera, Nashti, Fasi, Fasi10, IsAgcera, Momc)
	SELECT IdProd, Prod, 0,Raod, Fasi'+CAST(@FG AS NVARCHAR(10))+', Fasi10, 0, Momc
	FROM AgceraNashtiView
	WHERE IsVirtual = 0
		AND (' + CAST(@IdProdS AS NVARCHAR(10)) + ' = 0 OR IdProdS = ' + CAST(@IdProdS AS NVARCHAR(10)) + ')
		AND (' + CAST(@IdProdT AS NVARCHAR(10)) + ' = 0 OR IdProdT = ' + CAST(@IdProdT AS NVARCHAR(10)) + ')
		AND (' + CAST(@IdMomc AS NVARCHAR(10)) + ' = 0 OR IdMomc = ' + CAST(@IdMomc AS NVARCHAR(10)) + ')
		AND IdAgcera1 = ' + CAST(@IdAgcera1 AS NVARCHAR(10)) + '
END
'
EXEC (@cmd)

SELECT #A.IdProd, #A.Prod, SUM(Nashti) Nashti, SUM(Agcera) Agcera, Fasi, #A.Fasi10, MAX(CAST(IsAgcera AS INT)) AS IsAgcera, 
	CASE WHEN SUM(Nashti) > SUM(Agcera) THEN SUM(Nashti) - SUM(Agcera) ELSE 0 END Gas, 
	CASE WHEN SUM(Nashti) < SUM(Agcera) THEN -SUM(Nashti) + SUM(Agcera) ELSE 0 END Shem, 
	CASE WHEN SUM(Nashti) > SUM(Agcera) THEN SUM(Nashti * Fasi) - SUM(Agcera * Fasi) ELSE 0 END GasTanxa, 
	CASE WHEN SUM(Nashti) < SUM(Agcera) THEN -SUM(Nashti * Fasi) + SUM(Agcera * Fasi) ELSE 0 END ShemTanxa,
	Momc,ProdT,ProdS,ProdG
FROM #A 
	INNER JOIN dbo.Prod ON Prod.IdProd = #A.IdProd
	INNER JOIN dbo.ProdS ON ProdS.IdProdS = Prod.IdProdS
	INNER JOIN dbo.ProdT ON ProdT.IdProdT = Prod.IdProdT
	INNER JOIN dbo.ProdG ON ProdG.IdProdG = Prod.IdProdG
GROUP BY #A.IdProd, #A.Prod, Fasi, #A.Fasi10,Momc,ProdT,ProdS,ProdG
HAVING SUM(Nashti) <> SUM(Agcera)


SET NOCOUNT OFF
GO

-- spNashtiFactiuriClient
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spNashtiFactiuriClient')
BEGIN
    DROP PROCEDURE spNashtiFactiuriClient
END
GO

CREATE  PROCEDURE [dbo].[spNashtiFactiuriClient]
	@D1 SMALLDATETIME,@D2 SMALLDATETIME, @IdProek INT, @IdMomc INT
AS
SET NOCOUNT ON

CREATE TABLE #B 
(
IdProd       NVARCHAR(40) COLLATE SQL_Latin1_General_CP1_CI_AS,
IdProek      INT,
Raod         NUMERIC(15,3),
RealRaod	 NUMERIC(15,3)
)

CREATE TABLE #PRD
(
IdProd       NVARCHAR(40) COLLATE SQL_Latin1_General_CP1_CI_AS
)

INSERT INTO  #PRD
SELECT IdProd FROM Prod
WHERE IdMomc = @IdMomc

INSERT INTO #B
SELECT IdProd, IdProek, -SUM(Raod) Raod, 0
FROM GasView
WHERE  Data <= GETDATE() AND (@IdProek = 0 OR IdProek = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek
UNION ALL
SELECT IdProd, IdProek, SUM(Raod) Raod, 0
FROM ShesView
WHERE  Data <= GETDATE() AND (@IdProek = 0 OR IdProek = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek
UNION ALL
SELECT IdProd, IdProek, -SUM(Raod) Raod, 0
FROM MDabrView
WHERE  Data <= GETDATE() AND (@IdProek = 0 OR IdProek = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek
UNION ALL
SELECT IdProd, IdProek1, -SUM(Raod) Raod, 0
FROM ModzView
WHERE  Data <= GETDATE() AND (@IdProek = 0 OR IdProek1 = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek1
UNION ALL
SELECT IdProd, IdProek2, SUM(Raod) Raod, 0
FROM ModzView
WHERE  Data <= GETDATE() AND (@IdProek = 0 OR IdProek2 = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek2
UNION ALL
SELECT IdProd, IdProek, 0, SUM(Raod) Raod
FROM RealView
WHERE  Data >= @D1 AND Data <= @D2 AND  (@IdProek = 0 OR IdProek = @IdProek) AND IdProd IN (SELECT IdProd FROM #PRD)
GROUP BY IdProd, IdProek


SELECT N'1.ნაშთი' OperTG, N'1.ნაშთი' OperT, B.IdProd, Prod, ProdT, ProdTG, ProdS, ProdG, Proek, Momc, MinRaod, GETDATE() lastData, 
SUM(Fasi1 * B.Raod) Tanxa1, SUM(Fasi2 * B.Raod) Tanxa2, SUM(Fasi3 * B.Raod) Tanxa3, SUM(Fasi4 * B.Raod) Tanxa4, SUM(Fasi5 * B.Raod) Tanxa5,
SUM(Fasi6 * B.Raod) Tanxa6, SUM(B.Raod) Raod, CAST(SUM(B.Raod)/CompRaod AS INT) CompRaodTotal, Ert, SUM(B.Raod) - (CAST(SUM(B.Raod)/CompRaod AS INT) * CompRaod) CaliRaodTotal,
 SUM(B.RealRaod) RealRaod 
FROM #B B INNER JOIN 
     ProdView P ON B.IdProd = P.IdProd INNER JOIN 
     Proek On B.IdProek = Proek.IdProek
GROUP BY B.IdProd, Prod, ProdT, ProdTG, ProdS, ProdG, Proek, Momc, ProdCode, CompRaod, MinRaod, B.IdProek , Ert

GO

-- spUserTanxaMovement
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spUserTanxaMovement')
BEGIN
    DROP PROCEDURE spUserTanxaMovement
END
GO

CREATE  PROCEDURE [dbo].[spUserTanxaMovement]
	@D1 SMALLDATETIME,@D2 SMALLDATETIME, @UN Nvarchar(15), @IdSalaro int
AS
SET NOCOUNT ON

CREATE TABLE #A 
(
Data         SMALLDATETIME,
OperT        Nvarchar(30),
Saidan        Nvarchar(150),
Sad        Nvarchar(150),
Tanxa        NUMERIC(15,3),
TanxaABS	 NUMERIC(15,3)
)


INSERT INTO #A
SELECT Data, N'კლიენტის გადახდა', Gvari, Salaro, SUM(Tanxa), SUM(Tanxa)
FROM SalView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro=@IdSalaro
GROUP BY Data, Gvari, Salaro
UNION ALL
SELECT Data, N'მომწოდებელზე გადახდა', Salaro, Momc,  SUM(Tanxa), -SUM(Tanxa)
FROM GadView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro=@IdSalaro
GROUP BY Data, Salaro, Momc
UNION ALL
SELECT Data, N'თანხის გასავალი', Salaro, Tanam,  SUM(Tanxa), -SUM(Tanxa)
FROM XGasView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro=@IdSalaro
GROUP BY Data, Salaro, Tanam
UNION ALL
SELECT Data, N'თანხის შემოსავალი', Tanam, Salaro, SUM(Tanxa), SUM(Tanxa)
FROM XShemView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro=@IdSalaro
GROUP BY Data, Salaro, Tanam
UNION ALL
SELECT Data, N'თანხის მოძრაობა (შემოსავალი)', Salaro2, Salaro1, SUM(Tanxa), SUM(Tanxa)
FROM XModzView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro2=@IdSalaro
GROUP BY Data, Salaro1, Salaro2
UNION ALL
SELECT Data, N'თანხის მოძრაობა (გასავალი)', Salaro1, Salaro2, SUM(Tanxa), -SUM(Tanxa)
FROM XModzView
WHERE  Data >= @D1 AND  Data <= @D2 AND UN=@UN AND IdSalaro1=@IdSalaro
GROUP BY Data, Salaro1, Salaro2


SELECT Data, OperT, Saidan, Sad, SUM(Tanxa) Tanxa, SUM(TanxaABS) Brunva
FROM #A 
GROUP BY Data, OperT, Saidan, Sad

GO

--spProekTurnOver
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spProekTurnOver')
BEGIN
    DROP PROCEDURE spProekTurnOver
END
GO
CREATE PROCEDURE [dbo].[spProekTurnOver]
@D1 SMALLDATETIME, 
@D2 SMALLDATETIME
AS
SET NOCOUNT ON


DECLARE @DD1 SMALLDATETIME
DECLARE @DD2 SMALLDATETIME
SELECT @DD1=@D1, @DD2=@D2

CREATE TABLE #P
(
	Period SMALLDATETIME,
	IdProek SMALLINT,
	RealTanxa NUMERIC(15,2) NOT NULL DEFAULT 0,
	ZeddCount INT NOT NULL DEFAULT 0,
	Nashti NUMERIC(15,2)  NOT NULL DEFAULT 0,
	RealRaod  NUMERIC(15,2)  NOT NULL DEFAULT 0		
)

CREATE TABLE #B 
(
IdProd       NVARCHAR(80) COLLATE SQL_Latin1_General_CP1_CI_AS,
IdProek        INT,
Raod         NUMERIC(15,3)
)
CREATE TABLE #B2
(
IdProek        INT,
Raod         NUMERIC(15,3),
Tanxa         NUMERIC(15,3)
)

CREATE TABLE #B3
(
IdReal1 INT,
CNT INT,
Tanxa NUMERIC(15,2)  NOT NULL DEFAULT 0
)

SELECT @D2=@D1-1
SELECT @D1=@D1-1

WHILE @D2<@DD2 BEGIN

		SELECT @D1=@D2+1, @D2=@D2+1
		DELETE FROM #B
		DELETE FROM #B3

		


		INSERT INTO #P
				( 
				Period,
				IdProek 
				)
		SELECT @D2,IdProek
		FROM Proek
		WHERE IdProek IN (SELECT IdProek FROM Real1 WHERE 

Data>=@D1 AND Data<=@D2)
		
		
		INSERT INTO #B3
				( IdReal1, CNT, Tanxa)
		SELECT  Real1.IdReal1, COUNT(*),SUM(Tanxa)
		FROM Real1 INNER JOIN Real2 ON Real1.IdReal1=REal2.IdReal1	INNER JOIN 

Prod ON dbo.Prod.IdProd = dbo.Real2.IdProd			
		WHERE Data = @D1  AND Real1.Active = 1 AND Accepted = 1  
		GROUP BY Real1.IdReal1

		DELETE FROM #B2
		INSERT INTO #B2
				( IdProek, Raod, Tanxa )
		SELECT  IdProek,SUM(CNT), SUM(Tanxa)
		FROM #B3 INNER JOIN dbo.Real1 ON dbo.Real1.IdReal1 = #B3.IdReal1 
		GROUP BY IdProek
		UPDATE #P
		SET RealRaod=#B2.Raod, RealTanxa=#B2.Tanxa
		FROM #P INNER JOIN #B2 ON #B2.IdProek = #P.IdProek
		WHERE Period=@D2

		DELETE FROM #B2
		INSERT INTO #B2
				( IdProek, Raod )
		SELECT IdProek, COUNT(*)
		FROM Real1
		WHERE  IdReal1 IN (SELECT IdReal1 FROM #B3 WHERE CNT>0)
		GROUP BY IdProek

		UPDATE #P
		SET ZeddCount=#B2.Raod
		FROM #P INNER JOIN #B2 ON #B2.IdProek = #P.IdProek
		WHERE Period=@D2
		

END

SELECT  Proek, period AS Periodi,*, ROUND(CASE WHEN ZeddCount=0 THEN 0 ELSE 

RealTanxa/ZeddCount END,2) RTZ,  
	ROUND(CASE WHEN RealRaod=0 THEN 0 ELSE RealTanxa/RealRaod END,2) RR, 
	ROUND(CASE WHEN ZeddCount=0 THEN 0 ELSE RealRaod/ZeddCount END,2) RZ
FROm #P 
	INNER JOIN Proek on #P.IdProek=Proek.IdProek

SET NOCOUNT OFF

GO

--spMomcShekveta
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spMomcShekveta')
BEGIN
    DROP PROCEDURE spMomcShekveta
END
GO

CREATE  PROCEDURE [dbo].[spMomcShekveta]
	@D SMALLDATETIME, @IdProek INT, @IdMomc INT, @IdMomcShek1 INT
AS
SET NOCOUNT ON

CREATE TABLE #B 
(
IdProd       NVARCHAR(40) COLLATE SQL_Latin1_General_CP1_CI_AS,
Raod         NUMERIC(8,3),
SekveTa  NUMERIC(8,3),
Tanxa        NUMERIC(15,3)
)

INSERT INTO #B
SELECT IdProd, SUM(Raod),0,0
FROM ShemView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd, -SUM(Raod),0,0
FROM GasView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd, -SUM(Raod),0,0
FROM RealView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 --And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd, SUM(Raod),0,0
FROM ShesView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd,  -SUM(Raod),0,0
FROM MDabrView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd, -SUM(Raod),0,0
FROM ModzView
WHERE  Data <= @D AND IdProek1 = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd, SUM(Raod),0,0
FROM ModzView
WHERE  Data <= @D AND IdProek2 = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd
UNION ALL
SELECT IdProd2, -SUM(Raod),0,0
FROM CarmView
WHERE  Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd2
UNION ALL
SELECT IdProd,0, SUM(Raod),SUM(Tanxa)
FROM MomcShek2
WHERE IdMomcShek1=@IdMomcShek1
GROUP BY IdProd 
/*UNION ALL
SELECT IdProd, SUM(CarmRaod) Raod
FROM Carm1View
WHERE Data <= @D AND IdProek = @IdProek AND IdMomc = @IdMomc AND IsVirtual = 0 And Active=1
GROUP BY IdProd */


SELECT N'1.ნაშთი' OperTG, P.IdProd,Ert, Prod, ProdT, ProdTG, ProdS, ProdG, MinRaod, ISNULL(SUM(B.Raod),0) Nashti, ISNULL(CAST(SUM(B.Raod)/CompRaod AS INT),0) CompRaodTotal,Fasi10 as Tvitgir,ISNULL(sum(SekveTa),0) as Raod,ISNULL(sum(Tanxa),0) as ShekTanxa,CompRaod,ISNULL(sum(SekveTa),0) as Raod2
FROM #B B Right JOIN 
     ProdView P ON B.IdProd = P.IdProd
     Where Active=1 AND IdMomc = @IdMomc
GROUP BY P.IdProd, Prod, ProdT, ProdTG, Ert, ProdS, ProdG,Momc, ProdCode, CompRaod, MinRaod, Fasi10
GO

--spMomcShekveta
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spRealSalShedareba')
BEGIN
    DROP PROCEDURE spRealSalShedareba
END
GO

CREATE PROCEDURE spRealSalShedareba
	@D1 DATE,
	@D2 DATE,
	@UN NVARCHAR(50),
	@IdSalaro INT
AS
BEGIN
	SET NOCOUNT ON;

	CREATE TABLE #temp
	(
		Data DATE,
		TanxaReal NUMERIC(12,2),
		TanxaSal NUMERIC(12,2),
		Zedd NVARCHAR(100),
		OperT NVARCHAR(100)
	)
	INSERT INTO #temp(Data, TanxaReal, Zedd, OperT)
	SELECT Data,SUM(Tanxa),Zedd,N'რეალიზაცია' 
		FROM dbo.Real2 
		INNER JOIN dbo.Real1 ON Real1.IdReal1 = Real2.IdReal1 
		WHERE IdProek = @IdSalaro AND Data BETWEEN @D1 AND @D2
		GROUP BY Data,Zedd


	INSERT INTO #temp(Data, TanxaSal, Zedd, OperT)
	SELECT Sal.Data,SUM(Tanxa),Real1.Zedd,N'გადახდა'
		FROM dbo.Sal INNER JOIN dbo.Real1 ON Real1.Zedd = Sal.Zedd 
		WHERE IdProek = @IdSalaro AND Sal.Data BETWEEN @D1 AND @D2
		GROUP BY Sal.Data,Real1.Zedd

	SELECT	Data, ISNULL(TanxaReal,0) AS TanxaReal, ISNULL(TanxaSal,0) AS TanxaSal, Zedd, OperT, ISNULL(TanxaReal,0)-ISNULL(TanxaSal,0) AS TanxaSxvaoba FROM #temp

END
GO

--spSelectGvariFromReal
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spSelectGvariFromReal')
BEGIN
    DROP PROCEDURE spSelectGvariFromReal
END
GO

CREATE PROCEDURE dbo.spSelectGvariFromReal
	@D1 smalldatetime, 
	@D2 smalldatetime, 
	@CardNumber	NVARCHAR(100), 
	@Gvari NVARCHAR(200)
AS 
SET NOCOUNT ON
	CREATE TABLE #Gvari
	(
		IdGvari	INT,
		Gvari	NVARCHAR(200),
		CardNumber NVARCHAR(100)
	)
	
	INSERT INTO #Gvari (IdGvari, Gvari, CardNumber ) 
	SELECT DISTINCT Real1.IdGvari, Gvari, CardNumber
	FROM  dbo.Real1 
		INNER JOIN dbo.Real2 ON Real2.IdReal1 = Real1.IdReal1 
		INNER JOIN dbo.Gvari ON Gvari.IdGvari = Real1.IdGvari
	WHERE (@CardNumber = '0' OR CardNumber = @CardNumber) AND (@Gvari = '' OR Gvari LIKE @Gvari) AND Data >= @D1 AND Data <= @D2 
	
	SELECT DISTINCT IdGvari, Gvari, CardNumber
	FROM #Gvari

SET NOCOUNT OFF

GO

ALTER FUNCTION dbo.udfCalcZeddSalTanxa (
  @Zedd nvarchar(20)
)
RETURNS money
BEGIN

DECLARE @Tanxa MONEY

SELECT @Tanxa = ISNULL(SUM(Tanxa),0)
FROM Sal
WHERE Zedd = @Zedd

SELECT @Tanxa = @Tanxa + ISNULL(SUM(Tanxa),0)
FROM dbo.VaucherSal
WHERE Zedd = @Zedd

SELECT @Tanxa = ISNULL(@Tanxa, 0)

RETURN @Tanxa

END
GO

--spSelectGvariFromReal
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'spSalaroBarati')
BEGIN
    DROP PROCEDURE spSalaroBarati
END
GO

CREATE PROCEDURE dbo.spSalaroBarati 
	@D1 DATETIME,
	@D2 DATETIME,
	@IdSalaro INT
AS
SET NOCOUNT ON

DECLARE @Salaro NVARCHAR(50)

SELECT TOP 1  @Salaro = Salaro
FROM Salaro
WHERE IdSalaro = @IdSalaro

CREATE TABLE #P
(
	Data	SMALLDATETIME,
	Zedd	NVARCHAR(25) COLLATE SQL_Latin1_General_CP1_CI_AS,
	OperT	NVARCHAR(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	Saidan	NVARCHAR(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	Sad		NVARCHAR(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	Tanxa		MONEY,
	TanxaGas	MONEY,
	Shen	NVARCHAR(200)
)

DECLARE @Tanxa MONEY
SET @Tanxa = 0

	SELECT @Tanxa = @Tanxa + ISNULL(SUM(Tanxa), 0)
	FROM dbo.XShem
	WHERE IdSalaro = @IdSalaro AND Data < @D1
	 
	SELECT @Tanxa = @Tanxa - ISNULL(SUM(Tanxa), 0)
	FROM dbo.XGas
	WHERE IdSalaro = @IdSalaro  AND Data < @D1

	SELECT @Tanxa = @Tanxa + ISNULL(SUM(Tanxa), 0)
	FROM dbo.Sal
	WHERE IdSalaro = @IdSalaro  AND Data < @D1

	SELECT @Tanxa = @Tanxa + ISNULL(SUM(VaucherSal.Tanxa), 0)
	FROM dbo.VaucherSal INNER JOIN dbo.Sal ON Sal.Zedd = VaucherSal.Zedd
	WHERE IdSalaro = @IdSalaro  AND VaucherSal.Data < @D1
	 
	SELECT @Tanxa = @Tanxa - ISNULL(SUM(Tanxa), 0)
	FROM dbo.Gad
	WHERE IdSalaro = @IdSalaro  AND Data < @D1

	SELECT @Tanxa = @Tanxa - ISNULL(SUM(Tanxa), 0)
	FROM dbo.XModz
	WHERE IdSalaro1 = @IdSalaro AND Data < @D1
	 
	SELECT @Tanxa = @Tanxa + ISNULL(SUM(Tanxa), 0)
	FROM dbo.XModz
	WHERE IdSalaro2 = @IdSalaro AND Data < @D1
	
	INSERT INTO #P(Data, Zedd, OperT, Saidan, Sad, Tanxa, TanxaGas, Shen)
	SELECT @D1, '', N'01.ნაშთი', '', '', ISNULL(@Tanxa, 0), ISNULL(@Tanxa, 0), ''
	UNION ALL
	SELECT Data, Zedd, N'11.შემოსავალი', Tanam, Salaro, SUM(Tanxa), SUM(Tanxa), Shen
	FROM dbo.XShemView
	WHERE Data >= @D1 AND Data <= @D2 AND (IdSalaro = @IdSalaro)
	GROUP BY Data, Zedd, Tanam, Salaro, Shen
	UNION ALL
	SELECT Data, Zedd, N'12.შემოსავალი გაყიდვებიდან', Salaro, Gvari, SUM(Tanxa), SUM(Tanxa), Shen
	FROM SalView 
	WHERE Data >= @D1 AND Data <= @D2 AND (IdSalaro = @IdSalaro) 
	GROUP BY Data, Zedd, Salaro, Gvari, Shen
	UNION ALL
	SELECT VaucherSal.Data, VaucherSal.Zedd, N'13.ვაუჩერზე თანხის გადახდა', Salaro, Gvari, SUM(VaucherSal.Tanxa), SUM(VaucherSal.Tanxa), VaucherSal.Shen
	FROM dbo.VaucherSal 
		INNER JOIN dbo.Sal ON Sal.Zedd = VaucherSal.Zedd
		INNER JOIN dbo.Salaro ON Salaro.IdSalaro = Sal.IdSalaro
		INNER JOIN dbo.Gvari ON Gvari.IdGvari = Sal.IdGvari
	WHERE VaucherSal.Data >= @D1 AND VaucherSal.Data <= @D2 AND (dbo.Sal.IdSalaro = @IdSalaro) 
	GROUP BY VaucherSal.Data, VaucherSal.Zedd, Salaro, Gvari, VaucherSal.Shen
	UNION ALL
	SELECT Data, Zedd, N'14.შიდა მოძრაობა', Salaro1, Salaro2, SUM(Tanxa), SUM(Tanxa), Shen
	FROM XModzView
	WHERE Data >= @D1 AND Data <= @D2 AND IdSalaro2 = @IdSalaro
	GROUP BY Data, Zedd, Salaro1, Salaro2, Shen
	UNION ALL
	SELECT Data, Zedd, N'21.გასავალი', Salaro, '', SUM(Tanxa), -SUM(Tanxa), Shen
	FROM XGasView
	WHERE Data >= @D1 AND Data <= @D2 AND (IdSalaro = @IdSalaro)
	GROUP BY Data, Zedd, Salaro, Shen
	UNION ALL
	SELECT Data, Zedd, N'22.გადახდები მომწოდებლებზე', Salaro, Momc, SUM(Tanxa), -SUM(Tanxa), Shen
	FROM dbo.GadView
	WHERE Data >= @D1 AND Data <= @D2 AND (IdSalaro = @IdSalaro) 
	GROUP BY Data, Zedd, Salaro, Momc, Shen
	UNION ALL
	SELECT Data, Zedd, N'23.შიდა მოძრაობა', Salaro1, Salaro2, SUM(Tanxa), -SUM(Tanxa), Shen
	FROM XModzView
	WHERE Data >= @D1 AND Data <= @D2 AND IdSalaro1 = @IdSalaro
	GROUP BY Data, Zedd, Salaro1, Salaro2, Shen

SELECT @IdSalaro IdSalaro, @Salaro Salaro, Zedd, Data, OperT, Saidan, Sad, SUM(Tanxa) Tanxa, SUM(TanxaGas) TanxaGas, Shen
FROM #P
GROUP BY Data, OperT, Saidan, Sad, Shen, zedd
ORDER BY Data, OperT
SET NOCOUNT OFF

GO

ALTER PROCEDURE dbo.spAddUser
	@User1 nvarchar(20), @Pass nvarchar(20), @Roles nvarchar(40)
AS

Set Nocount Off

if not exists (select * from master.dbo.syslogins where loginname = @User1)
BEGIN
 declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'master', @loginlang = N'us_english'
 if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
  select @logindb = N'master'
 if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
  select @loginlang = @@language

	EXEC sp_addlogin @User1, @Pass, @logindb, @loginlang
	EXEC sp_grantdbaccess @User1, @User1
	EXEC sp_addsrvrolemember @User1, 'securityadmin'
	EXEC sp_addrolemember @Roles, @User1
	EXEC sp_addrolemember 'db_datareader', @User1
	EXEC sp_addrolemember 'db_datawriter', @User1
END

Set Nocount ON

GO

IF COL_LENGTH('Proek','ProekZeddPref') IS NULL
BEGIN
	ALTER TABLE dbo.Proek ADD ProekZeddPref NVARCHAR(50) NOT NULL DEFAULT ''
END
GO

IF NOT EXISTS (SELECT * FROM dbo.AdminCnobari WHERE FieldName = 'ProekZeddPref')
BEGIN
    INSERT INTO dbo.AdminCnobari(FieldName, NameGeo, NameEng, NameRus, Active, Shen, NameTur)
	VALUES('ProekZeddPref',N'ზედდებულის პრეფიქსი',N'waybill prefix',N'приставка накладная',1,'','konşimento öneki')
END
GO

IF EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'udfGetIdProekFromReal')
BEGIN
    DROP FUNCTION udfGetIdProekFromReal
END
GO

CREATE FUNCTION [dbo].[udfGetIdProekFromReal]
(
	@Zedd nvarchar(50)
)
RETURNS int
AS
BEGIN
	DECLARE @Resutl int 
	select top 1 @Resutl = IdProek from real1 where zedd = @Zedd 
	return @Resutl

END
