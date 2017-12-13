using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Wzorce2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var cieżarowa = new CargoTireBulider();
            cieżarowa.setDiameter(15);
            cieżarowa.setProfil(55);
            cieżarowa.setWidth(195);
            cieżarowa.setManufacturer("Debica");
            cieżarowa.setSezon("Letnia");
            cieżarowa.showTire();

            var client = new Client();
            client.EnterClient();


        }
    }
}
