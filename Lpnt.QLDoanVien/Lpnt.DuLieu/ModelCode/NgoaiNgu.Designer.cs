﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.DuLieu
{

    public partial class NgoaiNgu : BaseObject
    {
        string fTenNgoaiNgu;
        [DevExpress.Xpo.DisplayName(@"Ngoại ngữ")]
        public string TenNgoaiNgu
        {
            get { return fTenNgoaiNgu; }
            set { SetPropertyValue<string>("TenNgoaiNgu", ref fTenNgoaiNgu, value); }
        }
    }

}