using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public Rectangle[] snakerec;
        private SolidBrush brush;
        private int x,y,width,height ;

        public Snake()
        {
            snakerec = new Rectangle[20];
            brush = new SolidBrush (Color.Black);
            x = 30;
            y = 0;
            width = 10;
            height = 10;
            for (int i=0 ; i< snakerec.Length; i++)
            {
                snakerec[i] = new Rectangle(x, y, width, height);
                x = x - 10;
            }
        }
        public void drawsnake (Graphics paper)
        {
            foreach(Rectangle rec in snakerec)
            {
                paper.FillRectangle(brush, rec);
            }
        }
    }
}
