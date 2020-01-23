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
        public partial class FormParking : Form
        {         /// <summary>         /// Объект от класса-парковки         /// </summary>      
       Parking<IShip> parking; 

            public FormParking()
        {
            InitializeComponent();
            parking = new Parking<IShip>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        } 
 
        /// <summary>         /// Метод отрисовки парковки         /// </summary>      
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        } 
 
        /// <summary>         /// Обработка нажатия кнопки "Припарковать автомобиль"    
        /// /// </summary>         /// <param name="sender"></param>      
        /// /// <param name="e"></param>    
        private void buttonGenerWarShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new War_Ship(100, 10, dialog.Color);
                int place = parking + ship;
                Draw();
            }
        } 
        /// <summary>         /// Обработка нажатия кнопки "Припарковать гоночный автомобиль" 
        /// /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>    
        private void buttonGenerLincor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Lincor(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    int place = parking + ship;
                    Draw();
                }
            }
        } 
 
        /// <summary>         /// Обработка нажатия кнопки "Забрать"    
        /// /// </summary>         /// <param name="sender"></param>     
        /// /// <param name="e"></param>      
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = parking - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(10, 35, pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    ship.DrawShip(gr);
                    pictureBoxTakeShip.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    pictureBoxTakeShip.Image = bmp;
                }
                Draw();
            }
        }
    }
}
    
