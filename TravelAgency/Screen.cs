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
        public static List<int> Price = new();
        public static List<int> Number = new();
        public static int Adults { get; set; }
        public static int Kids { get; set; }

        public static void InitialScreen(Office office)
        {
            Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY");
            Console.WriteLine("--------------------------------");
            Template(office);
            Console.Write("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY: ");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput == 1)
            {
                Console.Clear();
                Adults = Price[0];
                Kids = Price[0];
            }
            else if (userInput == 2)
            {
                Console.Clear();
                Adults = Price[1];
                Kids = Price[1];
            }
            else if (userInput == 3)
            {
                Console.Clear();
                Adults = Price[2];
                Kids = Price[2];
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wybrałeś błędny numer !!!");
                Console.ResetColor();
            }
        }

        public static void SecondScreen()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH: ");
            int.TryParse(Console.ReadLine(), out int userInput);
            Adults *= userInput;
        }

        public static void ThirdScreen()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI: ");
            int.TryParse(Console.ReadLine(), out int userInput);
            Kids *= userInput;
            Kids /= 2;
        }

        public static void LastScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"CAŁKOWITA CENA WAKACJI WYNOSI: {Adults + Kids} ZŁ");
        }

        static void Template(Office office)
        {
            int number = 1;
            string feeding;
            int price = 0;

            foreach (var hotel in office.SelectedHotels)
            {
                if (number == 1)
                {
                    feeding = "śniadanie";
                }
                else
                {
                    feeding = "All Inclusive";
                }

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

                if (number == 1)
                {
                    price = hotel.Price * office.Difference;
                }
                else if (number == 2 || number == 3)
                {
                    price = hotel.Price * office.Difference + 1200;
                }

                if (hotel.Country == "Grecja" || hotel.Country == "Hiszpania")
                {
                    price += 1000;
                }
                else if (hotel.Country == "Egipt")
                {
                    price += 1500;
                }
                else if (hotel.Country == "Tajlandia")
                {
                    price += 2000;
                }
                else
                {
                    price += 2500;
                }

                Number.Add(number);
                Price.Add(price);

                Console.WriteLine($"NUMER: {number++}");
                Console.WriteLine($"KRAJ: {hotel.Country}");
                Console.WriteLine($"TERMIN: {office.DepartureDate.ToShortDateString()} - {office.ArrivalDate.ToShortDateString()} ({office.Difference} dni)");
                Console.WriteLine($"HOTEL: {hotel.HotelName} {hotel.Category}");
                Console.WriteLine($"WYŻYWIENIE: {feeding}");
                Console.WriteLine($"CENA: {price} PLN/os");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
