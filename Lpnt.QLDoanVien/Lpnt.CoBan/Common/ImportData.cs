using System;
using System.Data;
using System.Data.OleDb;
using DevExpress.Xpo;
using Lpnt.DuLieu;
using DevExpress.Data.Filtering;

namespace Lpnt.CoBan.Common
{
    public class ImportData
    {
        private static DataTable GetExcelTable(string fileName, string sheetName)
        {
            return GetExcelTable(fileName, sheetName, string.Empty);
        }
        private static DataTable GetExcelTable(string fileName, string sheetName, string sql)
        {
            sheetName = sheetName.Replace(".", "#");
            if (sql == string.Empty)
                sql = string.Format("select * from [{0}$]", sheetName);

            var strConn = string.Empty;
            if (fileName.Contains(".xlsx"))
            {
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                          + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\";";
            }
            else if (fileName.Contains(".xls"))
            {
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                          "Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
            }
            var dt = new DataTable();
            try
            {
                var oleConn = new OleDbConnection(strConn);
                var oleCmd = new OleDbDataAdapter(sql, strConn);
                oleCmd.Fill(dt);
            }
            catch (Exception ex)
            {
                MsgBox.ShowWarningDialog("Không import được file");
                Console.WriteLine(ex.Message);

                return null;
            }
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                    dr[0] = Convert.ToString(dr[0]).Replace("&", "");

            return dt;
        }

