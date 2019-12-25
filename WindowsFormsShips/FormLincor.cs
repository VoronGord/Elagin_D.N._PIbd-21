using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsShips
{
    public partial class FormLincor : Form
    {
        private Lincor lincor;


        public FormLincor()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            lincor.DrawLincor(gr);
            pictureBoxShip.Image = bmp;
        }

        private void GenerLincor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lincor = new Lincor(rnd.Next(10, 20), rnd.Next(5, 8), Color.Blue, Color.Yellow, true, true, true);
            lincor.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height); Draw();
        }


        private void buttonMove_Click(object sender, EventArgs e)
        {//получаем имя кнопкиs
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    lincor.MoveTransport(Direction.Up);
                    break;
                case "Down":
                    lincor.MoveTransport(Direction.Down);
                    break;
                case "Left":
                    lincor.MoveTransport(Direction.Left);
                    break;
                case "Right":
                    lincor.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void Up_Click(object sender, EventArgs e)
        {

        }

        private void Down_Click(object sender, EventArgs e)
        {

        }

        private void Left_Click(object sender, EventArgs e)
        {

        }

        private void Right_Click(object sender, EventArgs e)
        {

        }
    }
}