using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InhPolAbsCollTugas8
{
    class KaryawanHarian : Karyawan
    {
        public int JumlahJamKerja { get; set; }
        public int UpahPerJam { get; set; }
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
