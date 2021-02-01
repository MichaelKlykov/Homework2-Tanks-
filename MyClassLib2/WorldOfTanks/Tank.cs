using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        string name;
        uint ammunition;
        uint armor;
        uint maneuverability;
        public Tank(string name, Random rnd)
        {
            this.name = name;
            ammunition = (uint)rnd.Next(0, 100);
            armor = (uint)rnd.Next(0, 100);
            maneuverability = (uint)rnd.Next(0, 100);
        }

        public static int operator ^(Tank t34, Tank pantera)
        {
            byte count = 0;
            byte count2 = 0;
            if (t34.armor > pantera.armor)
            {
                count++;
            }
            if (t34.ammunition > pantera.ammunition)
            {
                count++;
            }
            if (t34.maneuverability > pantera.maneuverability)
            {
                count++;
            }
            if (t34.armor == pantera.armor)
            {
                count2++;
            }
            if (t34.ammunition == pantera.ammunition)
            {
                count2++;
            }
            if (t34.maneuverability == pantera.maneuverability)
            {
                count2++;
            }
            if (count2 >= 2)
            {
                return -1;
            }
            if (count >= 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void coutTank()
        {
            WriteLine(name + " " + ammunition + "% " + armor + "% " + maneuverability + "%");
        }
    }
}