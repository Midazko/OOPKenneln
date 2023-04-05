using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKenneln
{
    public class SortedDogs
    {
        public void Checktail()
        {
            var dogs = new Dogs();
            var listOfDogs = new ListOfDogs();
            var list = listOfDogs.List();
            Console.Clear();
            Console.WriteLine("----- The dog list! -----");
            Console.Write("\nHow long tail has the dog: ");
            int userTail;
            int.TryParse(Console.ReadLine(), out userTail);
            Console.WriteLine("\nThese dogs matches your search: \n\n ");
            foreach (var dog in list)
            { 
                if (dog.Tail >= userTail)
                {
                    Console.WriteLine($"Name: {dog.Name}, Breed: {dog.Breed}, Age: {dog.Age}, Fatness: {dog.Weight}, Dog tail: {dog.Tail}.");
                }
            }
            Console.ReadLine();
        }
    }
}
