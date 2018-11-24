using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class WarShip : Cruiser
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor
        {
            private set; get;
        }
        /// <summary>
        /// Признак наличия флага
        /// </summary>
        public bool Flag
        {
            private set; get;
        }
        /// <summary>
        /// Признак наличия пушки
        /// </summary>
        public bool Gun
        {
            private set; get;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет корпуса</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="flag">Признак наличия флага</param>
        /// <param name="gun">Признак наличия пушки</param>
        public WarShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool flag, bool gun) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Flag = flag;
            Gun = gun;
        }

        public WarShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Flag = Convert.ToBoolean(strs[4]);
                Gun = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            base.DrawShip(g);

            //флаг
            if (Flag)
            {
                br = new SolidBrush(DopColor);
                g.DrawLine(pen, _startPosX + 20, _startPosY + 50, _startPosX + 20, _startPosY);
                g.DrawRectangle(pen, _startPosX, _startPosY, 20, 15);
                g.FillRectangle(br, _startPosX+1, _startPosY+1, 19, 14);
                
            }

            //пушка
            if (Gun)
            {
                br = new SolidBrush(MainColor);
                Point point1_1 = new Point((int) _startPosX + 123, (int) _startPosY + 50);
                Point point2_1 = new Point((int) _startPosX + 193, (int) _startPosY + 30);
                Point point3_1 = new Point((int) _startPosX + 201, (int) _startPosY + 30);
                Point point4_1 = new Point((int) _startPosX + 131, (int) _startPosY + 50);
                Point[] curvePoints_1 = { point1_1, point2_1, point3_1, point4_1 };
                g.FillPolygon(br, curvePoints_1);
                g.DrawPolygon(pen, curvePoints_1);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Flag + ";" + Gun;
        }
    }
}