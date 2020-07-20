using System;
using System.Collections.Generic;
using System.Threading;

namespace fp
{
    class user
    {
        public string username { get; set; }
        public string password { get; set; }
        //create a constructor that get an input and set this class's username & input
        public user()
        {
            Console.Clear();
            Console.WriteLine("Login as user:");
            Console.WriteLine("username:");
            this.username = Console.ReadLine();
            Console.WriteLine("password:");
            do
            {
                //method for replace every char in string with asterisk
                ConsoleKeyInfo kunci = Console.ReadKey(true);
                if (kunci.Key != ConsoleKey.Backspace && kunci.Key != ConsoleKey.Enter)
                {
                    this.password += kunci.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (kunci.Key == ConsoleKey.Backspace && this.password.Length > 0)
                    {
                        this.password = this.password.Substring(0, (this.password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (kunci.Key == ConsoleKey.Enter)
                    {

                        break;
                    }
                }
            } while (true);
            if (this.username == "rafif" && this.password == "rafif123")
            {
                UserDashboard();
            }
            else if (this.username == "rafif" && this.password != "rafif123")
            {
                Console.Clear();
                Console.WriteLine("Username Atau Password anda Salah!");
                return;
            }
            else
            {
                Console.WriteLine("Kredensial tidak ditemukan!");
                Console.Clear();
                return;
            }
        }

        public void UserDashboard()
        {
            Console.Clear();
            Console.WriteLine("\nWelcome To User Dashboard");
            Thread.Sleep(1000);
            Console.Clear();
            int pil = 0;
            do
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("1. Sewa Mobil");
                Console.WriteLine("2. Mengembalikan mobil");
                Console.WriteLine("3.Exit\n");
                Console.WriteLine("Pilihan Anda:");
                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Console.Clear();
                        //Sewa Mobil
                        Console.WriteLine("Main Menu\n");
                        Console.WriteLine("1. Sedan");
                        Console.WriteLine("2. SUV");
                        Console.WriteLine("Pilihan Anda:");
                        pil = Convert.ToInt32(Console.ReadLine());
                        if (pil == 1)
                        {
                            Console.Clear();
                            int counterSedan = 0;
                            foreach (sedan mobil in manajemenMobil.listSedan)
                            {
                                if (mobil.statusRentals == "belum")
                                {
                                    counterSedan++;
                                    Console.WriteLine((counterSedan) + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");

                                }

                            }

                            if (counterSedan > 0)
                            {
                                Console.Write("Pilih mobil: ");
                                int pilihanMobil = Convert.ToInt32(Console.ReadLine());
                                manajemenMobil.listSedan[pilihanMobil - 1].statusRentals = "sudah";
                                Console.WriteLine("Anda berhasil meminjam mobil sedan merk " + manajemenMobil.listSedan[pilihanMobil - 1].merk + " dengan harga rental per jam:" + manajemenMobil.listSedan[pilihanMobil - 1].harga);
                            }
                            else
                            {
                                Console.WriteLine("Mobil kosong!");
                            }

                            Console.WriteLine("Enter untuk kembali");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (pil == 2)
                        {
                            Console.Clear();
                            int counterSuv = 0;
                            foreach (suv mobil in manajemenMobil.listSuv)
                            {
                                if (mobil.statusRentals == "belum")
                                {
                                    counterSuv++;
                                    Console.WriteLine((counterSuv + 1) + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");

                                }

                            }

                            if (counterSuv > 0)
                            {
                                Console.Write("Pilih mobil: ");
                                int pilihanMobil = Convert.ToInt32(Console.ReadLine());
                                manajemenMobil.listSuv[pilihanMobil - 1].statusRentals = "sudah";
                                Console.WriteLine("Anda berhasil meminjam mobil sedan merk" + manajemenMobil.listSuv[pilihanMobil - 1].merk + "dengan harga rental per jam:" + manajemenMobil.listSuv[pilihanMobil - 1].harga);
                            }
                            else
                            {
                                Console.WriteLine("Mobil kosong!");
                            }

                            Console.WriteLine("Enter untuk kembali");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        //Mengembalikan mobil
                        Console.WriteLine("Menu Mengembalikan mobil");


                        Console.WriteLine("Pilih jenis mobil yang ingin anda kembalikan\n");
                        Console.WriteLine("1. Sedan");
                        Console.WriteLine("2. SUV");
                        Console.WriteLine("Pilihan Anda:");
                        pil = Convert.ToInt32(Console.ReadLine());
                        if (pil == 1)
                        {
                            Console.Clear();
                            int counterSedan = 0;
                            foreach (sedan mobil in manajemenMobil.listSedan)
                            {
                                if (mobil.statusRentals == "sudah")
                                {
                                    counterSedan++;
                                    Console.WriteLine((counterSedan) + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");

                                }

                            }

                            if (counterSedan > 0)
                            {
                                Console.Write("Pilih mobil: ");
                                int pilihanMobil = Convert.ToInt32(Console.ReadLine());
                                manajemenMobil.listSedan[pilihanMobil - 1].statusRentals = "belum";
                                Console.Write("Masukkan jangka waktu pinjam(hari): ");
                                int hari = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Harga sewa yang harus anda bayar: Rp. " + hari * manajemenMobil.listSedan[pilihanMobil - 1].harga);
                                Console.WriteLine("Anda berhasil mengembalikan mobil sedan merk " + manajemenMobil.listSedan[pilihanMobil - 1].merk + " dengan harga rental per jam: Rp." + manajemenMobil.listSedan[pilihanMobil - 1].harga);
                            }
                            else
                            {
                                Console.WriteLine("Mobil kosong!");
                            }

                            Console.WriteLine("Enter untuk kembali");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (pil == 2)
                        {
                            Console.Clear();
                            int counterSuv = 0;
                            foreach (suv mobil in manajemenMobil.listSuv)
                            {
                                if (mobil.statusRentals == "sudah")
                                {
                                    counterSuv++;
                                    Console.WriteLine((counterSuv + 1) + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");

                                }

                            }

                            if (counterSuv > 0)
                            {
                                Console.Write("Pilih mobil: ");
                                int pilihanMobil = Convert.ToInt32(Console.ReadLine());
                                manajemenMobil.listSuv[pilihanMobil - 1].statusRentals = "belum";
                                Console.Write("Masukkan jangka waktu pinjam(hari): ");
                                int hari = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Harga sewa yang harus anda bayar: Rp. " + hari * manajemenMobil.listSuv[pilihanMobil - 1].harga);
                                Console.WriteLine("Anda berhasil mengembalikan mobil sedan merk" + manajemenMobil.listSuv[pilihanMobil - 1].merk + "dengan harga rental per jam:" + manajemenMobil.listSuv[pilihanMobil - 1].harga);
                            }
                            else
                            {
                                Console.WriteLine("Mobil kosong!");
                            }

                            Console.WriteLine("Enter untuk kembali");
                            Console.ReadKey();
                            Console.Clear();
                        }


                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        Thread.Sleep(1000);
                        UserDashboard();
                        break;
                }
            } while (pil != 3);
        }
    }
}
