using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveLogic
{
    public class Office
    {
        public Office()
        {
            CreateHotels();
            CreateDate();
            SelectHotels();
        }

        public List<Hotel> ListOfHotelsThreeStar = new();
        public List<Hotel> ListOfHotelsFourStar = new();
        public List<Hotel> ListOfHotelsFiveStar = new();

        public List<Hotel> SelectedHotels = new();

        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Difference { get; set; }

        void CreateHotels()
        {
            ListOfHotelsFourStar.Add(new(1, "Cancun Bay Resort", "Meksyk", "(****)", 450));

            ListOfHotelsFiveStar.Add(new(1, "Iberostar Quetzal", "Meksyk", "(*****)", 690));

            ListOfHotelsThreeStar.Add(new(1, "Imperial Laguna by Faranda", "Meksyk", "(***)", 320));

            ListOfHotelsFiveStar.Add(new(2, "Playacalida", "Hiszpania", "(*****)", 600));

            ListOfHotelsThreeStar.Add(new(2, "Palia Puerto del Sol", "Hiszpania", "(***)", 240));

            ListOfHotelsFourStar.Add(new(2, "Playa Real Resort", "Hiszpania", "(****)", 380));

            ListOfHotelsThreeStar.Add(new(3, "Sea Gull", "Egipt", "(***)", 270));

            ListOfHotelsFourStar.Add(new(3, "Continental Hurghada", "Egipt", "(****)", 360));

            ListOfHotelsFiveStar.Add(new(3, "Sharm Grand Plaza", "Egipt", "(*****)", 620));

            ListOfHotelsThreeStar.Add(new(4, "Ikaros Hotel", "Grecja", "(***)", 220));

            ListOfHotelsFiveStar.Add(new(4, "Labranda Sandy Beach Resort", "Grecja", "(*****)", 580));

            ListOfHotelsFourStar.Add(new(4, "Lida Corfu", "Grecja", "(****)", 310));

            ListOfHotelsFiveStar.Add(new(5, "Mytt Beach Hotel", "Tajlandia", "(*****)", 720));

            ListOfHotelsFourStar.Add(new(5, "Novotel Rayong", "Tajlandia", "(****)", 410));

            ListOfHotelsThreeStar.Add(new(5, "Cholchan Pattaya Resort", "Tajlandia", "(***)", 290));
        }

        void CreateDate()
        {
            DepartureDate = DateTime.Now;
            ArrivalDate = DateTime.Now.AddDays(7);
            Difference = (ArrivalDate - DepartureDate).Days;
        }

        public static List<int> GetNumbers()
        {
            var numbers = new List<int>();
            var random = new Random();
            while (numbers.Count < 3)
            {
                int number = random.Next(1, 6);
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        public void SelectHotels()
        {
            var numbers = GetNumbers();

            var selectedHotels = ListOfHotelsThreeStar.FirstOrDefault(h => h.Id == numbers[0]);
            SelectedHotels.Add(selectedHotels);

            selectedHotels = ListOfHotelsFourStar.FirstOrDefault(h => h.Id == numbers[1]);
            SelectedHotels.Add(selectedHotels);

            selectedHotels = ListOfHotelsFiveStar.FirstOrDefault(h => h.Id == numbers[2]);
            SelectedHotels.Add(selectedHotels);
        }
    }
}
