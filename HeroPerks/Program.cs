using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks HeroPerks = 0;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w':
                        HeroPerks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        HeroPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        HeroPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        HeroPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }

            if (HeroPerks == 0)
            {
                Console.WriteLine("No perks at all!");
            }else{
                Console.WriteLine($"Player perks: {HeroPerks}");
            }

            if ((HeroPerks & Perks.Stealth) == Perks.Stealth && 
            (HeroPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((HeroPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }        
            
        }
    }
}
