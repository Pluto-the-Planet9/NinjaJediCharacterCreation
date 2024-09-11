using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Jedi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose your faction (Jedi/Ninja): ");
            string faction = Console.ReadLine();


            Console.WriteLine("Enter Health points (1-100): ");
            int health = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter stranth points (1-100): ");
            int stranth = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your special skill (Force Push/Stealth Attack): ");
            string specialSkill = Console.ReadLine();


            Character playerCharactor = new Character(faction, health, stranth, specialSkill);


            Console.WriteLine("\nCharactor Made Successfully");
            playerCharactor.DisplayCharactorInfo();

            Console.WriteLine("\nDo you want to use your special skill? (yes/no)");
            string useSkill = Console.ReadLine().ToLower();

            if (useSkill == "yes")
            {
                playerCharactor.UseSpecialSkill();
            }

            Console.ReadKey();

        }
    }
}
