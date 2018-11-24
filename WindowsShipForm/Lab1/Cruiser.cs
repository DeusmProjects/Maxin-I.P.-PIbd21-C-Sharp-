using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Cruiser : Ship
    {
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        protected const int shipWidth = 100;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        protected const int shipHeight = 60;

        public Cruiser(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Cruiser(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth - 100)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 50)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            //корпус
            Brush br = new SolidBrush(MainColor);
            Point point1 = new Point((int) _startPosX, (int) _startPosY + 50);
            Point point2 = new Point((int) _startPosX + 170, (int) _startPosY + 50);
            Point point3 = new Point((int) _startPosX + 100, (int) _startPosY + 90);
            Point point4 = new Point((int) _startPosX + 30, (int) _startPosY + 90);
            Point[] curvePoints = { point1, point2, point3, point4 };
            g.FillPolygon(br, curvePoints);
            g.DrawPolygon(pen, curvePoints);

            //линии на корпусе
            g.DrawLine(pen, _startPosX + 6, _startPosY + 57, _startPosX + 154, _startPosY + 57);
            g.DrawLine(pen, _startPosX + 26, _startPosY + 83, _startPosX + 110, _startPosY + 83);

            //мачта
            g.DrawLine(pen, _startPosX + 70, _startPosY + 50, _startPosX + 70, _startPosY);
            g.DrawLine(pen, _startPosX + 65, _startPosY + 5, _startPosX + 75, _startPosY + 5);
            g.DrawLine(pen, _startPosX + 55, _startPosY + 15, _startPosX + 85, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 45, _startPosY + 25, _startPosX + 95, _startPosY + 25);

            //иллюминаторы
            br = new SolidBrush(Color.LightBlue);
            g.FillEllipse(br, _startPosX + 40, _startPosY + 62, 15, 15);
            g.FillEllipse(br, _startPosX + 65, _startPosY + 62, 15, 15);
            g.FillEllipse(br, _startPosX + 90, _startPosY + 62, 15, 15);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}