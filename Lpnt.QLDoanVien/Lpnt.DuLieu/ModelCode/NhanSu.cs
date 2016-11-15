using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.DuLieu
{

    public partial class NhanSu
    {
        public NhanSu(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [DevExpress.Xpo.DisplayName("Mã chi đoàn")]
        public string MaChiDoan
        {
            get
            {
                return ChiDoan.MaChiDoan;
            }
        }

        [DevExpress.Xpo.DisplayName("Họ và tên")]
        public string HoVaTen
        {
            get
            {
                return string.Format("{0} {1}", HoDem, Ten);
            }
        }

        [DevExpress.Xpo.DisplayName("Số tuổi")]
        public int SoTuoi
        {
            get
            {
                return Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(NgaySinh.Year);
            }
        }

        [DevExpress.Xpo.DisplayName("Hộ khẩu thường trú")]
        public string HoKhauThuongTruFull
        {
            get
            {
                return string.Format("{0} - {1} - {2}", HoKhauThuongTru.TenXaPhuong
                                                      , HoKhauThuongTru.HuyenQuan.TenHuyenQuan
                                                      , HoKhauThuongTru.HuyenQuan.TinhThanh.TenTinhThanh);
            }
        }
    }

}
