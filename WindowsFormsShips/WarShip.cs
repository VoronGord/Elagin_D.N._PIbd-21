using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    public class War_Ship : Ship, IComparable<War_Ship>, IEquatable<War_Ship>
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

        /// <summary>         /// Конструктор         /// </summary>  
        /// <param name="info">Информация по объекту</param>        
        public War_Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                SpeedWater = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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

        public override string ToString()
        {
            return MaxSpeed + ";" + SpeedWater + ";" + MainColor.Name;
        }
        public int CompareTo(War_Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (SpeedWater != other.SpeedWater)
            {
                return SpeedWater.CompareTo(other.SpeedWater);
            }
            if (MainColor != other.MainColor)
            {
               return MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(War_Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)    
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (SpeedWater != other.SpeedWater)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is War_Ship lincorObj))
            {
                return false;
            }
            else
            {
                return Equals(lincorObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
