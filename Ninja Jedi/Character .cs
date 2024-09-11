using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Jedi
{
    public class Character
    {

        private int health;
        private int stregth;


        public string Faction { get; set; }

        public int Health 
        { 
            get {  return health; } 
            set
            {
                if (value < 1)
                    health = 1;
                else if (value > 100)
                    health = 100;
                else
                    health = value;
            }
        }

        public int Stregth
        {
            get { return stregth; }
            set
            {
                if (value < 1)
                    stregth = 1;
                else if (value > 100)
                    stregth = 100;
                else
                    stregth = value;
            }
        }

        public string SpecialSkill { get; set; }


        public Character(string faction, int health, int stregth, string specialSkill)
        {
            Faction = faction;
            Health = health;
            Stregth = stregth;
            SpecialSkill = specialSkill;
        }


        public void DisplayCharactorInfo() 
        {
            Console.WriteLine($"Faction: {Faction}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Stregth: {Stregth}");
            Console.WriteLine($"Special Skill: {SpecialSkill}");
        }

        public void UseSpecialSkill()
        {
            Console.WriteLine($"{Faction} uses {SpecialSkill}!");
        }

    }
}
