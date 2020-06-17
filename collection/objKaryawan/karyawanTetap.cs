namespace collection
{
    public class karyawanTetap : karyawan
    {
        public override string nik {get;set;}
        public override string nama {get;set;}
        public double gajiBulanan {get;set;}
        public override double gaji(){
            return this.gajiBulanan;
        }
    }
}