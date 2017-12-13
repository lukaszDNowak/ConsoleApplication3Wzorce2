using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Wzorce2
{
    interface IBuliderTire
    {
        void setManufacturer(string _manufacturer);
        void setDiameter(int _diameter);
        void setWidth(int _width);
        void setProfil(int _profil);
        void showTire();
    }
}
