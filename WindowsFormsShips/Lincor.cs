using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShips
    public class Lincor : War_Ship
    {
        public Color DopColor { private set; get; }

    public class Lincor
    {
        public Color DopColor { private set; get; }
        public bool Gun { private set; get; }
        public bool Anchor { private set; get; }
        public bool Boat { private set; get; }
        public Lincor(int maxSpeed, int speedWater, Color mainColor, Color dopColor,
            bool gun, bool anchor, bool boat) :
             base(maxSpeed, speedWater, mainColor)
        {
            DopColor = dopColor;
            Gun = gun;
            Anchor = anchor;
            Boat = boat;
        }

        public Lincor(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                SpeedWater = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Gun = Convert.ToBoolean(strs[4]);
                Anchor = Convert.ToBoolean(strs[5]);
                Boat = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawShip(Graphics g)
        {
            Brush brDop = new SolidBrush(DopColor);
            base.DrawShip(g);
        {
            Brush brDop = new SolidBrush(DopColor);
            base.DrawShip(g);

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
                g.FillEllipse(brDop, _startPosX + 70, _startPosY - 20, 10, 20);
                g.FillRectangle(brDop, _startPosX + 75, _startPosY - 15, 10, 2);
            }
            if (Anchor)
            {
                g.FillRectangle(brDop, _startPosX + 75, _startPosY, 3, 6);
                g.FillRectangle(brDop, _startPosX + 72, _startPosY + 5, 10, 2);
            }
            if (Boat)
            {
                g.FillRectangle(brDop, _startPosX + 80, _startPosY - 2, 10, 4);
                g.FillRectangle(brDop, _startPosX + 50, _startPosY - 2, 10, 4);
                g.FillRectangle(brDop, _startPosX + 10, _startPosY - 2, 10, 4);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;    
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Gun + ";" + Anchor + ";" + Boat;
        }
    }
}
