using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Block
    {
        public int width = 600;
        public int height = 20;
        public int width2 = 20;
        public int hight2 = 600; 


        public int x;
        public int y;


        public static Random rand = new Random();

        public Block(int _x, int _y)

        {
            x = _x;
            y = _y;
        }
    }
}
