using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Book(string title, int price)
        {
            Title = title;
            Price = price;
        }

        public Book(int id, string title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }
}
