﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet_Data.Model.Entitis
{
    public class GioHangChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdSP { get; set; }
        public virtual SanPham SanPhams { get; set; }
        public Guid IdGH { get; set; }
        public virtual GioHang GioHangs { get; set; }


    }
}
