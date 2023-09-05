using System;
using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.Interfaces
{
    public interface ISelect : IDisposable
    {
        bool SearchOnLeave { get; set; }
        string Id { get; set; }
        string Label { get; set; }
        string Filter { get; set; }
        LabelControl CustomLabel { get; set; }
        //რედაქტირების ფორმისას რო ტექსტი დაჯდეს ავტომატურად
        void SetLabelText();
        event EventHandler<ISelectArgs> ClickedForSearch;
    }

    public class ISelectArgs : EventArgs
    {
        public ISelectArgs(string currentId)
        {
            CurrentId = currentId;
        }

        public string CurrentId { get; private set; }
    }
}