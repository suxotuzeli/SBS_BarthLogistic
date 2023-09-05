using System;
using DevExpress.Utils;

namespace SBS_BarthLogistic.Classes
{
    public static class WayBillParameters
    {
        public static bool CanEditClosedZedd;
        public static bool ShowInColors;
        public static bool CanSendFactura;
        public static bool TransGamkidveli;
        public static string IdTransTypes, TransTypes;
    }

    public class WayBillInformation
    {
        public string BEGIN_DATE;
        public string BUYER_NAME;
        public string BUYER_TIN;
        public string CAR_NUMBER;
        public int CHEK_BUYER_TIN;
        public int CHEK_DRIVER_TIN;
        public string COMMENT;
        public string DELIVERY_DATE;
        public string DRIVER_NAME;
        public string DRIVER_TIN;
        public string END_ADDRESS;
        public int ID;
        public int myId;
        public string PAR_ID;
        public string RECEIVER_INFO;
        public string RECEPTION_INFO;
        public string SELER_UN_ID;
        public string START_ADDRESS;
        public int STATUS;
        public int TRAN_COST_PAYER;
        public int TRANS_ID;
        public string TRANS_TXT;
        public double TRANSPORT_COAST;
        public int TYPE;
        public bool IS_DRIVER;
    }

    public static class Company
    {
        public static int id;
        public static string Name;
        public static string Address;
        public static string NebaDarto;
        public static string Contact;
        public static string Direk;
        public static string Sagad;
        public static int UnId;
        public static int UserId;
        public static string Mail;
        public static string su;
        public static string sp;
        public static string ip;
        public static string Shen;
    }

    public static class DefaultValues
    {
        public static bool chbRealT;
        public static bool chbSalT;
        public static bool chbMDabrT;
        public static bool chbDabrT;
        public static bool chbShemT;
        public static bool chbGasT;
        public static bool chbProek;
        public static bool chbGadT;
        public static bool chbShekT;
        public static bool chbShesT;
        public static bool chbModzT;
        public static bool chbXShemT;
        public static bool chbXGasT;
        public static bool chbTanam;
        public static bool chbSalaro;
        public static bool chbCarmT;
        public static bool chbGegmaCarmT;
        public static object IdRealT;
        public static object IdSalT;
        public static object IdMDabrT;
        public static object IdDabrT;
        public static object IdShemT;
        public static object IdGasT;
        public static object IdProek;
        public static object IdGadT;
        public static object IdShekT;
        public static object IdShesT;
        public static object IdShesShekT=1;
        public static object IdModzT;
        public static object IdXShemT;
        public static object IdXGasT;
        public static object IdTanam;
        public static object IdDggStatus;
        public static object IdSalaro;
        public static object IdCarmT;
        public static object IdProekShekT;
        public static object IdGegmaCarmT;
        public static int StandardFg;
    }

    public static class InterfaceParameters
    {
        public static int DefaultPeriodIndex;
        public static int GascorebaDge;
        public static int TimerInterval;
        public static int ProdFormSymbolCount;
        public static bool GascorebaSxva;
        public static bool RestoreDgSettings;
        public static string InterfaceLanguage;
        public static bool SearchByHours;
        public static bool cbSaangPeriodi, DgFullSettings;
        public static bool FindFormsRestoreDGSettings = false;
        public static DateTime D1;
        public static DateTime D2;
        public static DateTime Dge;
        public static bool GroupAgceraByIdProd;
        public static int PivotTableMaxRowCount;
        public static int PivotTableFieldCount;
        public static bool pasteValue, ExportXlsx, FullDaxurva;
        public static string PicturesFolder;
        public static OptionsLayoutGrid options;
        public static string SQLCeDatabaseFolder;
        public static string SQLCeDatabaseCopyFolder;
        public static string RegKey;
        public static string Version;
        public static string updatestr;
        public static bool cbBScan;
        public static bool ShowAedPopup;
        public static bool ShowShesTvitg;
        public static bool CheckNashti;
        public static bool CanAddShroba;
        public static bool ShowTvitg;
        public static bool CanSeeFactNashti;
        public static bool CanExportModz;
        public static bool CreateLogRs;
        public static bool SaveDelReal;
        public static bool DeniedAfterClose;
        public static bool CloseMinus;
        public static bool CloseForm = false;
        public static int TvitgFasi;
        public static bool CarmAutoCalc;
        public static bool ShowCompanyName;
        public static bool ComplexCarm;
        public static bool RsFullImport;
        public static bool PrintGroupedStimul;
        public static bool RsDateSet;
        public static bool CanSetProdFasi;
        public static Unit[] Units;
        public static string MailUserName;
        public static string MailPassWord;
        public static string MailIncomeServer;
        public static string MailOutcomeServer;
        public static int MailSMTP;
        public static int MailPOP3;
        public static bool UseNewExcelImport { get; set; }

    }

    public static class PrintParameters
    {
        public static int ReportNumber = 1;
        public static int FacturaRowCount = 6;
        public static int ZeddRowCount = 11;
        public static int SasZeddCopies;
        public static bool SasZeddAllInDanarti;
        public static bool DirectPrintZedd;
        public static bool UseExcel2007;
    }

    public static class OrgProdParameters
    {
        public static int GvariSearchSymbolCount;
        public static bool GvariSearchFromFirstSymbol;
        public static bool GvariCodeInput;
        public static int GvariIncrement;
        public static bool GvariSortByCode;
        public static int ProdSearchSymbolCount;
        public static bool ProdSearchFromFirstSymbol;
        public static bool ProdCodeInput;
        public static int ProdIncrement;
        public static bool ProdSortByCode, UpdateProdMomcPrice;
        public static bool ProdSearchInCode;
        public static bool ProdMomcFilter;
        public static double ProdRaod;
        public static bool SacCheck, ShowProdPicture, WayBillClientCanUpdate;
        public static string selName;
        public static string selID;
        public static int PictureMaxRaod;
        public static bool selShabloni;
        public static double selCompRaod;
        public static bool FilterProdWithProdT;
        public static int selVada;
        public static int FG = 1;
        public static int ShesFG = 1;
        public static decimal selFasi;
        public static double Qula;
        public static string GvariAddress;
        public static string Miigo;
        public static bool changeFG;
        public static bool ShesSetRealFasi;
        public static string IdProd;
        public static string Prod;
        public static object IdMomc;
        public static string MomcSagad;
        public static double Fasi10;
        public static int IdUnit;
        public static string UnitName;
    }

    public class Unit
    {
        public string IdUnit { get; set; }
        public string UnitText { get; set; }
    }
}