        public static bool ImportTinhThanhList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[0].Unique = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã tỉnh - thành phố", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã"]).Trim();
                    var ten = Convert.ToString(dr["Tên"]).Trim();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên tỉnh - thành phố không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }
                    var tinhthanh = TinhThanh.FindObject<TinhThanh>("MaTinhThanh", ma);
                    if (tinhthanh == null)
                        tinhthanh = new TinhThanh(XpoDefault.Session);
                    tinhthanh.MaTinhThanh = ma;
                    tinhthanh.TenTinhThanh = ten;
                    tinhthanh.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} tỉnh - thành phố", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowWaitForm(string.Format("Đã import {0}/{1} tỉnh - thành phố!", iCount, dtExcel.Rows.Count));

            return true;
        }
        public static bool ImportHuyenQuanList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[0].Unique = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã huyện - quận", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã"]).Trim();
                    var ten = Convert.ToString(dr["Tên"]).Trim();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên huyện - quận không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }
                    var huyenquan = HuyenQuan.FindObject<HuyenQuan>("MaHuyenQuan", ma);
                    if (huyenquan == null)
                        huyenquan = new HuyenQuan(XpoDefault.Session);

                    huyenquan.MaHuyenQuan = ma;
                    huyenquan.TenHuyenQuan = ten;
                    huyenquan.TinhThanh = TinhThanh.FindObject<TinhThanh>("MaTinhThanh", Convert.ToString(dr["Mã TP"]).Trim());

                    huyenquan.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} huyện - quận", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowWaitForm(string.Format("Đã import {0}/{1} huyện - quận!", iCount, dtExcel.Rows.Count));

            return true;
        }
        public static bool ImportXaPhuongList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[0].Unique = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã xã - phường", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã"]).Trim();
                    var ten = Convert.ToString(dr["Tên"]).Trim();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên xã - phường không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }
                    var xaphuong = XaPhuong.FindObject<XaPhuong>("MaXaPhuong", ma);
                    if (xaphuong == null)
                        xaphuong = new XaPhuong(XpoDefault.Session);

                    xaphuong.MaXaPhuong = ma;
                    xaphuong.TenXaPhuong = ten;
                    xaphuong.HuyenQuan = HuyenQuan.FindObject<HuyenQuan>("MaHuyenQuan", Convert.ToString(dr["Mã QH"]).Trim());

                    xaphuong.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} xã - phường", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowWaitForm(string.Format("Đã import {0}/{1} xã - phường!", iCount, dtExcel.Rows.Count));

            return true;
        }

        public static bool ImportDonViList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[1].Unique = true;       // Column 1 là mã đơn vị
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã đơn vị", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã đơn vị"]).Trim();
                    var ten = Convert.ToString(dr["Đơn vị"]).Trim();
                    string nk = Convert.IsDBNull(dr["Niên khóa"]) ? string.Empty : dr["Niên khóa"].ToString().Trim();

                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên đơn vị không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    if (string.IsNullOrEmpty(nk))
                    {
                        MsgBox.ShowWarningDialog("Niên khóa không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    var donvi = DonVi.FindObject<DonVi>("MaDonVi", ma);
                    if (donvi == null) donvi = new DonVi(XpoDefault.Session);

                    donvi.Stt = Convert.ToInt32(dr["Stt"]);
                    donvi.MaDonVi = ma;
                    donvi.TenDonVi = ten;

                    NienKhoa nienkhoa = NienKhoa.FindObject<NienKhoa>("TenNienKhoa", nk);
                    if(nienkhoa == null)
                    {
                        nienkhoa = new NienKhoa(XpoDefault.Session);
                        nienkhoa.TenNienKhoa = nk;
                        nienkhoa.SuDung = false;
                        nienkhoa.Save();
                    }
                    donvi.NienKhoa = nienkhoa;

                    string td = Convert.IsDBNull(dr["Mã tỉnh/thành phố"]) ? string.Empty : dr["Mã tỉnh/thành phố"].ToString().Trim();
                    TinhThanh tinh = TinhThanh.FindObject<TinhThanh>("MaTinhThanh", td);
                    if (tinh != null) donvi.TinhDoan = tinh;

                    string hd = Convert.IsDBNull(dr["Mã huyện/quận"]) ? string.Empty : dr["Mã huyện/quận"].ToString().Trim();
                    HuyenQuan huyen = HuyenQuan.FindObject<HuyenQuan>("MaHuyenQuan", hd);
                    if (huyen != null) donvi.HuyenDoan = huyen;

                    donvi.GhiChu = Convert.ToString(dr["Ghi chú"]);
                    donvi.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} đơn vị", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowSuccessfulDialog(string.Format("Đã import {0}/{1} đơn vị!", iCount, dtExcel.Rows.Count));

            return true;
        }
        public static bool ImportChiDoanList(string fileName, string sheetName)
        {
            var dtExcel = GetExcelTable(fileName, sheetName);
            if (dtExcel == null) return false;

            try
            {
                dtExcel.Columns[1].Unique = true;       // Column 1 là mã đơn vị
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains non-unique values"))
                    MsgBox.ShowWarningDialog(string.Format("Sheet [{0}] có những dòng trùng mã chi đoàn", sheetName));
                else
                    MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                return false;
            }

            var iCount = 0;

            foreach (DataRow dr in dtExcel.Rows)
            {
                try
                {
                    var ma = Convert.ToString(dr["Mã chi đoàn"]).Trim();
                    var ten = Convert.ToString(dr["Chi đoàn"]).Trim();
                    string madonvi = Convert.IsDBNull(dr["Mã đơn vị"]) ? string.Empty : dr["Mã đơn vị"].ToString().Trim();
                    DonVi donvi = DonVi.FindObject<DonVi>("MaDonVi", madonvi);

                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                    {
                        MsgBox.ShowWarningDialog("Mã hoặc tên chi đoàn không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    if (donvi == null)
                    {
                        MsgBox.ShowWarningDialog("Đơn vị không được rỗng.\nVui lòng kiểm tra dữ liệu trước khi import");
                        return false;
                    }

                    var chidoan = ChiDoan.FindObject<ChiDoan>("MaChiDoan", ma);
                    if (chidoan == null) chidoan = new ChiDoan(XpoDefault.Session);

                    chidoan.Stt = Convert.ToInt32(dr["Stt"]);
                    chidoan.MaChiDoan = ma;
                    chidoan.TenChiDoan = ten;
                    chidoan.DonVi = donvi;
                    chidoan.DienThoai = Convert.ToString(dr["Điện thoại"]).Trim();
                    chidoan.EmailLienHe = Convert.ToString(dr["Email liên hệ"]).Trim();
                    chidoan.GhiChu = Convert.ToString(dr["Ghi chú"]);
                    chidoan.Save();

                    iCount++;

                    MsgBox.ShowWaitForm(string.Format("Đang import {0}/{1} đơn vị", iCount, dtExcel.Rows.Count));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("does not belong to table"))
                    {
                        MsgBox.ShowWarningDialog(string.Format("Sheet excel [{0}] dùng để import không hợp lệ", sheetName));
                        return false;
                    }
                }
            }

            MsgBox.ShowSuccessfulDialog(string.Format("Đã import {0}/{1} chi đoàn!", iCount, dtExcel.Rows.Count));

            return true;
        }
    }
}