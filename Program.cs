using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhPolAbsCollTugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-234-345";
            karyawanTetap.Nama = "Mamang Kesbor";
            karyawanTetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-254-572";
            karyawanHarian.Nama = "Nanang Cornering";
            karyawanHarian.UpahPerJam = 15000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.Nik = "123-333-347";
            sales.Nama = "Pamungkas";
            sales.JumlahPenjualan = 25;
            sales.Komisi = 50000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
