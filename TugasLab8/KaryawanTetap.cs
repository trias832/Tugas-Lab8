﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji
        {
           get
            {
                return GajiBulanan;
            }
        }
    }

}


