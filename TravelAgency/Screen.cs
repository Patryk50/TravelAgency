using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraveLogic;

namespace TravelAgency
{
    class Screen
    {
        public static void InitialScreen()
        {
            Office office = new Office();

            Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY");
            Console.WriteLine("--------------------------------");
            Template(1);
            Console.Write("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY: ");
        }

        static void Template(int number)
        {
            Office office = new Office();

            foreach (var hotel in office.SelectedHotels)
            {
                Console.WriteLine($"NUMER: {number++}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine("WYŻYWIENIE: śniadanie");
                Console.WriteLine($"CENA: {hotel.Price} PLN/os");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
