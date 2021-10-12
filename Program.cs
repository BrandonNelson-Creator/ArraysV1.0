using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysV1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ammo system");
            // storing ammo for all

            int weapon = 0; //0 = pistol  5 = bfg


            
            Console.WriteLine("Before Arrays");

            int pistolAmmo = 6; //Declaration + initialization
            int shotgun = 2;
            int rocketLauncher = 5;

            //how to show ammo of current?

          if (weapon == 0)
            {
                Console.WriteLine("Pistol Ammo " + pistolAmmo);
            }
          else if (weapon == 1)
            {
                Console.WriteLine("ShotGun Ammo " + shotgun);
            }
          else if (weapon == 2)
            {
                Console.WriteLine("Rocket Launcher " + rocketLauncher);
            }
                


            Console.WriteLine("Arrays");



            Console.ReadKey(true);
        }
    }
}
