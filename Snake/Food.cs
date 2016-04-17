using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;

        public Food (Random randFood)
        {
            x = randFood.Next(0, 20) * 10;
            y = randFood.Next(0, 20) * 10;

            brush = new SolidBrush(Color.Blue);

            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);

        }

        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 20) * 10;
            y = randFood.Next(0, 20) * 10;
        }

        public void drawFood(Graphics paper)
        {
            foodRec.X = x; // draw food in diff direction 
            foodRec.Y = y;
            paper.FillRectangle(brush, foodRec);
        }
    }
}
