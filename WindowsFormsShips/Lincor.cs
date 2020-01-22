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
    public class Lincor : War_Ship
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


        public override void DrawShip(Graphics g)
        {
            Brush brDop = new SolidBrush(DopColor);
            base.DrawShip(g);

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

    }
}
