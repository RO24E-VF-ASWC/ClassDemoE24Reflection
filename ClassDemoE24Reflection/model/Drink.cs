using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoE24Reflection.model
{
    public class Drink : IDrink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Drink(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Drink() : this(-1, "dummy", "n/a")
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}}}";
        }
    }
}
