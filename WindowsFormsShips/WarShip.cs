using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    public class War_Ship : Ship
    {         /// <summary>         /// Ширина отрисовки автомобиля         /// </summary>         
        protected const int Lincor_Width = 100;

        /// <summary>         /// Ширина отрисовки автомобиля         /// </summary>         
        protected const int Lincor_Height = 60;

        /// <summary>         /// Конструктор         /// </summary>         /// <param name="maxSpeed">Максимальная скорость</param>   
        /// /// <param name="weight">Вес автомобиля</param>         /// <param name="mainColor">Основной цвет кузова</param>         
        public War_Ship(int maxSpeed, int speedWater, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            SpeedWater = speedWater;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidte - Lincor_Width)
                    {
                        _startPosX += step + SpeedWater;
                    }
                    break;//влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step - SpeedWater;
                    }
                    break;//вверх
                case Direction.Up:
                    if (_startPosY - step - 20
                        > 0 && _startPosX + SpeedWater < _pictureWidte - Lincor_Width)
                    {
                        _startPosY -= step;
                        _startPosX += SpeedWater;
                    }
                    break;//вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - Lincor_Height && _startPosX + SpeedWater < _pictureWidte - Lincor_Width)
                    {
                        _startPosY += step;
                        _startPosX += SpeedWater;
                    }
                    break;
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(MainColor);

            // отрисовка палубы 
            Brush brMain = new SolidBrush(MainColor);




            g.FillRectangle(brMain, _startPosX + 3, _startPosY + 5, Lincor_Width - 10, 5);
            g.FillRectangle(brMain, _startPosX, _startPosY, Lincor_Width - 5, 5);
            g.FillRectangle(brMain, _startPosX - 6, _startPosY - 5, Lincor_Width + 6, 5);

            g.FillRectangle(brMain, _startPosX + 45, _startPosY - 20, 3, 15);
            g.FillRectangle(brMain, _startPosX + 40, _startPosY - 10, 14, 2);
        }
    }
}
