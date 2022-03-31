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
                string feeding;
                //Instrukcja warunkowa odpowiadająca za wyświetlenie rodzaju wyżywienia
                if (number == 1)
                {
                    feeding = "śniadanie";
                }
                else
                {
                    feeding = "All Inclusive";
                }

                //Instrukcja warunkowa odpowiadająca za przedstawienie innej daty powrotu i sumy spędzonych dni
                if (number == 2)
                {
                    office.ArrivalDate = DateTime.Now.AddDays(10);
                    office.Difference = (office.ArrivalDate - office.DepartureDate).Days;
                }
                else if (number == 3)
                {
                    office.ArrivalDate = DateTime.Now.AddDays(14);
                    office.Difference = (office.ArrivalDate - office.DepartureDate).Days;
                }
                Console.WriteLine($"NUMER: {number++}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine($"WYŻYWIENIE: {feeding}");
                Console.WriteLine($"CENA: {hotel.Price} PLN/os");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
