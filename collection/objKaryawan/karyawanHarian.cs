namespace collection
{
    public class karyawanHarian : karyawan
    {
        public override string nik {get;set;}
        public override string nama {get;set;}
        public double upahPerJam {get;set;}
        public double jumlahJamKerja {get;set;}
        public override double gaji(){
            return upahPerJam * jumlahJamKerja;
        }
    }
}