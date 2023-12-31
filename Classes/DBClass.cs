using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.FindForms;

namespace SBS_BarthLogistic.Classes
{
    class DBClass
    {
        public static bool SelectFromProd(string fg, TextEdit txtIdProd)
        {
            var returnToId = true;
            OrgProdParameters.selID = "";

            var dt = SQL.Select(string.Format(
                        " SELECT * FROM Prod INNER JOIN ProdG ON Prod.IdProdG = ProdG.IdProdG WHERE Active=1 AND IdProd = N'{0}' ",
                        txtIdProd.Text));
            if (dt.Rows.Count != 1)
            {
                InterfaceParameters.CloseForm = true;
                var fmFProd = new FProdForm(fg);
                if (fmFProd.ShowDialog() == DialogResult.OK)
                {
                    txtIdProd.Text = Convert.ToString(OrgProdParameters.selID);
                }
                else
                {
                    txtIdProd.Text = OrgProdParameters.selID != string.Empty ? OrgProdParameters.selID : string.Empty;
                }
                returnToId = fmFProd.DialogResult != DialogResult.Cancel;
                fmFProd.Dispose();
                InterfaceParameters.CloseForm = false;
            }
            else
            {
                txtIdProd.Text = dt.Rows[0]["IdProd"].ToString();
                OrgProdParameters.selID = txtIdProd.Text;
                OrgProdParameters.selCompRaod = Convert.ToDouble(dt.Rows[0]["CompRaod"].ToString());
                OrgProdParameters.SacCheck = Convert.ToBoolean(dt.Rows[0]["SacControl"].ToString());
            }
            return returnToId;
        }
    }
}