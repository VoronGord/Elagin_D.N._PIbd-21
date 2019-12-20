using NLog;
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
    {
        /// <summary>         /// Объект от класса многоуровневой парковки         /// </summary>  
        MultiLevelParking parking;
        private Logger logger;
        FormShipConfing form;


        /// <summary>         /// Количество уровней-парковок         /// </summary>   
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();


            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox  
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;   
        }

        /// <summary>         /// Метод отрисовки парковки         /// </summary>      
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)    
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

      
        


        /// <summary>         /// Обработка нажатия кнопки "Забрать"    
        /// /// </summary>         /// <param name="sender"></param>     
        /// /// <param name="e"></param>      
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var ship = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                  
                    
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.SetPosition(5, 35, pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        ship.DrawShip(gr); pictureBoxTakeShip.Image = bmp;
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Error(ex.Message, "Не найдено");
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        pictureBoxTakeShip.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message, "Неизвестная ошибка");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                }
            }
        }
         /// <summary>         /// Метод обработки выбора элемента на listBoxLevels    
        /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param> 
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw(); 
        }

        

        private void AddShip(IShip ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + ship;
                    logger.Info("Добавлен корабль " + ship.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error(ex.Message, "Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void SetShip_Click(object sender, EventArgs e)
        {
            form = new FormShipConfing();
            form.AddEvent(AddShip);
            form.Show();
        }




        /// <summary>         /// Обработка нажатия пункта меню "Сохранить"         /// </summary>    
        /// /// <param name="sender"></param>         /// <param name="e"></param>   

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>         /// Обработка нажатия пункта меню "Загрузить"         /// </summary>      
        /// <param name="sender"></param>         /// <param name="e"></param>   
        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error(ex.Message, "Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
    
