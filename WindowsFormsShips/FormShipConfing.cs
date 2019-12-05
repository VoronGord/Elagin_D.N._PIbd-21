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
    public partial class FormShipConfing : Form
    {

        IShip ship = null;

        private event shipDelegate eventAddShip;

        public FormShipConfing()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelSilver.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => {   Close(); };

        }


        /// <summary>         /// Добавление события         /// </summary>    
        /// /// <param name="ev"></param>     
        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        } 




        /// Отправляем цвет с панели         /// </summary>         /// <param name="sender"></param>  
        /// /// <param name="e"></param>      
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        } 

        /// <summary>         /// Проверка получаемой информации (ее типа на соответствие требуемому)   
        /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>     
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } 

        /// <summary>         /// Принимаем основной цвет         /// </summary>  
        /// /// <param name="sender"></param>         /// <param name="e"></param>   
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Lincor)
                {
                    (ship as Lincor).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }



        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(35, 35, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawShip(gr);
                pictureBoxShip.Image = bmp;
            }
        }
        /// <summary>         /// Передаем информацию при нажатии на Label         /// </summary>   
        /// /// <param name="sender"></param>         /// <param name="e"></param> 
        private void labelLincor_MouseDown(object sender, MouseEventArgs e)
        {
            labelLincor.DoDragDrop(labelLincor.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>         /// Передаем информацию при нажатии на Label         /// </summary>    
        /// /// <param name="sender"></param>         /// <param name="e"></param> 
        private void labelWar_Ship_MouseDown(object sender, MouseEventArgs e)
        {
            labelWar_Ship.DoDragDrop(labelWar_Ship.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }


        /// <summary>         /// Проверка получаемой информации (ее типа на соответствие требуемому)     
        /// /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>  
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } 

        /// <summary>         /// Действия при приеме перетаскиваемой информации  
        /// /// </summary>         /// <param name="sender"></param>   
        /// /// <param name="e"></param>       
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "War_Ship":
                    ship = new War_Ship(100, 500, Color.White);
                    break;
                case "Lincor":
                    ship = new Lincor(100, 500, Color.White, Color.Black, true, true, true);
                    break;
            }           
        DrawShip();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
