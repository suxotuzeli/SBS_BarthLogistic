using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.ge.rs.services;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Classes
{
    class CLSWayBillOperation
    {
        const string MainUser = "satesto2";
        const string MainPassword = "123456";
        readonly WayBills clsWayBills;
        readonly string sp;
        readonly string su;
        public string Ip;
        int unId;
        int userId;

        public CLSWayBillOperation()
        {
            su = Company.su;
            sp = Company.sp;
            Ip = Company.ip;
            clsWayBills = new WayBills();
        }

        public CLSWayBillOperation(string su, string sp, string ip)
        {
            this.sp = sp;
            this.su = su;
            Ip = ip;
            clsWayBills = new WayBills();
        }

        public string MyIp()
        {
            return clsWayBills.what_is_my_ip();
        }

        public bool CreateServiceUser(string mainUser1, string mainPass1, string ip1, string name1, string su1,
            string sp1)
        {
            return clsWayBills.create_service_user(mainUser1, mainPass1, ip1, name1, su1, sp1);
        }

        public DataTable WaybillbyNumber(string wbillNumb)
        {
            var getwaybillbyNumber = clsWayBills.get_waybill_by_number(su, sp, wbillNumb);
            var dt = GetDataTableFromXml(getwaybillbyNumber);
            return dt;
        }

        public DataTable GetUsers()
        {
            var getServiceUsersData = clsWayBills.get_service_users(MainUser, MainPassword);
            return GetDataTableFromXml(getServiceUsersData);
        }

        public DataTable GetUsers(string mainUser, string mainPassword)
        {
            var getServiceUsersData = clsWayBills.get_service_users(mainUser, mainPassword);
            return GetDataTableFromXml(getServiceUsersData);
        }

        public bool CheckServiceUser()
        {
            var result = clsWayBills.chek_service_user(su, sp, out unId, out userId);
            Company.UnId = unId;
            Company.UserId = userId;
            return result;
        }

        public bool UpdateServiceUser(string mainUser1, string mainPass1, string ip1, string name1, string su1,
            string sp1)
        {
            return clsWayBills.update_service_user(mainUser1, mainPass1, ip1, name1, su1, sp1);
        }

        public int CloseWayBill(int waybillId)
        {
            return clsWayBills.close_waybill(su, sp, waybillId);
        }

        public int CloseWayBillVd(int waybillId, DateTime beginData)
        {
            return clsWayBills.close_waybill_vd(su, sp, beginData, waybillId);
        }

        public int DeleteWayBill(int waybillId)
        {
            var deleteWayBill = clsWayBills.del_waybill(su, sp, waybillId);
            return deleteWayBill;
        }

        public int RefWayBill(int waybillId)
        {
            var refWayBill = clsWayBills.ref_waybill(su, sp, waybillId);
            return refWayBill;
        }

        public int RefWayBillVd(int waybillId, string comment)
        {
            var refWayBill = clsWayBills.ref_waybill_vd(su, sp, waybillId, comment);
            return refWayBill;
        }

        public int DeleteBarCode(string barCode)
        {
            return clsWayBills.delete_bar_code(su, sp, barCode);
        }

        public DataTable GetWayBills(DateTime? dataBegin1, DateTime? dataBegin2, DateTime? dataCreate1,
            DateTime? dataCreate2,
            DateTime? dataDelivery1, DateTime? dataDelivery2, DateTime? dataClosed1, DateTime? dataClosed2,
            string man, string piradiNom, string zedd, string sagad, decimal? tanxa, string type, string status,
            string comment)
        {
            const string sUserIds = "";

            var waybillsResult = clsWayBills.get_waybills(
                su,
                sp,
                type,
                sagad,
                status,
                man,
                dataBegin1,
                dataBegin2,
                dataCreate1,
                dataCreate2,
                piradiNom,
                dataDelivery1,
                dataDelivery2,
                tanxa,
                zedd,
                dataClosed1,
                dataClosed2,
                sUserIds,
                comment);
            var dt = GetDataTableFromXml(waybillsResult);
            return dt;
        }

        public DataTable GetBuyerWayBills(DateTime? dataBegin1, DateTime? dataBegin2, DateTime? dataCreate1,
            DateTime? dataCreate2,
            DateTime? dataDelivery1, DateTime? dataDelivery2, DateTime? dataClosed1, DateTime? dataClosed2,
            string man, string piradiNom, string zedd, string sagad, decimal? tanxa, string type, string status,
            string comment)
        {
            const string sUserId = "";

            var waybillsResult = clsWayBills.get_buyer_waybills(
                su,
                sp,
                type,
                sagad,
                status,
                man,
                dataBegin1,
                dataBegin2,
                dataCreate1,
                dataCreate2,
                piradiNom,
                dataDelivery1,
                dataDelivery2,
                tanxa,
                zedd,
                dataClosed1,
                dataClosed2,
                sUserId,
                comment);
            var dt = GetDataTableFromXml(waybillsResult);
            return dt;
        }

        public DataTable GetWayBill(int waybillId)
        {
            var waybill = clsWayBills.get_waybill(su, sp, waybillId);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetAdjastedWayBills(int waybillId)
        {
            var waybill = clsWayBills.get_adjusted_waybills(su, sp, waybillId);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetAdjastedWayBill(int id)
        {
            var waybill = clsWayBills.get_adjusted_waybill(su, sp, id);
            return GetDataTableFromXml(waybill);
        }

        public DataSet GetWayBillDataSet(int waybillId)
        {
            var waybill = clsWayBills.get_waybill(su, sp, waybillId);
            return GetDataSetFromXml(waybill);
        }

        public DataTable GetBarCodes()
        {
            XmlNode waybill;
            var i = clsWayBills.get_bar_codes(su, sp, "", out waybill);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetTransTypes()
        {
            var waybill = clsWayBills.get_trans_types(su, sp);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetAqcizi()
        {
            var waybill = clsWayBills.get_akciz_codes(su, sp, "");
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetCarNumbers()
        {
            XmlNode waybill;
            var i = clsWayBills.get_car_numbers(su, sp, out waybill);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetWayBillTypes()
        {
            var waybill = clsWayBills.get_waybill_types(su, sp);
            return GetDataTableFromXml(waybill);
        }

        public DataTable GetGoodsTypes()
        {
            //            XmlNode waybill = clsWayBills.get_goods_types(su, sp);
            //            return GetDataTableFromXml(waybill);
            return new DataTable();
        }

        public DataTable GetErrorCodes()
        {
            var waybill = clsWayBills.get_error_codes(su, sp);
            return GetDataTableFromXml(waybill);
        }

        public bool DGGStatus(string tin)
        {
            return clsWayBills.is_vat_payer_tin(su, sp, tin);
        }

        public string GetNameFromTin(string tin)
        {
            return clsWayBills.get_name_from_tin(su, sp, tin);
        }

        public DataTable GetWayBillUnits()
        {
            var waybill = clsWayBills.get_waybill_units(su, sp);
            return GetDataTableFromXml(waybill);
        }

        public bool ConfirmWayBill(int waybillId)
        {
            return clsWayBills.confirm_waybill(su, sp, waybillId);
        }

        public string GetTinFromUnId(out string name)
        {
            return clsWayBills.get_tin_from_un_id(su, sp, unId, out name);
        }

        public int GetPayerTypeFromUnId()
        {
            return clsWayBills.get_payer_type_from_un_id(su, sp, unId);
        }

        public string SendWayBill(int waybillId)
        {
            return clsWayBills.send_waybill(su, sp, waybillId);
        }

        public string SendWayBillVd(int waybillId, DateTime beginData)
        {
            return clsWayBills.send_waybil_vd(su, sp, beginData, waybillId);
        }

        public int CreateSubWaiBill(int waybillId)
        {
            //            return clsWayBills.create_sub_waybill(su, sp, waybill_id);
            return 0;
        }

        public int SaveBarCode(string barCode, string name, int idUnit, string unitName)
        {
            const int aqciziId = 0;
            return clsWayBills.save_bar_code(su, sp, barCode, name, idUnit, unitName, aqciziId);
        }

        public int SaveCarNumbers(string name)
        {
            return clsWayBills.save_car_numbers(su, sp, name);
        }

        public bool PrintPdf(int waybillId, string wbNumber)
        {
            var printed = false;
            if (waybillId > 0)
            {
                File.WriteAllBytes(GlobalParameters.MonacemebiFolder + wbNumber + ".pdf",
                    clsWayBills.get_print_pdf(su, sp, waybillId));
                Process.Start(GlobalParameters.MonacemebiFolder + wbNumber + ".pdf");
                printed = true;
            }
            else
            {
                XtraMessageBox.Show("ზედნადები საგადასახადო საიტზე არ არის ატვირთული.", "შეტყობინება");
            }
            return printed;
        }

        public int SaveInvoice(int waybillId)
        {
            var in_inv_id = 0;
            int outInvId;
            var saveInvoice = clsWayBills.save_invoice(su, sp, waybillId, in_inv_id, out outInvId);
            if (saveInvoice > 0)
                return outInvId;
            CheckError(saveInvoice);
            return 0;
        }

        public int ChangeWaybill(int waybillId)
        {
            //            return clsWayBills.change_waybill(su, sp, waybill_id);
            return 0;
        }

        public DataTable SaveWayBill(WayBillInformation information, string tableName)
        {
            var dt =
                SQL.Select("SELECT * FROM " + tableName + "2View WHERE IsVirtual = 0 AND Id" + tableName + "1 = " +
                           information.myId);

            return SaveWayBill(information, dt);
        }

        public DataTable SaveWayBill(WayBillInformation information, DataTable dt)
        {
            return SaveWayBill(information, dt, false);
        }

        public DataTable SaveWayBill(WayBillInformation information, DataTable dt, bool update)
        {
            var waybillDoc = new XmlDocument();
            XmlNode waybillNode = waybillDoc.CreateElement("WAYBILL");

            XmlNode goodsListNode = waybillDoc.CreateElement("GOODS_LIST");


            if (update)
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var dr = dt.Rows[i];
                    XmlNode goods = waybillDoc.CreateElement("GOODS");
                    AppendNodeChild(waybillDoc, goods, "ID", dr["ID"].ToString());
                    AppendNodeChild(waybillDoc, goods, "W_NAME", dr["W_NAME"].ToString());
                    AppendNodeChild(waybillDoc, goods, "UNIT_ID", dr["UNIT_ID"].ToString());
                    AppendNodeChild(waybillDoc, goods, "UNIT_TXT", "");
                    AppendNodeChild(waybillDoc, goods, "Quantity", dr["QUANTITY"].ToString());
                    AppendNodeChild(waybillDoc, goods, "PRICE", dr["PRICE"].ToString());
                    AppendNodeChild(waybillDoc, goods, "AMOUNT", dr["AMOUNT"].ToString());
                    AppendNodeChild(waybillDoc, goods, "BAR_CODE", dr["BAR_CODE"].ToString());
                    AppendNodeChild(waybillDoc, goods, "A_ID", "0");
                    AppendNodeChild(waybillDoc, goods, "STATUS", "-1");
                    AppendNodeChild(waybillDoc, goods, "VAT_TYPE", dr["VAT_TYPE"].ToString());
                    goodsListNode.AppendChild(goods);
                }
            }
            else
            {

                for (var i = 0; i < dt.Rows.Count; i++)
                {
//                    var dr = dt.Rows[i];
//                    XmlNode goods = waybillDoc.CreateElement("GOODS");
//                    AppendNodeChild(waybillDoc, goods, "ID", "0");
//                    AppendNodeChild(waybillDoc, goods, "W_NAME", dr["Prod"].ToString());
//                    AppendNodeChild(waybillDoc, goods, "UNIT_ID", dr["IdUnit"].ToString());
//                    AppendNodeChild(waybillDoc, goods, "UNIT_TXT", dr["UnitName"].ToString());
//                    AppendNodeChild(waybillDoc, goods, "Quantity", dr["Raod"].ToString());
//                    AppendNodeChild(waybillDoc, goods, "PRICE",
//                        (Convert.ToDouble(dr["Tanxa"].ToString()) / Convert.ToDouble(dr["Raod"].ToString())).ToString());
//                    AppendNodeChild(waybillDoc, goods, "AMOUNT", Math.Round(Convert.ToDouble(dr["Tanxa"].ToString()),0).ToString());
//                    AppendNodeChild(waybillDoc, goods, "BAR_CODE", dr["IdProd"].ToString());
//                    AppendNodeChild(waybillDoc, goods, "A_ID", "0");
//                    AppendNodeChild(waybillDoc, goods, "STATUS", "1");
//                    AppendNodeChild(waybillDoc, goods, "VAT_TYPE", dr["ProdDggStatus"].ToString());
//                    goodsListNode.AppendChild(goods);
                    DataRow dr = dt.Rows[i];
                    XmlNode goods = waybillDoc.CreateElement("GOODS");
                    AppendNodeChild(waybillDoc, goods, "ID", "0");
                    AppendNodeChild(waybillDoc, goods, "W_NAME", dr["Prod"].ToString());
                    AppendNodeChild(waybillDoc, goods, "UNIT_ID", dr["IdUnit"].ToString());
                    AppendNodeChild(waybillDoc, goods, "UNIT_TXT", dr["UnitName"].ToString());
                    AppendNodeChild(waybillDoc, goods, "QUANTITY", (Convert.ToDouble(dr["Raod"].ToString()) ).ToString());
                    AppendNodeChild(waybillDoc, goods, "PRICE", (Convert.ToDouble(dr["Tanxa"].ToString()) / Convert.ToDouble(dr["Raod"].ToString())).ToString());
                    AppendNodeChild(waybillDoc, goods, "AMOUNT", (Convert.ToDouble(dr["Tanxa"].ToString())).ToString());
                    AppendNodeChild(waybillDoc, goods, "BAR_CODE", dr["IdProd"].ToString());
                    AppendNodeChild(waybillDoc, goods, "A_ID", "0");
                    AppendNodeChild(waybillDoc, goods, "STATUS", "1");
                    AppendNodeChild(waybillDoc, goods, "VAT_TYPE", dr["ProdDggStatus"].ToString());
                    goodsListNode.AppendChild(goods);
                }
            }

            waybillNode.AppendChild(goodsListNode);
            if (information.IS_DRIVER)
            {
                AppendNodeChild(waybillDoc, waybillNode, "ID", information.ID.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "TYPE", information.TYPE.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "BUYER_TIN", information.BUYER_TIN);
                AppendNodeChild(waybillDoc, waybillNode, "CHEK_BUYER_TIN", information.CHEK_BUYER_TIN.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "BUYER_NAME", information.BUYER_NAME);
                AppendNodeChild(waybillDoc, waybillNode, "START_ADDRESS", information.START_ADDRESS);
                AppendNodeChild(waybillDoc, waybillNode, "END_ADDRESS", information.END_ADDRESS);
                AppendNodeChild(waybillDoc, waybillNode, "DRIVER_TIN", information.DRIVER_TIN);
                AppendNodeChild(waybillDoc, waybillNode, "CHEK_DRIVER_TIN", information.CHEK_DRIVER_TIN.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "DRIVER_NAME", information.DRIVER_NAME);
                AppendNodeChild(waybillDoc, waybillNode, "TRANSPORT_COAST", information.TRANSPORT_COAST.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "RECEPTION_INFO", information.RECEPTION_INFO);
                AppendNodeChild(waybillDoc, waybillNode, "RECEIVER_INFO", information.RECEIVER_INFO);
                AppendNodeChild(waybillDoc, waybillNode, "DELIVERY_DATE", information.DELIVERY_DATE);
                AppendNodeChild(waybillDoc, waybillNode, "STATUS", information.STATUS.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "SELER_UN_ID", information.SELER_UN_ID);
                AppendNodeChild(waybillDoc, waybillNode, "PAR_ID", information.PAR_ID);
                AppendNodeChild(waybillDoc, waybillNode, "CAR_NUMBER", information.CAR_NUMBER);
                AppendNodeChild(waybillDoc, waybillNode, "BEGIN_DATE", information.BEGIN_DATE);
                AppendNodeChild(waybillDoc, waybillNode, "TRAN_COST_PAYER", information.TRAN_COST_PAYER.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "TRANS_ID", information.TRANS_ID.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "TRANS_TXT", information.TRANS_TXT);
                AppendNodeChild(waybillDoc, waybillNode, "COMMENT", information.COMMENT);
                AppendNodeChild(waybillDoc, waybillNode, "TRANSPORTER_TIN", "");
            }
            else
            {
                AppendNodeChild(waybillDoc, waybillNode, "ID", information.ID.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "TYPE", information.TYPE.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "BUYER_TIN", information.BUYER_TIN);
                AppendNodeChild(waybillDoc, waybillNode, "CHEK_BUYER_TIN", information.CHEK_BUYER_TIN.ToString());
                AppendNodeChild(waybillDoc, waybillNode, "BUYER_NAME", information.BUYER_NAME);
                AppendNodeChild(waybillDoc, waybillNode, "START_ADDRESS", information.START_ADDRESS);
                AppendNodeChild(waybillDoc, waybillNode, "END_ADDRESS", information.END_ADDRESS);
                AppendNodeChild(waybillDoc, waybillNode, "DELIVERY_DATE", information.DELIVERY_DATE);
                AppendNodeChild(waybillDoc, waybillNode, "STATUS", "8");
                AppendNodeChild(waybillDoc, waybillNode, "SELER_UN_ID", information.SELER_UN_ID);
                AppendNodeChild(waybillDoc, waybillNode, "PAR_ID", information.PAR_ID);
                AppendNodeChild(waybillDoc, waybillNode, "BEGIN_DATE", information.BEGIN_DATE);
                AppendNodeChild(waybillDoc, waybillNode, "TRANS_ID", "7");
                AppendNodeChild(waybillDoc, waybillNode, "COMMENT", information.COMMENT);
                AppendNodeChild(waybillDoc, waybillNode, "TRANSPORTER_TIN", information.DRIVER_TIN);
            }


            var waybill = clsWayBills.save_waybill(su, sp, waybillNode);
            var dtWayBillResult = GetDataTableFromXml(waybill);

            return CheckError(dtWayBillResult) ? dtWayBillResult : null;
        }

        public void SaveTransporter(int idWayBill, string carNumber, string driverTin, int checkDriverTin, int transType)
        {
            //clsWayBills.save_waybill_transporter(su,sp,idWayBill,carNumber,driverTin,checkDriverTin,null,transType,null)
        }

        void AppendNodeChild(XmlDocument doc, XmlNode node, string name, string text)
        {
            XmlNode type = doc.CreateElement(name);
            type.InnerText = text;
            node.AppendChild(type);
        }

        static DataTable GetDataTableFromXml(XmlNode getServiceUsersData)
        {
            var xtr = new XmlTextReader(getServiceUsersData.OuterXml, XmlNodeType.Element, null);
            var dataset = new DataSet();
            dataset.ReadXml(xtr);
            return dataset.Tables.Count > 0 ? dataset.Tables[0] : new DataTable();
        }

        static DataSet GetDataSetFromXml(XmlNode getServiceUsersData)
        {
            var xtr = new XmlTextReader(getServiceUsersData.OuterXml, XmlNodeType.Element, null);
            var dataset = new DataSet();
            dataset.ReadXml(xtr);
            return dataset;
        }


        public string ReturnXmlDate(DateTime data)
        {
            return data.Year + "-" + (data.Month.ToString().Length == 1 ? "0" + data.Month : data.Month.ToString())
                   + "-" + (data.Day.ToString().Length == 1 ? "0" + data.Day : data.Day.ToString()) + "T" +
                   (data.Hour.ToString().Length == 1 ? "0" + data.Hour : data.Hour.ToString()) + ":" +
                   (data.Minute.ToString().Length == 1 ? "0" + data.Minute : data.Minute.ToString()) + ":" +
                   (data.Second.ToString().Length == 1 ? "0" + data.Second : data.Second.ToString());
        }

        public static bool CanModifyWayBill(int idWayBillStatus)
        {
            if (idWayBillStatus != 2)
                return true;
            if (WayBillParameters.CanEditClosedZedd)
            {
                return
                    XtraMessageBox.Show("ზედნადები დახურულია, დარწმუნებული ხართ რომ გსურთ მისი ცვლილება?", "",
                        MessageBoxButtons.OKCancel) == DialogResult.OK;
            }
            XtraMessageBox.Show("თქვენ არ შეგიძლიათ დახურული ზედნადების ცვლილება");
            return false;
        }

        public static string GenerateWhereClause(GridView gv, string zeddTableName, int idWayBillStatus)
        {
            var selected = gv.GetSelectedRows();
            var s = " WHERE IdWayBillStatus = " + idWayBillStatus + " AND Id" + zeddTableName + "1 IN (";
            foreach (int t in selected)
                s += gv.GetDataRow(t)["Id" + zeddTableName + "1"] + ", ";
            return s.Substring(0, s.Length - 2) + ") ";
        }

        public static void GridRowStyle(object sender, RowStyleEventArgs e)
        {
            if (!WayBillParameters.ShowInColors)
                return;
            var view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            var value = Convert.ToInt32(view.GetRowCellDisplayText(e.RowHandle, view.Columns["IdWayBillStatus"]));
            switch (value)
            {
                case -1:
                    e.Appearance.ForeColor = Color.Navy;
                    break;
                case 1:
                    e.Appearance.ForeColor = Color.Maroon;
                    break;
                case 2:
                    e.Appearance.ForeColor = Color.Black;
                    break;
            }
        }

        public static bool CheckError(DataTable dtWayBillResult)
        {
            return CheckError(Convert.ToInt32(dtWayBillResult.Rows[0]["STATUS"].ToString()));
        }

        public static bool CheckError(int result)
        {
            if (result < 0)
            {
                string error;
                var dt = SQL.Select("SELECT * FROM ErrorCodes WHERE IdErrorCodes = " + result);
                if (dt.Rows.Count == 0)
                    error = "";
                else
                    error = "სავარაუდო შეცდომა: " + dt.Rows[0]["ErrorCodes"];

                XtraMessageBox.Show("ვერ მოხერხდა ზედნადების ატვირთვა. \n" + error);
                return false;
            }
            return true;
        }

        public bool CloseWayBill(string filter, string tableName, DateTime beginData)
        {
            var dt = SQL.Select("SELECT Id" + tableName + "WayBill1 FROM " + tableName + "1 " + filter);
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("ზედდებულის დახურვა შეუძლებელია");
                return false;
            }
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var wayBillId = Convert.ToInt32(dt.Rows[i]["Id" + tableName + "WayBill1"].ToString());
                var d = new DateTime(beginData.Year, beginData.Month, beginData.Day, 23, 0, 0);
                if (d > DateTime.Now)
                    d = DateTime.Now;
                var error = CloseWayBillVd(wayBillId, d);
                if (error != 1)
                {
                    XtraMessageBox.Show("ვერ დაიხურა ზედნადები. " + CheckError(error));
                    return false;
                }
                if (wayBillId > 0)
                    SQL.Update(
                        "UPDATE " + tableName + "1 SET IdWayBillStatus = 2 WHERE Id" + tableName + "WayBill1 = " +
                        wayBillId, InterfaceParameters.CreateLogRs);
            }
            XtraMessageBox.Show("ზედნადებები დახურულია");
            return true;
        }

        public bool ExportFactura(int id, int idWayBill, bool needFactura, int idWayBillStatus, string factura,
            string tableName)
        {
            if (factura.Length > 0)
            {
                if (
                    XtraMessageBox.Show("ფაქტურა ატვირთულია, დარწმუნებული ხართ რომ გსურთ მისი ატვირთვა?  ", "",
                        MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return false;
            }

            if (!WayBillParameters.CanSendFactura)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ფაქტურის ატვირთვა");
                return false;
            }
            if (!needFactura)
            {
                XtraMessageBox.Show("ორგანიზაცია არ არის დღგ-ს გადამხდელი");
                return false;
            }

            if (idWayBillStatus < 2)
            {
                XtraMessageBox.Show("ზედნადები არაა დახურული, ფაქტურის გადაგზავნა შეუძლებელია");
                return false;
            }

            if (XtraMessageBox.Show("გადავაგზავნოთ ფაქტურა?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return false;
            var result = SaveInvoice(idWayBill);
            if (result > 1)
            {
                SQL.Update(
                    "UPDATE " + tableName + "1 SET Factura = N'" + result + "', DataFactura = GETDATE() WHERE Id" +
                    tableName +
                    "1 = " + id, InterfaceParameters.CreateLogRs);
            }
            return true;
        }

        public bool ExportWayBill(int id, int idWayBillStatus, string tableName, bool setCompanyValues, int idTransType,
            string filter, string parentId, bool hasOrgInformation)
        {
            if (XtraMessageBox.Show("ავტვირთოთ ზედნადები?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return false;

            var info = new WayBillInformation();

            var dtOrg = SQL.Select("SELECT * FROM " + tableName + "1View " + filter);

            try
            {
                for (var i = 0; i < dtOrg.Rows.Count; i++)
                {
                    var dr = dtOrg.Rows[i];
                    int transType;
                    if (idTransType == 23)
                        transType = dr["IsTransportireba"].ToString() == "True" ? 2 : 3;
                    else
                        transType = idTransType;
                    SetWayBillInformation(dr, info, hasOrgInformation, parentId, transType, 0, tableName);

                    int idWayBill;
                    using (var dt1 = SaveWayBill(info, tableName))
                    {
                        if (dt1 == null)
                            return false;
                        idWayBill = Convert.ToInt32(dt1.Rows[0]["ID"].ToString());
                    }
                    using (var dt1 = GetWayBill(idWayBill))
                    {
                        if (dt1.Rows.Count > 0)
                        {
                            if (dr["IsDriver"].ToString() == "True")
                            {
                                SQL.Update(string.Format(
                                        "UPDATE {0}1 SET Id{0}WayBill1 = {1}, OldZedd = Zedd, Zedd = N'{2}', IdWayBillStatus = {3} WHERE Id{0}1 = {4}",
                                        tableName, idWayBill, dt1.Rows[0]["WAYBILL_NUMBER"], info.STATUS, info.myId),
                                    InterfaceParameters.CreateLogRs);
                                if (tableName == "Real")
                                {
                                    var dt2 = SQL.Select("SELECT OldZedd FROM " + tableName + "1View WHERE IdReal1 = " + info.myId);
                                    if (dt2.Rows.Count > 0)
                                    {
                                        SQL.Update("UPDATE Sal SET Zedd = N'" + dt1.Rows[0]["WAYBILL_NUMBER"] +
                                                   "' WHERE Zedd = N'" + dt2.Rows[0]["OldZedd"] + "'",
                                            InterfaceParameters.CreateLogRs);
                                    }
                                }
                            }
                            else
                            {
                                SQL.Update(string.Format(
                                        "UPDATE {0}1 SET Id{0}WayBill1 = {1}, OldZedd = Zedd, IdWayBillStatus = {2} WHERE Id{0}1 = {3}",
                                        tableName, idWayBill, info.STATUS, info.myId), InterfaceParameters.CreateLogRs);
                            }
                        }
                    }
                }
                XtraMessageBox.Show("მონაცემებთა გადაგზავნა დამთავრებულია");
            }
            catch (Exception ex)
            {
                ex.ShowErrorDialog();
                //XtraMessageBox.Show("ვერ მოხერხდა მონაცემთა სრული გადაგზავნა");
                return false;
            }
            return true;
        }

        public bool RefWayBill(int idWayBillStatus, int wayBillId, string tableName)
        {
            if (XtraMessageBox.Show("წავშალოთ ზედნადები საგადასახადოს საიტზე?", "", MessageBoxButtons.OKCancel) ==
                DialogResult.Cancel)
                return false;
            if (idWayBillStatus == 2)
            {
                XtraMessageBox.Show("ზედნადები უკვე დახურულია, შეუძლებელია მისი წაშლა");
                return false;
            }
            RefWayBill(wayBillId);
            if (wayBillId > 0)
            {
                if (tableName == "Real")
                {
                    var dt2 = SQL.Select("SELECT Zedd, OldZedd FROM Real1View WHERE IdRealWayBill1 = " + wayBillId);
                    if (dt2.Rows.Count > 0)
                        SQL.Update("UPDATE Sal SET Zedd = N'" + dt2.Rows[0]["OldZedd"] + "' WHERE Zedd = N'" +
                                   dt2.Rows[0]["Zedd"] + "'", InterfaceParameters.CreateLogRs);
                }
                SQL.Update("UPDATE " + tableName + "1 SET IdWayBillStatus = -1, Zedd = OldZedd, OldZedd = '', Id" +
                           tableName + "WayBill1 = 0 WHERE Id" + tableName + "WayBill1 = " + wayBillId,
                    InterfaceParameters.CreateLogRs);
            }
            return true;
        }

        public bool UpdateWayBill(int idWayBill, int id, int idWayBillStatus, string tableName, bool setCompanyValues,
            int idTransType, bool hasOrgInformation)
        {
            //            if (!WayBillParameters.CanUpdateActiveZedd) {
            //                XtraMessageBox.Show("თქვენ არ შეგიძლიათ აქტიური ზედნადების რედაქტირება");
            //                return false;
            //            }
            if (XtraMessageBox.Show("შევცვალოთ ატვირთული ზედნადები?", "", MessageBoxButtons.OKCancel) ==
                DialogResult.Cancel)
                return false;
            if (idWayBillStatus != 1)
            {
                XtraMessageBox.Show("თქვენ შეგიძლიათ მხოლოდ აქტიური ზედნადების ცვლილება");
                return false;
            }

            var info = new WayBillInformation();

            var ds = GetWayBillDataSet(idWayBill);
            var dtOrg = SQL.Select("SELECT * FROM " + tableName + "1View WHERE Id" + tableName + "1 = " + id);
            try
            {
                for (var i = 0; i < dtOrg.Rows.Count; i++)
                {
                    var dr = dtOrg.Rows[i];
                    int transType;
                    if (idTransType == 23)
                        transType = dr["IsTransportireba"].ToString() == "True" ? 2 : 3;
                    else
                        transType = idTransType;
                    SetWayBillInformation(dr, info, hasOrgInformation, ds.Tables[0].Rows[0]["PAR_ID"].ToString(),
                        transType, idWayBill, tableName);

                    SaveWayBill(info, tableName);
                    if (ds.Tables.Count > 2)
                    {
                        var dtProdWayBill = ds.Tables[2];
                        SaveWayBill(info, dtProdWayBill, true);
                    }
                }
                XtraMessageBox.Show("მონაცემებთა გადაგზავნა დამთავრებულია");
            }
            catch (Exception ex)
            {
                ex.ShowErrorDialog();
                //XtraMessageBox.Show("ვერ მოხერხდა მონაცემთა სრული გადაგზავნა");
                return false;
            }
            return true;
        }

        public void SetWayBillInformation(DataRow dr, WayBillInformation info, bool hasOrgInformation, string parentId,
            int transType, int wayBillId, string tableName)
        {
            info.myId = Convert.ToInt32(dr["Id" + tableName + "1"].ToString());
            info.ID = wayBillId;
            if (hasOrgInformation)
            {
                info.BUYER_TIN = dr["Sagad"].ToString();
                info.CHEK_BUYER_TIN = dr["GvariIsCitizen"].ToString() == "True" ? 1 : 0;
                info.BUYER_NAME = dr["Gvari"].ToString();
            }
            else
            {
                info.BUYER_TIN = "";
                info.CHEK_BUYER_TIN = 1;
                info.BUYER_NAME = "";
            }
            info.IS_DRIVER = dr["IsDriver"].ToString() == "True";
            switch (transType)
            {
                case 1:
                    info.START_ADDRESS = dr["Address1"].ToString();
                    info.END_ADDRESS = dr["Address2"].ToString();
                    info.RECEPTION_INFO = dr["ProekGaagzavna"].ToString();
                    info.RECEIVER_INFO = dr["ProekMiigo"].ToString();

                    break;
                case 3:
                    info.START_ADDRESS = dr["ProekAddress"].ToString();
                    info.END_ADDRESS = dr["ProekAddress"].ToString();
                    info.RECEPTION_INFO = dr["ProekGaagzavna"].ToString();
                    info.RECEIVER_INFO = dr["ProekMiigo"].ToString();
                    break;
                case 5:
                    info.START_ADDRESS = dr["GvariAddress"].ToString() == ""
                        ? dr["Address"].ToString()
                        : dr["GvariAddress"].ToString();
                    info.END_ADDRESS = dr["ProekAddress"].ToString();
                    info.RECEIVER_INFO = dr["ProekGaagzavna"].ToString();
                    info.RECEPTION_INFO = dr["ProekMiigo"].ToString();
                    break;
                default:
                    info.START_ADDRESS = dr["ProekAddress"].ToString();
                    info.END_ADDRESS = dr["GvariAddress"].ToString() == ""
                        ? dr["Address"].ToString()
                        : dr["GvariAddress"].ToString();
                    info.RECEPTION_INFO = dr["ProekGaagzavna"].ToString();
                    info.RECEIVER_INFO = dr["ProekMiigo"].ToString();
                    break;
            }

            string carNumb = dr["MdzNom"].ToString() == "" ? dr["Nom"].ToString() : dr["MdzNom"].ToString(), carNumber,
                   misabmeli;
            if (carNumb.Contains("--") & Convert.ToInt32(WayBillParameters.IdTransTypes) != 99)
            {
                carNumber = carNumb.Substring(0, carNumb.IndexOf("--"));
                misabmeli = carNumb.Substring(carNumb.IndexOf("--") + 2);
            }
            else
            {
                carNumber = carNumb;
                misabmeli = "";
            }

            info.TYPE = transType;
            info.DRIVER_TIN = dr["PiradiNom"].ToString();
            info.CHEK_DRIVER_TIN = Convert.ToBoolean(dr["MdzIsCitizen"].ToString()) ? 1 : 0;
            info.DRIVER_NAME = dr["Mdz"].ToString();
            info.TRANSPORT_COAST = Convert.ToDouble(dr["TransTanxa"].ToString());
            //                    info.DELIVERY_DATE = wayBill.ReturnXmlDate(Convert.ToDateTime(dr["Data"].ToString()));
            info.DELIVERY_DATE = "";
            info.STATUS = 1;
            info.SELER_UN_ID = Company.UnId.ToString();
            info.PAR_ID = parentId;
            info.CAR_NUMBER = carNumber;
            info.BEGIN_DATE = ReturnXmlDate(Convert.ToDateTime(dr["ActivateData"].ToString()));
            info.TRAN_COST_PAYER = Convert.ToBoolean(dr["TransGamkidveli"].ToString()) ? 2 : 1;
            info.TRANS_ID = Convert.ToInt32(dr["IdTransTypes"].ToString());
            info.TRANS_TXT = misabmeli.Length > 0 ? misabmeli : dr["TransTypesName"].ToString();
            info.COMMENT = dr["Shen"].ToString();
        }
    }
}