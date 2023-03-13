using System;

using Xamarin.Forms;

namespace Foodelivery.Models
{
    public class FoodItems
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string foodName { get; set; }
        public int price { get; set; }
    }
}


