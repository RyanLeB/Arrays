using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int[] ammo;

        static int currentWeapon;
         
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine();

            // single weapon
            // weapon ammo
            // int ammo;
            // ammo = 0;


            // multiple weapons 
            // weapon ammo (for all weapons)
            // - pistol
            // - shotgun
            // - spreader
            // - rocket launcher
            //int pistolAmmo;
            //int shotgunAmmo;
            //int spreaderAmmo;
            //int rocketLauncherAmmo;
            //string currentWeapon;
            // Fire()


            // Multiple weapons with arrays

            // 0 - pistol
            // 1 - shotgun
            // 2 - spreader
            // 3 - rocket launcher

            int[] ammo; // declaration
                        // "int[]" = array
            ammo = new int[4]; // instantiation (NEW) make sure there's memory, could fail!
            
            // initialization (MAX AMMO CHEAT)
            ammo[0] = 50; // pistol
            ammo[1] = 20; // shotgun
            ammo[2] = 100; // spreader
            ammo[3] = 6; // rocket launcher
            int currentWeapon;
            currentWeapon = 0; // pistol
            // Fire(int currentWeapon)
            // PickUp(int weaponType)


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }

        static void Fire(int currentWeapon)
        {
            if (ammo[currentWeapon] <= 0) return;
            ammo[currentWeapon] = ammo[currentWeapon] - 1;
        }

    }

}
