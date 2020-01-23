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
        private IShip ship;

        public FormLincor()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawShip(gr);
            pictureBoxShip.Image = bmp;
        }
        private void GenerLincor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Lincor(rnd.Next(10, 20), rnd.Next(5, 8), Color.Blue, Color.Yellow, true, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {//получаем имя кнопкиs
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "Down":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "Left":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "Right":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void GenerWarShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new War_Ship(rnd.Next(10, 20), rnd.Next(5, 8), Color.Blue);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }
    }
}
