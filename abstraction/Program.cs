using System;

namespace abstraction
{
    public class kuliah
    {
        public string dosen
        {
            get;set;
        }
        public string matkul
        {
            get;set;
        }
        public string nilai
        {
            //nilai abstraksi
            get;set;
        }

        public void pengumuman()
        {
            Console.WriteLine("Anda Akan Diampu Oleh Dosen " + dosen + " dalam mata kuliah " + matkul);
        }
        public void gagal()
        {
            //fungsi abstraksi
            Console.WriteLine("Maaf Anda Gagal Pada Matkul Ini");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraksi Kuliah");
            kuliah pemograman = new kuliah();

            //input ini hanya berdasar parameter info, tanpa diketahui oleh pengguna class bahwa di class kuliah terdapat str nilai dan func gagal()
            pemograman.dosen = "pak Kamarudin";
            pemograman.matkul = "pemograman";
            pemograman.pengumuman();
        }
    }
}
