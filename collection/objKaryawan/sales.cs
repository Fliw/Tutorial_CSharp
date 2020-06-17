namespace collection
{
    public class sales : karyawan
    {
        public override string nik {get;set;}
        public override string nama{get;set;}
        public double jumlahPenjualan{get;set;}
        public double komisi{get;set;}
        public override double gaji(){
            return (jumlahPenjualan * komisi);
        }
    }
}