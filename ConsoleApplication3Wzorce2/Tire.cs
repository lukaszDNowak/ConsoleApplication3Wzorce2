using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Wzorce2
{
        public class Tire : IBuliderTire
        {
            string manufacturer { get; set; }
            int diameter { get; set; }
            int width { get; set; }
            int profil { get; set; }

            string sezon { get; set; }

            protected string vehicle = "";

            protected static double priceTire = 1.0;

            public void setManufacturer(string _manufacturer)
            {
                manufacturer = _manufacturer;
            }

            public void setDiameter(int _diameter)
            {
                diameter = _diameter;
                priceTire += _diameter;
            }

            public void setWidth(int _width)
            {
                width = _width;
                priceTire += _width;
            }

            public void setProfil(int _profil)
            {
                profil = _profil;
                priceTire += _profil;
            }

            public void setSezon(string _sezon)
            {
                sezon = _sezon;
            }

            public void showTire()
            {
                var info = String.Format($"Opona do samochodu {vehicle} na sezon {sezon} producenta : {manufacturer} o średnicy : {diameter} cali, szerokości : {width} mm i profilu : {profil} mm . Cena {priceTire}");
                Console.WriteLine(info);
                Console.ReadKey();
            }
        }
        class CargoTireBulider : Tire
        {
            public CargoTireBulider()
            {
                priceTire = 200;
                vehicle = "Ciężarowego";
            }
        }

        class PersonalTireBulider : Tire
        {
            public PersonalTireBulider()
            {
                priceTire = 100;
                vehicle = "Osobowego";
            }
        }
    }

