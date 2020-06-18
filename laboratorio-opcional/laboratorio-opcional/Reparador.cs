using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_opcional
{
    class Reparador:Barco
    {
        public Reparador()
        {
            length = 2;
            life = 2;
        }

        public override bool HitScan(int x, int y)
        {
            if (orient == "vert")
            {
                if ((x == xCoord && y == yCoord) || (x == xCoord && y == yCoord+1))
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

            else
            {
                if ((x == xCoord && y == yCoord)|| (x == xCoord+1 && y == yCoord))
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
}
