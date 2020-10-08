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
        static List<Customer> customerList = new List<Customer>();

        static void Main(string[] args)
        {
            // choise är 0 så när choise inte är större eller lika med 7 så stängs programmet.
            int choise = 0;
            while (choise !=7)
            {
                // Här så kommer användaren få välja vad den vill göra för något t.ex. lägga till en ny kund
                // så kommer programmet skicka användaren vidare till nästa fråga.
                // men om användaren svara konstigt så inte programmet förstår kommer den säga felaktigt svar
                // då får användaren försjöka igen.
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
            // här så skriver programmet ut alla kunder som har blivit skapade av användaren och frågar vilken
            // användare man vill ta ut pengar ifrån. Så när användaren anget vilken kund den vill ta ut pengar ifrån
            // så frågar programmet hur mycket pengar användaren vill ta ut.
            // Sedan så ta programmet bort pengarna från Saldo 
            Showcustomers();
            Console.Write("vilken kund (ange siffran) vill du göra ett uttag ifrån?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            Console.Write("Hur mycket pengar vill du ta ut?: ");
            string strGetMoney = Console.ReadLine();
            int getMoney = int.Parse(strGetMoney);
            customerList[choise].Balance -= getMoney;
        }

        private static void AddBalance()
        {
            // Det börjar med att programmet skriver ut alla kunder i en lista. Sen måste användaren välja vilken kund
            // efter de så frågas användaren hur mycket pengar den vill lägga in på kunden den valt.
            // Efter så plusar programmet på pengarna som användaren angav som sparas i variabeln money.
            // så då plusar programmet på money och saldo så de sparas på kunden.
            Showcustomers();
            Console.Write("vilken kund (ange siffran) vill du göra en insättning för?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            Console.Write("Hur mycket pengar vill du lägga in?: ");
            string strMoney = Console.ReadLine();
            int money = int.Parse(strMoney);
            customerList[choise].Balance += money;
        }

        private static void ShowBalance()
        {
            // Här så kan användaren välja viken kund den vill se hur mycket pengar den har.
            // Så de börjar med att användaren får en fårga vilken kunde den vill titta på
            // sen så går programmet till den kunden och skriver ut hur mycket pengar den har.
            Showcustomers();
            Console.Write("Vilken kund (ange siffran) vill du se kontouppgifterna på?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            Console.WriteLine(customerList[choise].Balance);
        }

        private static void Showcustomers()
        {
            // Här så visas alla kunder som laggts till i programmet av användaren.
            for (int i = 0; i < customerList.Count; i++)
            {
                Console.WriteLine(i+" "+customerList[i].ShowCustomer());
            }
        }

        private static int GetChoiseFromUser()
        {
            //här så frågar programmet vad användaren vill göra för val om den vill göra en ny användare eller ta ut
            // pengar mm. Sen när användaren har svarat vad den vill så retuneras svaret i variabeln choise.
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
            //här så frågar datorn vilken användare som den vill ta bort. Så först får användaren se listan på alla
            // användare som finns att välja i mellan. Sen när användaren har valt vilken kund som ska bort så removas 
            // kunden från listan.
            Showcustomers();
            Console.Write("vilken kund (ange siffran) vill du ta bort?: ");
            string strChoise = Console.ReadLine();
            int choise = int.Parse(strChoise);
            customerList.RemoveAt(choise);
        }

        private static void AddCustomer()
        {
            // Här kommer kunden att kunna lägga till en ny kund. Dom kommer få fårgan om vad kunden heter och efter
            // dom skrivit namnet så sparas kundens namn och balans som kommer vara 0 tills någon lägger in pengar.
            Customer kund1  = new Customer();
            Console.Write("vänligen ange kundens namn: ");
            kund1.Name = Console.ReadLine();
            customerList.Add(kund1);
            
            

        }

    }
}
