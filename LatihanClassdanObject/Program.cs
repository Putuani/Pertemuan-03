using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil= new Mobil();
            
            mobil.Warna = "Putih";
            mobil.Merek = "Kijang";
            mobil.Model = "nyt";
            mobil.TahunKeluaran = 2022;
            mobil.JumlahPintu = 4;

            mobil.input();
            mobil.Klaskson();
            mobil.Info();

            Console.ReadKey();

;
        }
    }
}
