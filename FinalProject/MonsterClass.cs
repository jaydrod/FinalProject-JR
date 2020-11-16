using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProject
{
    class MonsterClass
    {
        public Image image;
        public int x, y, size, speed; 
        public MonsterClass(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size; 

        }
        public MonsterClass(int _x, int _y, int _size, int _speed,  Image _image)
        {
            x = _x;
            y = _y;
            size = _size;
            image = _image;
            speed = _speed; 
        }
        public void Move()
        {
            x += speed; 
        }

    }
}
