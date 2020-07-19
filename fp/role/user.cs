// namespace fp
// {
//     public class user
//     {
//         public user()
//         {
//             Console.Clear();
//             Console.WriteLine("\nWelcome To USER Panel!");
//             Thread.Sleep(1000);
//             Console.Clear();
//             int pil = 0;
//             do
//             {
//                 Console.WriteLine("Main Menu\n");
//                 Console.WriteLine("1.Manajemen Mobil");
//                 Console.WriteLine("2.Manajemen Users");
//                 Console.WriteLine("3.Manajemen Rental");
//                 Console.WriteLine("4.Exit\n");
//                 Console.WriteLine("Pilihan Anda:");
//                 pil = Convert.ToInt32(Console.ReadLine());
//                 switch (pil)
//                 {
//                     case 1:
//                         //redirect to manajemen mobil page
//                         manajemenMobil manajemenMobils = new manajemenMobil();
//                         break;
//                     case 2:
//                         //redirect to manajemen user page
//                         // manajemenUser manajemenUsers = new manajemenUser();
//                         break;
//                     case 3:
//                         //redirect to manajemen rental page
//                         // manajemenRental manajemenRentals = new manajemenRental();
//                         break;
//                     case 4:
//                         Console.Clear();
//                         break;
//                     default:
//                         Console.Clear();
//                         Console.WriteLine("Pilihan Anda Salah!");
//                         Thread.Sleep(1000);
//                         adminPanel();
//                         break;
//                 }
//             } while (pil != 4);
//         }
//     }
// }