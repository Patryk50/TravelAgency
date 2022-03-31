using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveLogic
{
    public class Hotel
    {
        public Hotel(int id, string hotelName, string country, string category, int price)
        {
            Id = id;
            HotelName = hotelName;
            Country = country;
            Category = category;
            Price = price;
        }

        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
