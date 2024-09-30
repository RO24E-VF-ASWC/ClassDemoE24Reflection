using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoE24Reflection.Reflection
{
    public class InspectObjects
    {

        public void TryReflection(object obj)
        {
            if (obj != null)
            {
                Type t = obj.GetType();

                Console.WriteLine("is interface : " + t.IsInterface);
                Console.WriteLine("is class : " + t.IsClass);
                Console.WriteLine("is abstract : " + t.IsAbstract);

                Console.WriteLine(" ===== Prop ====");
                foreach (var property in t.GetProperties())
                {
                    Console.WriteLine(property);

                }

                Console.WriteLine(" ===== Method ====");
                foreach (var method in t.GetMethods())
                {
                    Console.WriteLine(method);

                }

                Console.WriteLine(" === udskriv property ====");
                var nameProp = t.GetProperty("Name");
                if (nameProp != null)
                {
                    Console.WriteLine($"Name of property {nameProp.Name} og værdien er {nameProp.GetValue(obj)}");
                }


                Console.WriteLine(" ==== Skriver ny værdi til property ====");
                var setName = t.GetMethod("set_Name");
                Console.WriteLine(" drink obj foer: " + obj);

                setName.Invoke(obj, new object[] { "this is a new drink" });

                Console.WriteLine(" drink obj efter: " + obj);


            }
        }
    }
}
