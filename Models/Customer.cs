using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Customer(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
