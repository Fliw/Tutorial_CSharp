using System;

namespace Interface
{
    //creating new interface
    public interface Iprinter
    {
        //adding 2 abstract method
        void Show();
        void Print();
    }
    //Adding Implements
    public class Epson : Iprinter
    {
        //overriding the abstract method to specified method
        public void Show(){
            Console.WriteLine("Epson Display Dimension = 10x11");
        }
        public void Print(){
            Console.WriteLine("Epson Printer Printing...");
        }
    }
    public class Canon : Iprinter
    {
        //overriding the abstract method to specified method
        public void Show(){
            Console.WriteLine("Canon Display Dimension = 11x10");
        }
        public void Print(){
            Console.WriteLine("Canon Printer Printing...");
        }
    }
    public class LaserJet : Iprinter
    {
        //overriding the abstract method to specified method
        public void Show(){
            Console.WriteLine("LaserJet Display Dimension = 9x10");
        }
        public void Print(){
            Console.WriteLine("LaserJet Printer Printing...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //declare a variable of instance interface Printer
            Iprinter newInterfacePrinter = null;
            Console.WriteLine("Pilihlah Printer :\n");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet\n");
            Console.WriteLine("Pilih Nomor Printer = ");
            int Pilihan = Convert.ToInt32(Console.ReadLine());
            if(Pilihan==1){
                newInterfacePrinter = new Epson();
            }
            else if(Pilihan==2){
                newInterfacePrinter = new Canon();
            }
            else if(Pilihan==3){
                newInterfacePrinter = new LaserJet();
            }
            else{
                Console.WriteLine("Maaf, Opsi Tersebut Belum Tersedia :( Pakai Default Aja Ya :(");
            }
            newInterfacePrinter.Show();
            newInterfacePrinter.Print();
            Console.ReadKey();
        }
    }
}
