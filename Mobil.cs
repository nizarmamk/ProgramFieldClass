using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAndObject
{
    internal class Mobil
    {
        // fields
        private string _nama = "...";
        private string _warna = "...";
        private int _jmlpintu;
        private string _merek = "...";
        private string _model = "...";
        private int _tahun;
        
        // properties
        public string Nama
        {
            get
            {
                return _nama;
            }
            set
            {
                _nama = value;
            }
        }
        public string Warna
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public int Jmlpintu
        {
            get
            {
                return _jmlpintu;
            }
            set
            {
                _jmlpintu = value;
            }
        }
        public string Merek
        {
            get
            {
                return _merek;
            }
            set
            {
                _merek = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Tahun
        {
            get
            {
                return _tahun;
            }
            set
            {
                _tahun = value;
            }
        }


        // method
        public void Gas(int kecepatan)
        {
            Console.Write("Mobil {0} {1} berjalan dengan kecepatan {2} km/jam ", Merek, Model, kecepatan);
        }
        
        public void Klakson(string suara)
        {
            Console.Write("dan memiliki suara klakson {0}.", suara);
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("\nMobil {0} berwarna {1}, merek {2} model {3} keluaran tahun {4} dengan jumlah pintu sebanyak {5}.\n", Nama, Warna, Merek, Model, Tahun, Jmlpintu);
        }

    }
}
