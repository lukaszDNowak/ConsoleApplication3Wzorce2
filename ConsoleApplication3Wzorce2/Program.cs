using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Wzorce2
{
    public interface IBuliderTire
    {
        void setManufacturer(string _manufacturer);
        void setDiameter(int _diameter);
        void setWidth(int _width);
        void setProfil(int _profil);
        void showTire();


    }
    public class Tire : IBuliderTire
    {
        string manufacturer { get; set; }
        int diameter { get; set; }
        int width { get; set; }
        int profil { get; set; }

        string sezon { get; set; }

        protected string vehicle = "";

        public void setManufacturer(string _manufacturer)
        {
            manufacturer = _manufacturer;
        }

        public void setDiameter(int _diameter)
        {
            diameter = _diameter;
        }

        public void setWidth(int _width)
        {
            width = _width;
        }

        public void setProfil(int _profil)
        {
            profil = _profil;
        }

        public void setSezon(string _sezon)
        {
            sezon = _sezon;
        }

        public void showTire()
        {
            var info = String.Format($"Opona do samochodu {vehicle} na sezon {sezon} producenta : {manufacturer} o średnicy : {diameter} '', szerokości : {width} mm i profilu : {profil} mm");
            Console.WriteLine(info);
            Console.ReadKey();
        }
     }
    class CargoTireBulider : Tire
    {
       public CargoTireBulider()
        { 
            vehicle = "Ciężarowego";
        }
    }

    class PersonalTireBulider : Tire
    {
        public PersonalTireBulider()
        {
            vehicle = "Osobowego";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            CargoTireBulider opona = new CargoTireBulider();
            opona.setSezon("zimowa");
            opona.showTire();
            
          
           
            
        }
    }
}
