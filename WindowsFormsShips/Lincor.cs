using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
{
    public enum Direction
    {
        Up,

        Down,

        Left,

        Right
    }
    public class Lincor
    {
        private float StartPosX;

        private float StartPosY;

        private int PictureWidte;

        private int PictureHeight;

        private const int Lincor_Width = 100;

        private const int Lincor_Height = 60;

        public int MaxSpeed { private set; get; }// скорость линкора

        public int SpeedWater { private set; get; } // скорость течения

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }


        public bool Gun { private set; get; }

        public bool Anchor { private set; get; }

        public bool Boat { private set; get; }

        public Lincor(int maxSpeed, int speedWater, Color mainColor, Color dopColor,
            bool gun, bool anchor, bool boat)
        {
            MaxSpeed = maxSpeed;
            SpeedWater = speedWater;
            MainColor = mainColor;
            DopColor = dopColor;
            Gun = gun;
            Anchor = anchor;
            Boat = boat;
        }


        public void SetPosition(int x, int y, int width, int height)
        {
            StartPosX = x;
            StartPosY = y;
            PictureWidte = width;
            PictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (StartPosX + step < PictureWidte - Lincor_Width)
                    {
                        StartPosX += step + SpeedWater;
                    }
                    break;//влево
                case Direction.Left:
                    if (StartPosX - step > 0)
                    {
                        StartPosX -= step - SpeedWater;
                    }
                    break;//вверх
                case Direction.Up:
                    if (StartPosY - step - 10
                        > 0 && StartPosX + SpeedWater < PictureWidte - Lincor_Width)
                    {
                        StartPosY -= step;
                        StartPosX += SpeedWater;
                    }
                    break;//вниз
                case Direction.Down:
                    if (StartPosY + step < PictureHeight - Lincor_Height && StartPosX + SpeedWater < PictureWidte - Lincor_Width)
                    {
                        StartPosY += step;
                        StartPosX += SpeedWater;
                    }
                    break;
            }
        }

        public void DrawLincor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // отрисовка палубы 
            Brush brMain = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);


            g.FillRectangle(brMain, StartPosX + 3, StartPosY + 5, Lincor_Width - 10, 5);
            g.FillRectangle(brMain, StartPosX, StartPosY, Lincor_Width - 5, 5);
            g.FillRectangle(brMain, StartPosX - 6, StartPosY - 5, Lincor_Width + 6, 5);

            g.FillRectangle(brMain, StartPosX + 45, StartPosY - 20, 3, 15);
            g.FillRectangle(brMain, StartPosX + 40, StartPosY - 10, 14, 2);


            if (Gun)
            {
                g.FillEllipse(brDop, StartPosX + 70, StartPosY - 20, 10, 20);
                g.FillRectangle(brDop, StartPosX + 75, StartPosY - 15, 10, 2);
            }
            if (Anchor)
            {
                g.FillRectangle(brDop, StartPosX + 75, StartPosY, 3, 6);
                g.FillRectangle(brDop, StartPosX + 72, StartPosY + 5, 10, 2);
            }
            if (Boat)
            {
                g.FillRectangle(brDop, StartPosX + 80, StartPosY - 2, 10, 4);
                g.FillRectangle(brDop, StartPosX + 50, StartPosY - 2, 10, 4);
                g.FillRectangle(brDop, StartPosX + 10, StartPosY - 2, 10, 4);
            }




        }



    }
}
