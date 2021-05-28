using System;

namespace SwordDamage
{
    class SwordDamage
    {
      
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public decimal MagicMultiplier = 1.7M;
        public int Damage;
        static Random random = new Random();

        public bool isMagic = false;
        public bool isFlame = false;

        public int Roll3d6()
        {
            int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            return roll;
        }
        public int CalculateDamage()
        {

            int rolled = Roll3d6();
            Damage = BASE_DAMAGE + rolled;

            if (isMagic)
            {
                Damage = (int)((decimal)Damage * MagicMultiplier);
            }

            if (isFlame)
            {
                Damage += FLAME_DAMAGE;
            }

            Console.WriteLine("\nYou rolled " + rolled + "\nFinal Damage is " + Damage);

            isFlame = false;
            isMagic = false;

            return Damage;
        }



    }
}
