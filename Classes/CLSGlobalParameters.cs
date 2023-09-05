using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    /// -- ვერსია 0.6 -- 18 Oct 2015 19:00 ნიკა
    /// . Initialize-დან ამოვიღე GlobalParameters.Errors ის ინიციალიზაცია და გადავიტანე იქვე კლასში
    ///   GlobalParameters.InitializeErrorTexts()
    ///   Form1.cs-ის Load შია ჩასამატებელი ეს ფუქცია
    /// . დაემატა რამდენიმე StringParameters
    /// -- ვერსია 0.5 -- 7 Oct 2015 14:00 ნიკა
    /// </summary>
    public static class GlobalParameters
    {
        //Translate
        public static Dictionary<string, Language> FieldContainerName =
            new Dictionary<string, Language>();
        public static Dictionary<string, AdminFieldProperty> AdminFieldProperties =
            new Dictionary<string, AdminFieldProperty>();
        public static Dictionary<string, AdminChangeSelected> AdminChangeSelecteds =
            new Dictionary<string, AdminChangeSelected>();
        public static Dictionary<string, Language> Languages =
            new Dictionary<string, Language>();

        public static Dictionary<string, string> Errors = new Dictionary<string, string>();

        public static RibbonControl Rc;
        public static DefaultLookAndFeel DefaultLookAndFeel;

        public static string UserName;
        public static string PassWord;
        public static string DatabaseName;
        public static SqlConnection cn;
        public static Form fmMain;
        public static string ConnStr;
        public static string connectionTimeout;

        public static string FieldName;
        public static string TableName;

        public static int FindID;
        public static int IDForFind;

        public static bool FindFormsRestoreDgSettings = false;
        public static bool ViewFullLog;
        public static bool CreateLog;
        public static bool ClearDelReal;

        public static bool SetFont;
        public static string FontName;
        public static float FontSize;
        public static Font Font;
        public static string ReportsFolder;
        public static string MonacemebiFolder;
        public static string MailFolder;
        public static string XMLFolder;
        public static string DateFormat;
        public static string ServerDateFormat = "MM/dd/yyyy";
        public static string ServerDateTimeFormat = "MM/dd/yyyy HH:mm:ss";
        public static string updatestr;


        public static void InitializeErrorTexts()
        {
            Errors.Clear();
            var dt = SQL.Select(" SELECT ErrorContains, ISNULL(" + InterfaceParameters.InterfaceLanguage +
                                ", LogicalText) AS LogicalText " +
                                " FROM AdminErrorMessage " +
                                " LEFT JOIN AdminCnobari ON NameGeo = LogicalText AND FieldName = '' ");

            for (var i = 0; i < dt.Rows.Count; i++)
                Errors.Add(dt.Rows[i]["ErrorContains"].ToString().ToUpper(), dt.Rows[i]["LogicalText"].ToString());
        }
    }

    public class Language
    {
        public Language()
        {
            NameX = NameEng = NameGeo = "EmptyValue";
        }

        public Language(string nameGeo, string nameEng, string nameX)
        {
            NameGeo = nameGeo;
            NameEng = nameEng;
            NameX = nameX;
        }

        public string NameGeo { get; private set; }
        public string NameEng { get; private set; }
        public string NameX { get; private set; }
    }

    public class AdminFieldProperty
    {
        public AdminFieldProperty(string editFormat, string displayFormat)
        {
            EditFormat = editFormat;
            DisplayFormat = displayFormat;
        }

        public string DisplayFormat { get; private set; }
        public string EditFormat { get; private set; }
    }

    public class AdminChangeSelected
    {
        public AdminChangeSelected(short idAdminControlType)
        {
            IdAdminControlType = idAdminControlType;
        }

        public short IdAdminControlType { get; private set; }
    }

    public class CLSZeddAuto
    {
        public CLSZeddAuto(int num, string prefics, string sufics)
        {
            Num = num;
            Prefics = prefics;
            Sufics = sufics;
        }

        public int Num { get; set; }
        public string Prefics { get; set; }
        public string Sufics { get; set; }

        public override string ToString()
        {
            return Prefics + Num + Sufics;
        }
    }

    public static class StringParameters
    {
        public static string Confirm
        {
            get { return "დასტური".Translate(); }
        }

        public static string ConfirmDelete
        {
            get { return "წაიშალოს ჩანაწერი?".Translate(); }
        }

        public static string ConfirmEdit
        {
            get { return "გსურთ რედაქტირება?".Translate(); }
        }

        public static string CaptionAdd
        {
            get { return "ჩამატება".Translate(); }
        }

        public static string CaptionEdit
        {
            get { return "რედაქტირება".Translate(); }
        }

        public static string CaptionCopy
        {
            get { return "კოპირება".Translate(); }
        }

        public static string CaptionFind
        {
            get { return "ძებნა".Translate(); }
        }

        public static string CaptionError
        {
            get { return "შეცდომა".Translate(); }
        }

        public static string LookupEditNullText
        {
            get { return "გთხოვთ არიჩიოთ სიიდან".Translate(); }
        }

        public static string LookupEditNullTextReport
        {
            get { return "გთხოვთ არიჩიოთ რეპორტის ფაილი".Translate(); }
        }

        public static string GascorebaDgeError
        {
            get { return "თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!".Translate(); }
        }

        public static string GascorebaSxvaError
        {
            get { return "თქვენ არ შეგიძლიათ სხვა მომხმარებლის მიერ შეტანილი ინფორმაციის ცვლილება!".Translate(); }
        }

        public static string ReportNoData
        {
            get { return "რეპორტი არ შეიცავს მონაცემებს".Translate(); }
        }

        public static string NoCompany
        {
            get { return "კომპანიის რეკვიზიტები არაა განსაზღვრული".Translate(); }
        }

        public static string NoParams
        {
            get { return "ვერ ხერხდება პარამეტრების განსაზღვრა".Translate(); }
        }

        public static string NoGroupBy
        {
            get { return "გთხოვთ მონიშნოთ ველები დაჯგუფებისთვის".Translate(); }
        }

        public static string GridColumnFreezeRight
        {
            get { return "სვეტის გაყინვა მარჯვნივ".Translate(); }
        }

        public static string GridColumnFreezeLeft
        {
            get { return "სვეტის გაყინვა მარცხნივ".Translate(); }
        }

        public static string GridColumnRemoveFreeze
        {
            get { return "გაყინვის მოხსნა".Translate(); }
        }

        public static string GridColumnRemoveFreezeAll
        {
            get { return "გაყინვის მოხსნა ყველა სვეტზე".Translate(); }
        }

        public static string GridColumnFilterMode
        {
            get { return "ფილტრით რამდენიმეს ამორჩევის საშვალება".Translate(); }
        }

        public static string GridColumnChangeSelected
        {
            get { return "ჩანაწერების ერთიანი ცვლილება".Translate(); }
        }

        public static string GridViewGroupPanelText
        {
            get { return "დაჯგუფება".Translate(); }
        }

        public static string FFormGroupPanelClear
        {
            get { return "დაჯგუფების მოხსნა".Translate(); }
        }

        public static string FFormGroupPanelText
        {
            get { return "დაჯგუფების პარამეტრები".Translate(); }
        }

        public static string RsConnectionEstablished
        {
            get { return "კავშირი დამყარებულია".Translate(); }
        }

        public static string RsConnectionFailedCheckUser
        {
            get { return "ვერ მოხერხდა სისტემასთან კავშირი, შეამოწმეთ მომხმარებელი და პაროლი".Translate(); }
        }

        public static string RsConnectionFailed
        {
            get { return "ვერ მოხერხდა სისტემასთან კავშირი, შეამოწმეთ მომხმარებელი და პაროლი".Translate(); }
        }

        public static string ChartOperationHorizontal
        {
            get { return "ჰორიზონტალური(სტრიქონების მიხედვით)".Translate(); }
        }

        public static string ChartOperationVertical
        {
            get { return "ვერტიკალური(კოლონების მიხედვით)".Translate(); }
        }

        public static string PtOptionsDataFieldCaption
        {
            get { return "მონაცემები".Translate(); }
        }

        public static string CaptionPeriodi
        {
            get { return "პერიოდის არჩევა".Translate(); }
        }

        public static string CaptionTxtData
        {
            get { return "თარიღის არჩევა".Translate(); }
        }

        public static string Today
        {
            get { return "დღევანდელი".Translate(); }
        }

        public static string Last3Days
        {
            get { return "ბოლო 3 დღის".Translate(); }
        }

        public static string LastWeek
        {
            get { return "ბოლო კვირა".Translate(); }
        }

        public static string LastMonth
        {
            get { return "ბოლო თვე".Translate(); }
        }

        public static string LastYear
        {
            get { return "ბოლო წელი".Translate(); }
        }

        public static string Everything
        {
            get { return "სრული ინფორმაცია".Translate(); }
        }

        public static string January
        {
            get { return "იანვარი".Translate(); }
        }

        public static string February
        {
            get { return "თებერვალი".Translate(); }
        }

        public static string March
        {
            get { return "მარტი".Translate(); }
        }

        public static string April
        {
            get { return "აპრილი".Translate(); }
        }

        public static string May
        {
            get { return "მაისი".Translate(); }
        }

        public static string June
        {
            get { return "ივნისი".Translate(); }
        }

        public static string July
        {
            get { return "ივლისი".Translate(); }
        }

        public static string August
        {
            get { return "აგვისტო".Translate(); }
        }

        public static string September
        {
            get { return "სექტემბერი".Translate(); }
        }

        public static string October
        {
            get { return "ოქტომბერი".Translate(); }
        }

        public static string November
        {
            get { return "ნოემბერი".Translate(); }
        }

        public static string December
        {
            get { return "დეკემბერი".Translate(); }
        }

        public static string Tanam
        {
            get { return "თანამშრომელი".Translate(); }
        }

        public static string StandartTime
        {
            get { return "სტანდარტული დრო".Translate(); }
        }

        public static string StandartRaod
        {
            get { return "სტანდარტული რაოდენობა".Translate(); }
        }

        public static string CaptionPanelLayoutOperations
        {
            get { return "ძებნის ფილტრის სქემები".Translate(); }
        }

        public static string CaptionGridLayoutOperations
        {
            get { return "ცხრილის სქემები".Translate(); }
        }
    }

}