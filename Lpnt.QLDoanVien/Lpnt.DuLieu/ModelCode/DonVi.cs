using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.DuLieu
{

    public partial class DonVi
    {
        public DonVi(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "MaDonVi":
                    if (string.IsNullOrEmpty(MaDonVi))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã đơn vị không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, MaDonVi))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã đơn vị không được trùng";
                    }
                    break;

                case "TenDonVi":
                    if (string.IsNullOrEmpty(TenDonVi))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên đơn vị không được trống";
                    }
                    break;

                case "NienKhoa!Key":
                    if (NienKhoa == null)
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Niên khóa không được trống";
                    }
                    break;
            }
        }

        [DevExpress.Xpo.DisplayName("Số lượng chi đoàn")]
        public int SoLuongChiDoan
        {
            get
            {
                return ChiDoans.Count;
            }
        }
    }

}
