using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_9
{
    abstract class Proses
    {
        public abstract void Tambah_Data(string id, string nama, string jabatan);
    }

    class DataKaryawan : Proses
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Jabatan { set; get; }
        public override void Tambah_Data(string id, string nama, string jabatan)
        {
            ID = id;
            Name = nama;
            Jabatan = jabatan;
        }

    }

    class proccess
    {
        List<DataKaryawan> Listing = new List<DataKaryawan>();
        public void Tambah(string id, string nama, string jabatan)
        {
            DataKaryawan data = new DataKaryawan();
            data.Tambah_Data(id, nama, jabatan);
            Listing.Add(data);
        }
        public void Edit(string id)
        {
            string pilihan, temp;
            for (int i = 0; i < Listing.Count; i++)
            {
                DataKaryawan data = Listing[i];
                if (data.ID == id)
                {
                back:
                    Console.WriteLine("1.ID = {0}\n2.nama = {1}\n3.jabatan = {2}", data.ID, data.Name, data.Jabatan);
                    Console.Write("pilihan [y untuk menyelesaikan] : ");
                    pilihan = Console.ReadLine();
                    if (pilihan == "1")
                    {
                        Console.Write("perubahan [ID]: ");
                        temp = Console.ReadLine();
                        data.ID = temp;
                        goto back;
                    }
                    else if (pilihan == "2")
                    {
                        Console.Write("perubahan [Nama] : ");
                        temp = Console.ReadLine();
                        data.Name = temp;
                        goto back;
                    }
                    else if (pilihan == "3")
                    {
                        Console.Write("perubahan [jabatan]: ");
                        temp = Console.ReadLine();
                        data.Jabatan = temp;
                        goto back;
                    }
                    else if (pilihan == "y")
                    {
                        return;
                    }
                    else
                    {
                        goto back;
                    }
                }
            }
        }
        public void Hapus(string id)
        {
            for (int i = 0; i < Listing.Count; i++)
            {
                DataKaryawan data = Listing[i];
                if (data.ID == id)
                {
                    Listing.RemoveAt(i);
                    return;
                }
            }
        }
        public void tampil()
        {
            string temp;
            for(int i = 0; i < Listing.Count; i++)
            {
                DataKaryawan data = Listing[i];
                Console.WriteLine("ID : {0}", data.ID);
            }
            Console.Write("tampil data [dengan id] : ");
            temp = Console.ReadLine();
            Console.WriteLine();
            for(int i = 0; i < Listing.Count; i++)
            {
                DataKaryawan data = Listing[i];
                if(data.ID == temp)
                {
                    Console.WriteLine("id : {0}\nnama : {1}\njabatan : {2}", data.ID, data.Name, data.Jabatan);
                    Console.ReadKey();
                    Console.WriteLine();
                    return;
                }
            }
        }
    }
}