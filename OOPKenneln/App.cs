using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKenneln
{
    public class App
    {
        public void Run()
        {
            bool Menu = true;
            var launch = new RegisterClass();
            var show = new SortedDogs();

            while (Menu)
            {
                Console.Clear();
                Console.Write("---- Welcome to kenneln! ----\n\n" +
                    "1. Register\n" +
                    "2. List the dogs\n" +
                    "3. Remove dogs\n" +
                    "4. Exit application\n\n" + 
                    "Type here: ");
                int sel;
                int.TryParse(Console.ReadLine(), out sel);    
               switch (sel)
               {
                   case 1:
                        launch.Register();
                     break;
                   case 2:
                        show.Checktail();
                     break;
                   case 3:
                     break;
                   case 4:
                     Menu = false;
                     break;
                   default:
                     Console.WriteLine("Nope!");
                     break;
               }               
            }
        }
    }
}
