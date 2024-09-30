using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoE24Reflection.model
{
    public class Beer:Drink
    {
        public double Alcohol { get; set; }


        public Beer(int id, string name, string description, double alc) : base(id, name, description)
        {
            Alcohol = alc;
        }

        public Beer():base()
        {
            Alcohol = 0;
        }

        public bool IsStrong()
        {
            return Alcohol > 6.0;
        }

        public bool IsNonAlcoholic => Alcohol < 0.5;

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Alcohol)}={Alcohol.ToString()}, {nameof(IsNonAlcoholic)}={IsNonAlcoholic.ToString()}}}";
        }
    }
}
