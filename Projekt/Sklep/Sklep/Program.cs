using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Sklep
{
    public class Program 
    {
        

        public static void Main(String[] args)
        {
            Cart cart = new Cart();
            Product kurtka = new Product("Kurtka", 100, "XL");
            Product spodnie = new Product("Spodnie", 70, "S");
            Product buty = new Product("Buty", 90, "L");
            NaukaDatabase ndb = new NaukaDatabase();

            Console.WriteLine("Co chcesz kupić?: \n");
            Console.WriteLine("1.Kurtka, 100zł");
            Console.WriteLine("2.Spodnie, 70zł");
            Console.WriteLine("3.Buty, 90zł\n");
            Console.WriteLine("4.Podlizcz koszyk\n");
            Console.WriteLine("5.Wyjście");
            Console.WriteLine("6.Opcje na bazie danych");

            int choose = 0;
            do
            {

                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException )
                {
                    Console.WriteLine("Proszę podać liczbę od 1 do 5!");
                }
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Kupiłeś Kurtkę!");
                        cart.Add(kurtka);
                        choose = 0;
                        break;
                    case 2:
                        Console.WriteLine("Kupiłeś Spodnie!");
                        cart.Add(spodnie);
                        choose = 0;
                        break;
                    case 3:
                        Console.WriteLine("Kupiłeś Buty!");
                        cart.Add(buty);
                        choose = 0;
                        break;
                    case 4:
                        Console.WriteLine(cart.SumUp());
                        choose =0;
                        break;
                    case 6:
                            Console.WriteLine("1.Dodaj rekord");
                            Console.WriteLine("2.Uaktualnij rekord");
                            Console.WriteLine("3.Usun rekord");
                            Console.WriteLine("4.Wyjdz");
                            int choose2 = 0;
                        do
                        {
                            try
                            {
                                choose2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch(System.FormatException )
                            {
                                Console.WriteLine("Proszę podać liczbę od 1 do 5!");
                            }
                            switch(choose2)
                            {
                                case 1:
                                    ndb.Insert();
                                    break;
                                case 2:
                                    ndb.Update();
                                    break;
                                case 3:
                                    ndb.Delete();
                                    break;
                            }

                            
                        } while (choose2 != 4);

                        break;
                }
            } while (choose !=5);

        }

    }
}
