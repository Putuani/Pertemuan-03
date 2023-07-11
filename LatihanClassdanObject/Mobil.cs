using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    public class Mobil
    {
        public string Warna { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }
        public int JumlahPintu { get; set; }

        public void input()
        {
            Console.WriteLine("Warna : {0} ", this.Warna);
            Console.WriteLine("Merek : {0} ", this.Merek);
            Console.WriteLine("Model: {0} ", this.Model);
            Console.WriteLine("TahunKeluaran: {0} ", this.TahunKeluaran);
            Console.WriteLine("JumlahPintu : {0} ", this.JumlahPintu);

        }

        public void Klaskson()
        {
            Console.WriteLine("Tin..tintin.....tin...tintin....");
        }
        public void Info ()
        {
            Console.WriteLine("Mobil saya berwarna Putih, merek kijang,model nyt, tahun keluaran 2022, dengan jumlah pinta ada empat");
        }
    }
}
