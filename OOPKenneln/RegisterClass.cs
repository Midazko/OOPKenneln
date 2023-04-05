using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKenneln
{
    public class RegisterClass
    {
        public void Register()
        {
            Console.Clear();
            Console.WriteLine("----- Welcome to the dog register! -----\n");
            var listofdogs = new ListOfDogs();
            var list = listofdogs.List();
            var dogs = new Dogs();

            Console.Write("Enter the dogs name: ");
            var name =  Console.ReadLine();

            Console.Write("\nWhat is the breed: ");
            var breed = Console.ReadLine();

            Console.Write("\nWhat is the age: ");
            double age;
            double.TryParse(Console.ReadLine(), out age);

            Console.Write("\nHow fat: ");
            double weight;
            double.TryParse(Console.ReadLine(), out weight);

            double tail = age * weight / 10;
            if (breed.ToLower() == "Tax")
            {
                tail = 3.7;
            }

                list.Add(new Dogs { Name = name, Breed = breed, Age = age, Weight = weight, Tail = tail});
            listofdogs.Savedogs(list);
        }
    }
}
