using System;

namespace abstract_class
{
    public abstract class universitas{
        public abstract string rektor {get;}
        public abstract string metode_kuliah {get;}
        public abstract void kuliah();
    }
    public class amikom : universitas {
        public override string rektor {get{return "pak yanto";}}
        public override string metode_kuliah {get{return "online";}}
        public override void kuliah(){
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
