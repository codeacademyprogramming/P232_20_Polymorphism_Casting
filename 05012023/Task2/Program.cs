using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nt1 = new Notebook { Name = "Acer 1", Price = 1200, RAM = 2, Storage = 500 };
            var nt2 = new Notebook { Name = "Acer 2", Price = 1400, RAM = 2, Storage = 500 };
            var nt3 = new Notebook { Name = "Acer 3", Price = 1600, RAM = 2, Storage = 500 };
            var ph1 = new Phone { Name = "Iphone 1", Price = 500, Camera = 4, SimCount = 1 };
            var ph2 = new Phone { Name = "Iphone 11", Price = 1500, Camera = 14, SimCount = 1 };
            var ph3 = new Phone { Name = "Iphone 12", Price = 2500, Camera = 4, SimCount = 1 };
            var ph4 = new Phone { Name = "Iphone 13", Price = 3500, Camera = 4, SimCount = 1 };

            Product[] products = { nt1, ph1, nt2, ph2, nt3, ph3, ph4 };

            


            string opt;
            do
            {
                Console.WriteLine("\n=================== Menu =====================\n");

                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax bax");
                Console.WriteLine("5. Telefonlarin sayina bax bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n=================== Products =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }

                        break;
                    case "2":
                        Console.WriteLine("\n=================== Notebooks =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if(products[i] is Notebook)
                            {

                                var nt = products[i] as Notebook;
                                Console.WriteLine(nt.Name + " - " + nt.Price+" "+nt.RAM);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n=================== Phones =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if(products[i] is Phone)
                                Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }

                        break;
                    case "4":
                        int notebookCount = 0;
                        Console.WriteLine("\n=================== Notebook count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                notebookCount++;
                        }

                        Console.WriteLine("Notebook sayi: "+notebookCount);
                        break;
                    case "5":
                        int phoneCount = 0;
                        Console.WriteLine("\n=================== Phone count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                phoneCount++;
                        }

                        Console.WriteLine("Phone sayi: " + phoneCount);
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi!");
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin!");
                        break;
                }

            } while (opt != "0");








        }
    }
}
