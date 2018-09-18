using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Follow_path
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X + 4, image.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X, image.Location.Y + 4);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X - 4, image.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X, image.Location.Y - 4);
                await Task.Delay(50);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X + 8, image.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X - 4, image.Location.Y + 4);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                image.Location = new Point(image.Location.X - 4, image.Location.Y - 4);
                await Task.Delay(50);
            }
        }
    }
}
