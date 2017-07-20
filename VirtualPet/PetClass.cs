using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PetClass
    {
        private int happy;
        private int hungry;
        private int thirsty;
        private int bored;
        private int waste;

        public int Happy { get; }
        public int Hungry { get; }
        public int Thirsty { get; }
        public int Bored { get; }
        public int Waste { get; }

        PetClass()
        {
            //Default
        }
        PetClass(int happy, int hungry, int thirsty, int bored, int waste)
        {
            this.happy = happy;
            this.hungry = hungry;
            this.thirsty = thirsty;
            this.bored = bored;
            this.waste = waste;
        }

        public void Feed()
        {
            Random foodQuality = new Random();
            hungry -= foodQuality.Next(1, 6);
            thirsty++;
            thirsty++;
            waste++;
            Console.WriteLine("Hunger: " + Hungry);
            Console.WriteLine("Thirst: " + Thirsty);
            

            if (Hungry > 5)
            {
                Console.WriteLine("Your pet is starving! I'm having my doubts about you.");
            }

        }
        public void GiveWater()
        {
            Random drinkQuality = new Random();
            thirsty -= drinkQuality.Next(1, 6);
        }
        public void Walk()
        {

        }
    }
}
