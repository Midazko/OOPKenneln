using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace OOPKenneln
{
    public class ListOfDogs
    {
        public List<Dogs> List()
        {
            var DogTypeList = new List<Dogs>();
            if (!File.Exists("DogList")) return DogTypeList;
            foreach (var line in File.ReadLines("DogList"))
            {
                var parts = line.Split(", ");
                var dogs = new Dogs();
                dogs.Name = parts[0];
                dogs.Breed = parts[1];
                dogs.Age = Convert.ToDouble(parts[2]);
                dogs.Weight= Convert.ToDouble(parts[3]);
                dogs.Tail = Convert.ToDouble(parts[4]);
                DogTypeList.Add(dogs);
                
            }
            return DogTypeList;
        }
        public void Savedogs(List<Dogs> list)
        {
            var strings = new List<string>();
            foreach (var dog in list)
            {
                string Doggo = dog.Name + ", " + dog.Breed + ", " + dog.Age + ", " + dog.Weight + ", " + dog.Tail;
                strings.Add(Doggo);
            }
            File.WriteAllLines("DogList", strings);
        }
    }
}
    