using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new ProjectClassAndObject.Mobil
            {
                Nama = "saya",
                Warna = "Hitam",
                Merek = "Porsche",
                Model = "911 GT3",
                Tahun = 2022,
                Jmlpintu = 2
            };

            Mobil mobil2 = new ProjectClassAndObject.Mobil
            {
                Nama = "teman saya",
                Warna = "Kuning",
                Merek = "Chevrolet",
                Model = "Camaro",
                Tahun = 2023,
                Jmlpintu = 2
            };

            mobil1.Gas(90);
            mobil1.Klakson("tin tin");
            mobil1.TampilkanInfo();

            mobil2.Gas(80);
            mobil2.Klakson("tet tet");
            mobil2.TampilkanInfo();

            Console.WriteLine("Tekan enter untuk keluar . . .");
            Console.ReadKey();
        }
    }
}
