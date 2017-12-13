using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Wzorce2
{
    class Client
    {
        string name { get; set; }
        string surname { get; set; }
        int pesel{ get; set; }

       public void EnterClient()
        {
            try {
                Console.WriteLine("Podaj imie :");
                name = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko :");
                surname = Console.ReadLine();
                Console.WriteLine("Podaj pesel :");
                pesel = Int32.Parse(Console.ReadLine());
                }
            catch (SystemException)
            {
                Console.WriteLine("Podałeś nieprawidłowe dane");
                Console.WriteLine("Nastąpi zakmnięcie programu");Console.ReadKey();
            }
        }
    }
}
