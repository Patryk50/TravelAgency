using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraveLogic;

namespace TravelAgency
{
    class Program
    {
        public static void Main(string[] args)
        {
            Office office = new Office();
            Screen.InitialScreen(office);
            Screen.SecondScreen();
            Screen.ThirdScreen();
            Screen.LastScreen();
        }
    }
}
