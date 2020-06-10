using System;

namespace interfaces
{
    public interface universitas{
        string rektor {get;}
        string metode_kuliah {get;}
        void kuliah();
    }
    public class amikom : universitas {
        public string rektor {get{return "pak yanto";}}
        public string metode_kuliah {get{return "online";}}
        public  void kuliah(){
            Console.WriteLine("Halo Gaes, Welkom Back To Amikom, Kampus Ungu Kebanggaan Kita, dengan rektor " + this.rektor + " serta metode kuliah " + metode_kuliah);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            universitas Kampus_ungu = new amikom();
            Kampus_ungu.kuliah();
        }
    }
}
