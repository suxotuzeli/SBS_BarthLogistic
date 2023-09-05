using System.Data.SqlClient;

namespace SBS_BarthLogistic.Interfaces
{
    public interface IFMGFindControl : System.IDisposable
    {
        //Find Formისთვის
        string GetWhereCmd();

        //ექსელში ექსპორტისთვის (რითია გაფილტრული)
        object GetValue();

        //XML-ს აღდგენა (პანელზე)
        void SetValue(string value);

        //რეპორტებისთვის
        void AddProcParameter(SqlCommand cmd);

        //აბრუნებს კონტროლის შესაბამისად იდენთიფიკატორს
        object GetId();

        string FieldName { get; set; }

        //იმ შემთხვევაშია საჭირო ამის მინიჭება თუ პროცედურაში არგუმენტად უნდა წავიდეს FieldName-სგან განსხვავებული
        string ParameterName { get; set; }

        bool Checked { get; set; }

        bool AlwaysChecked { get; set; }

        string Text { get; set; }

        //რათა მოხდეს შენახვა რეგისტრებში
        System.Windows.Forms.SplitContainer SplitContainer { get; set; }
    }
}