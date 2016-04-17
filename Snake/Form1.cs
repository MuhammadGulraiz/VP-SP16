using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    
    
    public partial class Form1 : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake = new Snake();
        Food food;
        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            paper = e.Graphics;
            food.drawFood(paper);
            snake.drawSnake(paper);

            for(int i=0 ; i<snake.snakerec.Length; i++)
            {
                if (snake.snakerec[i].IntersectsWith(food.foodRec))
                {
                    food.foodLocation(randFood);
                }
            }
        }

       
     
    }
}
