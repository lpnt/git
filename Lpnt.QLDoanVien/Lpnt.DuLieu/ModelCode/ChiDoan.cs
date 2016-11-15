using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.DuLieu
{

    public partial class ChiDoan
    {
        public ChiDoan(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "MaChiDoan":
                    if (string.IsNullOrEmpty(MaChiDoan))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã chi đoàn không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, MaChiDoan))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Mã chi đoàn không được trùng";
                    }
                    break;

                case "TenChiDoan":
                    if (string.IsNullOrEmpty(TenChiDoan))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên chi đoàn không được trống";
                    }
                    break;

                case "DonVi!Key":
                    if (DonVi == null)
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Đơn vị không được trống";
                    }
                    break;
            }
        }

        [DevExpress.Xpo.DisplayName("Số lượng nhân sự")]
        public int SoLuongNhanSu
        {
            get
            {
                return NhanSus.Count;
            }
        }
    }

}
