using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_9
{
    class Program
    {
        static void Main(string[] args)
        {
            proccess proses = new proccess();
            string pilihan, id, nama, jabatan, temp;
            do
            {
                Console.WriteLine("Data karyawan\n1.Tambah Data\n2.Edit Data\n3.Hapus Data\n4.tampil\n5.keluar");
                Console.Write("pilihan : ");
                pilihan = Console.ReadLine();
                switch (pilihan)
                {
                    case "1":
                        Console.Write("ID : ");
                        id = Console.ReadLine();
                        Console.Write("nama : ");
                        nama = Console.ReadLine();
                        Console.Write("jabatan : ");
                        jabatan = Console.ReadLine();
                        proses.Tambah(id, nama, jabatan);
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("id yg ingin dirubah : ");
                        temp = Console.ReadLine();
                        proses.Edit(temp);
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Write("id yang ingin dihapus : ");
                        temp = Console.ReadLine();
                        proses.Hapus(temp);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        proses.tampil();
                        break;
                    case "5":
                        break;
                }
            } while (pilihan != "5");
        }
    }
}