using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama\t : Trias Handayami\nNIM\t : 19.11.2733\nKelas\t : 19-IF-03");
            Console.WriteLine("===========================================================================");
            Console.WriteLine();

            //membuat objek untuk karyawan tetap
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-234-345";
            karyawanTetap.Nama = "Michael Suyama";
            karyawanTetap.GajiBulanan = 4000000;

            //membuat objek untuk karyawan harian
            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-321-346";
            karyawanHarian.Nama = "Laura Callahan";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 13000;

            //membuat objek untuk Sales
            Sales sales = new Sales();
            sales.Nik = "123-333-347";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            //objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();
            
            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            
            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} \tNama: {2} \tGaji: {3:N0}",
                noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji);
                noUrut++;
            }
                Console.ReadKey();

            }
        }
    }

