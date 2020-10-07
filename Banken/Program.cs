using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Kund> KundLista = new List<Kund>();

        static void Main(string[] args)
        {
            int choise = 0;
            while (choise !=7)
            {


                choise = GetChoiseFromUser();
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Du valde att lägga in en ny kund");

                        AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("Du valde att ta bort en kund");
                        RemoveCustomer();
                        break;
                    case 3:
                        Console.WriteLine("Du valde att se alla befintliga kunder");
                        Showcustomers();
                        break;
                    case 4:
                        Console.WriteLine("Du valde att se en kunds saldo");
                        ShowBalance();
                        break;
                    case 5:
                        Console.WriteLine("Du valde att göra en insättning för en kund");
                        AddBalance();
                        break;
                    case 6:
                        Console.WriteLine("Du valde att göra ett utag från en kund");
                        RemoveBalance();
                        break;
                    case 7:
                        Console.WriteLine("Du valde att avsluta programmet. Klicka enter för att avsluta");
                        Console.WriteLine("Ha en bra dag!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Du gjorde ett felaktigt val");
                        break;
                }
            }




        }

        private static void RemoveBalance()
        {
            
        }

        private static void AddBalance()
        {
            Showcustomers();
            Console.Write("vilken kund (ange siffran) vill du göra en insättning för?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            Console.Write("Hur mycket pengar vill du lägga in?: ");
            string strMoney = Console.ReadLine();
            int money = int.Parse(strMoney);
            KundLista[choise].Saldo += money;

        }

        private static void ShowBalance()
        {
            throw new NotImplementedException();
        }

        private static void Showcustomers()
        {
            for (int i = 0; i < KundLista.Count; i++)
            {
                Console.WriteLine(i+" "+KundLista[i].Visakund());
            }
        }

        private static int GetChoiseFromUser()
        {



                Console.WriteLine("1.Ny användare");
                Console.WriteLine("2.Ta bort användare");
                Console.WriteLine("3. Visa alla befintliga användare");
                Console.WriteLine("4.Visa saldo för en användare");
                Console.WriteLine("5.Gör en insättning för en användare");
                Console.WriteLine("6.Gör ett uttag för en användare");
                Console.WriteLine("7.Avsluta programmet");
                Console.Write("Skriv ditt val: ");
                string strChoise = Console.ReadLine();
                int choise = int.Parse(strChoise);
                return choise;

            
        }

        private static void RemoveCustomer()
        {
            Showcustomers();
            Console.Write("vilken kund (ange siffran) vill du ta bort?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            KundLista.RemoveAt(choise);

        }

        private static void AddCustomer()
        {
            
            Kund kund1  = new Kund();
            Console.Write("vänligen ange kundens namn: ");
            kund1.Namn = Console.ReadLine();
            KundLista.Add(kund1);
            
            

        }

    }
}
