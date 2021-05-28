using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage damage = new SwordDamage();
            
            while (true)
            {
                Console.WriteLine("Press 1 if only base damage\nPress 2 if only Magic\nPress 3 if only Flame\nPress 4 if both Magic and Flame\nPress anything else to quit");
                char PressedKey = Console.ReadKey().KeyChar;
                if (PressedKey == '1')
                {
                    damage.CalculateDamage();
                }
                else if (PressedKey == '2')
                {
                    damage.isMagic = true;
                    damage.CalculateDamage();
                }
                else if (PressedKey == '3')
                {
                    damage.isFlame = true;
                    damage.CalculateDamage();
                }
                else if (PressedKey == '4')
                {
                    damage.isMagic = true;
                    damage.isFlame = true;
                    damage.CalculateDamage();
                }
                else
                {
                    return;
                }
                
                
            }
                       
        }
    }
}
