using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Hero
    {
        public int x, y, width, height, speed, hp;

        public Hero(int _x, int _y, int _width, int _height, int _speed, int _hp)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            hp = _hp;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
            if (direction == "up")
            {
                y -= speed; 
            }
           if (direction == "down")
            {
                y += speed; 
            }
        }
    }
}
