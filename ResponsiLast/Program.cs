using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace responsilast
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        EditPenjualan();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi!\n\n");
            Console.WriteLine("1.Tambah Penjualan\n");
            Console.WriteLine("2.Hapus Penjualan\n");
            Console.WriteLine("3.Tampilkan Penjualan\n");
            Console.WriteLine("4.Edit Data Penjualan\n");
            Console.WriteLine("5.exit");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            Console.WriteLine("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.WriteLine("Customer: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Jenis (T/K):");
            string jenis = Console.ReadLine();
            if(jenis=="t" || jenis =="T"){
                jenis="Tunai";
            }
            else if(jenis=="K" || jenis =="k"){
                jenis="kredit";
            }
            Console.WriteLine("Total Nota: ");
            int total = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan(nota, tanggal, nama, jenis, total));
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
            
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Penjualan !\n");
            string nota = Console.ReadLine();
            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                Penjualan penjualan = daftarPenjualan[i];
                if (penjualan.nota == nota)
                {
                    daftarPenjualan.RemoveAt(i);
                    Console.WriteLine("Data atas nama " + penjualan.nama + " dengan id " + penjualan.nota + " berhasil Dihapus!\n");
                }
                else{
                    Console.WriteLine("Data Tidak Ditemukan !\n");
                }
            }
            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Data Penjualan !\n\n");
            foreach (Penjualan penjualan in daftarPenjualan){
                
                Console.WriteLine(counter + ". " + penjualan.nota +", " + penjualan.tanggal +", " + penjualan.nama +", " + penjualan.jenis +", " +penjualan.total );
                counter++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
        static void EditPenjualan(){
            Console.Clear();
            Console.WriteLine("Edit Data penjualan!\n\n");
            Console.WriteLine("Masukkan Nota :");
            string nota = Console.ReadLine();
            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                Penjualan penjualan = daftarPenjualan[i];
                if (penjualan.nota == nota)
                {
                    Console.WriteLine("Nota: ");
                    string notas = Console.ReadLine();
                    Console.WriteLine("Tanggal: ");
                    string tanggal = Console.ReadLine();
                    Console.WriteLine("Customer: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Jenis (T/K):");
                    string jenis = Console.ReadLine();
                    if(jenis=="t" || jenis =="T"){
                        jenis="Tunai";
                    }
                    else if(jenis=="K" || jenis =="k"){
                        jenis="kredit";
                    }
                    Console.WriteLine("Total Nota: ");
                    int total = Convert.ToInt32(Console.ReadLine());
                    daftarPenjualan[i].nota=notas;
                    daftarPenjualan[i].tanggal=tanggal;
                    daftarPenjualan[i].nama=nama;
                    daftarPenjualan[i].jenis=jenis;
                    daftarPenjualan[i].total=total;
                    Console.WriteLine("Data Berhasil Diubah!\n");
                }
                else{
                    Console.WriteLine("Data Tidak Ditemukan !\n");
                }
            }
        }
    }
}
