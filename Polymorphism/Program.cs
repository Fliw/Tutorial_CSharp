using System;

namespace Polymorphism
{   
    //adding new base class to be inherited
    public class PrinterWindows
    {
        //declaring some field props
        public string Name = "Printer Windows";
        public string Dimension = "9x10";
        //declaring some method that takes the props
        //virtual keyword here means the method in Base Class CAN be overrided by another method in Inherited Class
        public virtual void show(){
            Console.WriteLine(Name+" Display Dimension : "+Dimension);
        }
        public virtual void print(){
            Console.WriteLine(Name+" Printer Printing...");
        }
    }
    //adding new class inherintance from base class
    public class Epson : PrinterWindows
    {
        //overriding show() method in base class
        public override void show(){
            Console.WriteLine("Epson Display Dimension : 10x11");
        }
        public override void print(){
            Console.WriteLine("Epson Printer Printing...");
        }
    }
    //adding new class inherintance from base class
    public class Canon : PrinterWindows
    {
        //overriding show() method in base class
        public override void show(){
            Console.WriteLine("Canon Display Dimension : 11x12");
        }
        public override void print(){
            Console.WriteLine("Canon Printer Printing...");
        }
    }
    //just like other else.
    public class Laserjet : PrinterWindows
    {
        public override void show(){
            Console.WriteLine("LaserJet Display Dimension : 12x12");
        }
        public override void print(){
            Console.WriteLine("LaserJet Printer Printing...");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //declaring the object printer that takes blueprint from PrinterWindows class
            PrinterWindows printer = new PrinterWindows();
            Console.WriteLine("Pilihlah Printer :\n");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet\n");
            Console.WriteLine("Pilih Nomor Printer = ");
            //inputting integer for branching
            int Pilihan = Convert.ToInt32(Console.ReadLine());
            //all branching for suitable condition
            if(Pilihan==1){
                printer=new Epson();
            }
            else if(Pilihan==2){
                printer=new Canon();
            }
            else if(Pilihan==3){
                printer=new Laserjet();
            }
            else{
                Console.WriteLine("Maaf, Opsi Tersebut Belum Tersedia :( Pakai Default Aja Ya :(");
            }
            //call all the method
            printer.show();
            printer.print();
            Console.ReadKey();
        }
    }
}
