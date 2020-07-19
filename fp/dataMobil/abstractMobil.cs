namespace fp
{
    public abstract class abstractMobil
    {
        public abstract string merk{get;set;}
        public abstract string warna{get;set;}
        public abstract int tahun{get;set;}
        public abstract int harga{get;set;}
        public abstract void statusRental();
    }
}