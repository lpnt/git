using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Lpnt.DuLieu
{

    public partial class NienKhoa
    {
        public NienKhoa(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            fSuDung = false;
        }
        public override void GetPropertyError(string propertyName, ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            switch (propertyName)
            {
                case "TenNienKhoa":
                    if (string.IsNullOrEmpty(TenNienKhoa))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên không được trống";
                    }
                    else if (Exists(Session, ClassInfo, propertyName, TenNienKhoa))
                    {
                        info.ErrorType = ErrorType.Critical;
                        info.ErrorText = "Tên không được trùng";
                    }
                    break;
            }
        }
        public static void KhoiTao()
        {
            NienKhoa obj = new NienKhoa(XpoDefault.Session);
            obj.TenNienKhoa = "2016-2017";
            obj.SuDung = true;
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session);
            obj.TenNienKhoa = "2017-2018";
            obj.SuDung = false;
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session);
            obj.TenNienKhoa = "2018-2019";
            obj.SuDung = false;
            obj.Save();

            obj = new NienKhoa(XpoDefault.Session);
            obj.TenNienKhoa = "2019-2020";
            obj.SuDung = false;
            obj.Save();
        }
    }

}
