using System;

namespace OOPPractice
{
    class Weapon
    {
        string model;
        int countBullets;
        int currentBullets;
        uint mode; // 0 - single shot mode, 1 - burst shooting
        bool isFuseOn;


        public Weapon(string model, int countBullets, uint mode)
        {
            this.model = model;
            this.countBullets = countBullets;
            this.mode = mode;
            currentBullets = countBullets;
            isFuseOn = true;
        }

        public void SwitchFuse()
        {
            isFuseOn = !isFuseOn;
        }

        public void SwitchMode(uint mode)
        {
            if(mode >= 0 & mode <= 1)
                this.mode = mode;
        }
        public void PiuPiu()
        {
            if (!isFuseOn)
            {
                if (currentBullets == 0)
                    Console.WriteLine("Need Reload weapon");
                else
                {
                    if (mode == 0)
                    {
                        Console.WriteLine($"Piu ");
                        currentBullets--;
                    }
                    else
                    {
                        for (int i = 0; i < currentBullets; i++)
                        {
                            Console.Write($"Piu ");
                        }
                        currentBullets = 0;
                    }
                }
            }
            else 
                Console.WriteLine("Turn off the fuse");

            Console.WriteLine();
        }

        public void Reload()
        {
            currentBullets = countBullets;
        }

        public void InfoAboutWeapon()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Model - {model}");
            Console.WriteLine($"Mode - {mode}");
            Console.WriteLine($"Count of Bullets - {countBullets}");
            Console.WriteLine($"Current of Bullets - {currentBullets}");
            if(isFuseOn)
                Console.WriteLine($"Fuse - ON");
            else
                Console.WriteLine($"Fuse - OFF");
            Console.WriteLine("---------------------");
        }

    }

    class Program
    {



        static void Main(string[] args)
        {
            Weapon gun = new Weapon("Desert Eagle", 9, 0);
            gun.InfoAboutWeapon();
            gun.SwitchFuse();
            gun.PiuPiu();
            gun.PiuPiu();
            gun.PiuPiu();
            gun.InfoAboutWeapon();
            gun.Reload();
            gun.InfoAboutWeapon();

            Weapon M4 = new Weapon("M4", 30, 1);
            M4.InfoAboutWeapon();
            M4.SwitchFuse();
            M4.PiuPiu();
            M4.InfoAboutWeapon();
            M4.SwitchMode(0);
            M4.Reload();
            M4.PiuPiu();
            M4.InfoAboutWeapon();
        }
    }
}
