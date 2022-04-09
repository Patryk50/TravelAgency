using System;
using TraveLogic;

namespace TravelAgency
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "BIURO PODRÓŻY";

            Office office = new Office();

            Screen.InitialScreen(office);
        }
    }
}
