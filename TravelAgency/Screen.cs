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
            FirstTemplate(1);
            Console.WriteLine("--------------------------------");
            SecondTemplate(2);
            Console.WriteLine("--------------------------------");
            ThirdTemplate(3);
            Console.WriteLine("--------------------------------");
            Console.Write("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY: ");
        }

        static void FirstTemplate(int number)
        {
            Office office = new Office();

            foreach (var hotel in office.SelectedHotelsThreeStar)
            {
                Console.WriteLine($"NUMER: {number}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine("WYŻYWIENIE: śniadanie");
                Console.WriteLine($"CENA: {hotel.Price} PLN/os");
            }
        }
        static void SecondTemplate(int number)
        {
            Office office = new Office();

            foreach (var hotel in office.SelectedHotelsFourStar)
            {
                Console.WriteLine($"NUMER: {number}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine("WYŻYWIENIE: All Inclusive");
                Console.WriteLine($"CENA: {hotel.Price} PLN/os");
            }
        }
        static void ThirdTemplate(int number)
        {
            Office office = new Office();

            foreach (var hotel in office.SelectedHotelsFiveStar)
            {
                Console.WriteLine($"NUMER: {number}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine("WYŻYWIENIE: All Inclusive");
                Console.WriteLine($"CENA: {hotel.Price} PLN/os");
            }
        }
    }
}
