using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_opcional
{
    class Barco
    {
        protected int xCoord;
        protected int yCoord;
        protected string orient;
        protected int length;
        protected int life;
        
        public void PlaceShip(int x, int y, string orient)
        {
            xCoord = x;
            yCoord = y;
            this.orient = orient;
        }

        public virtual bool HitScan(int x, int y)
        {

            return true;
        }
    }
}
