﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Lpnt.DuLieu
{

    public partial class XaPhuong
    {
        public XaPhuong(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
