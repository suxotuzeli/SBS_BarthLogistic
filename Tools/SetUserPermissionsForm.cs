using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Tools
{
    public partial class SetUserPermissionsForm : XtraForm
    {
        DataTable dt;
        ToolTip toolTip1;

        public SetUserPermissionsForm()
        {
            InitializeComponent();
        }

        void SetUserPermissionsForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            FillUserComboBox();
            FillDt();
            toolTip1 = new ToolTip
            {
                InitialDelay = 1200,
                ReshowDelay = 1000,
                AutoPopDelay = 4000
            };
            cbMomx.EditValueChanged += CbSelectedIndexChanged;
        }

        void FillUserComboBox()
        {
            var dtUser = SQL.Select(@"SELECT UN, GascorebaDge, GascorebaSxva FROM Params WHERE UN <> 'sa' AND UN NOT LIKE 'sa[_]%' ");
            var dtUser1 = dtUser.Copy();
            cbMomx.Properties.DataSource = dtUser;
            cbMomx.Properties.ValueMember = "UN";
            cbMomx.Properties.DisplayMember = "UN";
            cbMomx2.Properties.DataSource = dtUser1;
            cbMomx2.Properties.ValueMember = "UN";
            cbMomx2.Properties.DisplayMember = "UN";
            if (dtUser.Rows.Count > 0)
            {
                cbMomx.EditValue = dtUser.Rows[0]["UN"];
                cbMomx2.EditValue = dtUser.Rows[0]["UN"];
            }
            txtGascorebaDge.Value = Convert.ToInt32(dtUser.Rows[0]["GascorebaDge"].ToString());
            chbGascorebaSxva.Checked = Convert.ToBoolean(dtUser.Rows[0]["GascorebaSxva"].ToString());
        }

        void FillDt()
        {
            var strComm = "SELECT IdMIPermissions, UN, IdMISub, CanSelect, CanInsert, CanUpdate, CanDelete, CanExec, CanView, MIMain, MISub"
                          + " FROM MIView WHERE UN = N'" + cbMomx.Text + "'";

            dt = SQL.Select(strComm);
            dg.DataSource = dt;
        }

        void CbSelectedIndexChanged(object sender, EventArgs e)
        {
            FillDt();
            var dtUser = SQL.Select("SELECT * FROM Params WHERE UN = '" + cbMomx.Text + "'");
            if (dtUser.Rows.Count > 0)
            {
                txtGascorebaDge.Value = Convert.ToInt32(dtUser.Rows[0]["GascorebaDge"].ToString());
                chbGascorebaSxva.Checked = Convert.ToBoolean(dtUser.Rows[0]["GascorebaSxva"].ToString());
            }
        }

        void SetPermissions()
        {
            SaveParams();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Unchanged)
                    UpdateDt(dt.Rows[i]["IdMIPermissions"].ToString()
                        , ReturnBooToStrValue(dt.Rows[i]["CanSelect"].ToString())
                        , ReturnBooToStrValue(dt.Rows[i]["CanUpdate"].ToString())
                        , ReturnBooToStrValue(dt.Rows[i]["CanDelete"].ToString())
                        , ReturnBooToStrValue(dt.Rows[i]["CanInsert"].ToString())
                        , ReturnBooToStrValue(dt.Rows[i]["CanExec"].ToString())
                        , ReturnBooToStrValue(dt.Rows[i]["CanView"].ToString())
                        );
            }

            SetTablePermissions(cbMomx.Text);
        }

        void BtnSaveClick(object sender, EventArgs e)
        {
            SetPermissions();
            Close();
        }

        void SaveParams()
        {
            var strComm = "UPDATE Params"
                          + " SET GascorebaDge = " + txtGascorebaDge.Value + " "
                          + ", GascorebaSxva = " + chbGascorebaSxva.ConvertCheckEditValueToInt() + " "
                          + "WHERE UN = '" + cbMomx.Text + "'";
            SQL.Update(strComm, false);
        }

        static void SetTablePermissions(string usrname)
        {
            var dtPermission = SQL.Select("SELECT * FROM MIView WHERE UN = N'" + usrname + "'");
            char[] c =
            {
                ';'
            };
            for (var i = 0; i < dtPermission.Rows.Count; i++)
            {
                SetTablePermissionStringGenerate("SELECT ",
                    dtPermission.Rows[i]["TableList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanSelect"].ToString()), usrname);
                SetTablePermissionStringGenerate("INSERT ",
                    dtPermission.Rows[i]["TableList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanInsert"].ToString()), usrname);
                SetTablePermissionStringGenerate("DELETE ",
                    dtPermission.Rows[i]["TableList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanDelete"].ToString()), usrname);
                SetTablePermissionStringGenerate("UPDATE ",
                    dtPermission.Rows[i]["TableList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanUpdate"].ToString()), usrname);

                SetTablePermissionStringGenerate("SELECT ",
                    dtPermission.Rows[i]["ViewList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanSelect"].ToString()), usrname);
                SetTablePermissionStringGenerate("EXECUTE ",
                    dtPermission.Rows[i]["ProcList"].ToString().Split(c, StringSplitOptions.RemoveEmptyEntries),
                    Convert.ToBoolean(dtPermission.Rows[i]["CanExec"].ToString()), usrname);
            }
        }

        static void SetTablePermissionStringGenerate(string selectOrExecute, string[] list, bool state, string unname)
        {
            if (state)
                foreach (var listItem in list)
                {
                    SQL.Execute($"GRANT {selectOrExecute} ON [dbo].[{listItem}] TO [{unname}]");
                }
            else
                foreach (var listItem in list)
                {
                    SQL.Execute($"REVOKE {selectOrExecute} ON [{listItem}] TO [{unname}] CASCADE");
                }
        }

        static void UpdateDt(string id, string canSelect, string canUpdate, string canDelete, string canInsert,
            string canExec, string canView)
        {
            var strComm = "UPDATE MIUserPermissions "
                          + " SET CanInsert = " + canInsert + ""
                          + ", CanUpdate = " + canUpdate + " "
                          + ", CanDelete = " + canDelete + " "
                          + ", CanExec = " + canExec + " "
                          + ", CanSelect = " + canSelect + " "
                          + ", CanView = " + canView + " "
                          + " WHERE IdMIPermissions = " + id;
            SQL.Update(strComm, false);
        }

        static string ReturnBooToStrValue(string s)
        {
            return s == "True" ? "1" : "0";
        }

        void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        void btnCopy_Click(object sender, EventArgs e)
        {
            SQL.Execute(
                "UPDATE mp SET mp.canSelect = mp2.canSelect, mp.canInsert = mp2.canInsert, mp.canUpdate = mp2.canUpdate," +
                "mp.canDelete =mp2.canDelete , mp.canExec = mp2.canExec, mp.canView = mp2.canView " +
                "FROM MIUserPermissions mp INNER JOIN MIUserPermissions mp2 ON mp.IdMISub=mp2.IdMISub " +
                "WHERE mp.UN=N'" + cbMomx2.Text + "' AND mp2.UN=N'" + cbMomx.Text + "'");
            SetTablePermissions(cbMomx2.Text);
        }

        void GridView1MouseDown(Point e)
        {
            if (!gridView1.CalcHitInfo(e.X - Left, e.Y - Top).InRowCell)
                return;
            var colmn = gridView1.CalcHitInfo(e.X - Left, e.Y - Top).Column.Name.Substring(3);
            if (colmn == "CanInsert" || colmn == "CanUpdate" || colmn == "CanDelete" || colmn == "CanExec" ||
                colmn == "CanSelect" || colmn == "CanView")
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][colmn] = chbSelect.Checked ? 1 : 0;
                }
        }

        void ChbselectCheckedChanged(object sender, EventArgs e)
        {
            chbSelect.Text = chbSelect.Checked ? "ყველას მონიშვნა" : "მონიშვნის გაუქმება";
        }

        void ChbselectMouseDown(object sender, MouseEventArgs e)
        {
            if (e.X <= 15) return;
            chbSelect.Cursor = Cursors.SizeAll;
            chbSelect.DoDragDrop(chbSelect, DragDropEffects.All);
        }

        void DgDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void DgDragDrop(object sender, DragEventArgs e)
        {
            GridView1MouseDown(MousePosition);
        }

        void chbselect_MouseMove(object sender, MouseEventArgs e)
        {
            chbSelect.Cursor = e.X > 15 ? Cursors.Hand : Cursors.Default;
        }

        void chbselect_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("გადაათრიეთ სასურველი სტრიქონის სათაურზე ან სტრიქონზე", chbSelect);
        }

        void chbUser2_CheckedChanged(object sender, EventArgs e)
        {
            cbMomx2.Visible = chbUser2.Checked;
            btnCopy.Visible = chbUser2.Checked;
        }
    }
}