using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using SBS_BarthLogistic.Properties;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    /// -- ვერსია 0.1 -- 10 Noe 2015 19:00 ნიკა
    /// . თარიღებს ჩავუმატე იკონები
    /// </summary>

    class CLSPeriodSettings
    {
        readonly RepositoryItemComboBox cb;
        readonly BarEditItem cbPeriod;
        readonly ToolStripComboBox cbPeriodi;
        readonly int pos;
        readonly ToolStrip ts;
        readonly BarEditItem txtData1;
        readonly BarEditItem txtData2;

        public CLSPeriodSettings(ToolStripComboBox cbPeriodi)
        {
            ts = cbPeriodi.Owner;
            pos = ts.Items.IndexOf(cbPeriodi);
            this.cbPeriodi = cbPeriodi;
            cbPeriodi.DropDownStyle = ComboBoxStyle.DropDown;
        }

        public CLSPeriodSettings(BarEditItem cbPeriod, BarEditItem txtData1, BarEditItem txtData2)
        {
            this.cbPeriod = cbPeriod;
            this.txtData1 = txtData1;
            this.txtData2 = txtData2;
            cb = cbPeriod.Edit as RepositoryItemComboBox;
            (txtData1.Edit as RepositoryItemDateEdit).Buttons.Clear();
            (txtData1.Edit as RepositoryItemDateEdit).ShowClear = false;
            (txtData1.Edit as RepositoryItemDateEdit).Buttons.AddRange(new[]
            {
                new EditorButton(ButtonPredefines.Glyph, StringParameters.CaptionTxtData, -1, true, true, false, ImageLocation.MiddleCenter, Resources.AED_txtData_16x16)
            });
            (txtData2.Edit as RepositoryItemDateEdit).Buttons.Clear();
            (txtData2.Edit as RepositoryItemDateEdit).ShowClear = false;
            (txtData2.Edit as RepositoryItemDateEdit).Buttons.AddRange(new[]
            {
                new EditorButton(ButtonPredefines.Glyph, StringParameters.CaptionTxtData, -1, true, true, false, ImageLocation.MiddleCenter, Resources.AED_txtData_16x16)
            });
        }

        public DateTimePicker Txt1;
        public DateTimePicker Txt2;

        void SetText()
        {
            cbPeriodi.Items.Clear();
            cbPeriodi.ToolTipText = StringParameters.CaptionPeriodi;
            cbPeriodi.Items.AddRange(new object[]
            {
                StringParameters.Today,
                StringParameters.Last3Days,
                StringParameters.LastWeek,
                StringParameters.LastMonth,
                StringParameters.LastYear,
                StringParameters.Everything
            });
        }

        public void Initialize()
        {
            Txt1 = new DateTimePicker();
            Txt2 = new DateTimePicker();
            Txt1.Format = DateTimePickerFormat.Custom;
            Txt2.Format = DateTimePickerFormat.Custom;
            Txt1.CustomFormat = GlobalParameters.ServerDateTimeFormat;
            Txt2.CustomFormat = GlobalParameters.ServerDateTimeFormat;
            Txt1.Width = 141;
            Txt2.Width = 141;
            ts.Items.Insert(pos, new ToolStripControlHost(Txt1));
            ts.Items.Insert(pos + 1, new ToolStripLabel("-"));
            ts.Items.Insert(pos + 2, new ToolStripControlHost(Txt2));
            SetText();
            cbPeriodi.SelectedIndex = InterfaceParameters.DefaultPeriodIndex;
            SetFindTextes();
            cbPeriodi.TextChanged += cbPeriodi_TextChanged;
        }

        public void InitializeToday()
        {
            Txt1 = new DateTimePicker();
            Txt2 = new DateTimePicker();
            Txt1.Format = DateTimePickerFormat.Custom;
            Txt2.Format = DateTimePickerFormat.Custom;
            Txt1.CustomFormat = GlobalParameters.ServerDateTimeFormat;
            Txt2.CustomFormat = GlobalParameters.ServerDateTimeFormat;
            Txt1.Width = 141;
            Txt2.Width = 141;
            ts.Items.Insert(pos, new ToolStripControlHost(Txt1));
            ts.Items.Insert(pos + 1, new ToolStripLabel("-"));
            ts.Items.Insert(pos + 2, new ToolStripControlHost(Txt2));
            SetText();
            cbPeriodi.SelectedIndex = 0;
            SetFindTextes();
            cbPeriodi.TextChanged += cbPeriodi_TextChanged;
        }

        void cbPeriodi_TextChanged(object sender, EventArgs e)
        {
            SetFindTextes();
        }

        void SetPeriodi(DateTime d1, DateTime d2)
        {
            d1 = d1.AddHours(-d1.Hour);
            d1 = d1.AddMinutes(-d1.Minute);
            d2 = d2.AddHours(-d2.Hour + 23);
            d2 = d2.AddMinutes(-d2.Minute + 59);
            if (cbPeriod != null)
            {
                txtData1.EditValue = d1;
                txtData2.EditValue = d2;
                return;
            }
            Txt1.Value = d1;
            Txt2.Value = d2;
        }

        public void SetFindTextes()
        {
            if (cbPeriod != null)
            {
                switch (Convert.ToInt32(cb.Items.IndexOf(cbPeriod.EditValue)))
                {
                    case 0:
                        SetPeriodi(DateTime.Today, DateTime.Today);
                        break;
                    case 1:
                        SetPeriodi(DateTime.Today.AddDays(-3), DateTime.Today.AddDays(7));
                        break;
                    case 2:
                        SetPeriodi(DateTime.Today.AddDays(-7), DateTime.Today.AddDays(7));
                        break;
                    case 3:
                        SetPeriodi(DateTime.Today.AddMonths(-1), DateTime.Today.AddDays(7));
                        break;
                    case 4:
                        SetPeriodi(DateTime.Today.AddYears(-1), DateTime.Today.AddDays(7));
                        break;
                    case 5:
                        SetPeriodi(DateTime.Today.AddYears(-10), DateTime.Today.AddDays(7));
                        break;
                }
                return;
            }
            switch (Convert.ToInt32(cbPeriodi.SelectedIndex.ToString(CultureInfo.InvariantCulture)))
            {
                case 0:
                    SetPeriodi(DateTime.Today, DateTime.Today);
                    break;
                case 1:
                    SetPeriodi(DateTime.Today.AddDays(-3), DateTime.Today.AddDays(7));
                    break;
                case 2:
                    SetPeriodi(DateTime.Today.AddDays(-7), DateTime.Today.AddDays(7));
                    break;
                case 3:
                    SetPeriodi(DateTime.Today.AddMonths(-1), DateTime.Today.AddDays(7));
                    break;
                case 4:
                    SetPeriodi(DateTime.Today.AddYears(-1), DateTime.Today.AddDays(7));
                    break;
                case 5:
                    SetPeriodi(DateTime.Today.AddYears(-10), DateTime.Today.AddDays(7));
                    break;
            }
        }

        void cbPeriod1_EditValueChanged(object sender, EventArgs e)
        {
            SetFindTextes();
        }

        public void InitializeBarItems()
        {
            cbPeriod.EditValue = cb.Items[InterfaceParameters.DefaultPeriodIndex];
            txtData1.Width = txtData2.Width = 100;
            (txtData1.Edit as RepositoryItemDateEdit).DisplayFormat.FormatType = FormatType.DateTime;
            (txtData1.Edit as RepositoryItemDateEdit).DisplayFormat.FormatString = "dd.MM.yyyy";
            (txtData1.Edit as RepositoryItemDateEdit).EditFormat.FormatType = FormatType.DateTime;
            (txtData1.Edit as RepositoryItemDateEdit).EditFormat.FormatString = "dd.MM.yyyy";
            (txtData1.Edit as RepositoryItemDateEdit).Mask.EditMask = "dd.MM.yyyy";
            (txtData1.Edit as RepositoryItemDateEdit).EditMask = "dd.MM.yyyy";

            (txtData2.Edit as RepositoryItemDateEdit).DisplayFormat.FormatType = FormatType.DateTime;
            (txtData2.Edit as RepositoryItemDateEdit).DisplayFormat.FormatString = "dd.MM.yyyy";
            (txtData2.Edit as RepositoryItemDateEdit).EditFormat.FormatType = FormatType.DateTime;
            (txtData2.Edit as RepositoryItemDateEdit).EditFormat.FormatString = "dd.MM.yyyy";
            (txtData2.Edit as RepositoryItemDateEdit).EditMask = "dd.MM.yyyy";
            (txtData2.Edit as RepositoryItemDateEdit).Mask.EditMask = "dd.MM.yyyy";
            cbPeriod.EditValueChanged += cbPeriod1_EditValueChanged;
            SetFindTextes();
        }
    }
}