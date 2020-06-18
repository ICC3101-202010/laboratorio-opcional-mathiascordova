using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_opcional
{
    class Radar : Barco
    {
        public Radar()
        {
            life = 1;
            length = 1;
        }

        public override bool HitScan(int x, int y)
        {
            if ((x == xCoord && y == yCoord))
            {
                life -= 1;
                if (life == 0)
                {
                    Console.WriteLine("Se hundio el barco!");
                    xCoord = 20;
                    yCoord = 20;
                    return true;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
