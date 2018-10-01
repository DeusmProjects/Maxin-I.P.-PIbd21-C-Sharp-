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
        /// Признак наличия иллюминаторов
        /// </summary>
        public bool Illum
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
        /// <param name="illum">Признак наличия иллюминаторов</param>
        /// <param name="gun">Признак наличия пушки</param>
        public WarShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
        illum, bool gun) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Illum = illum;
            Gun = gun;
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            base.DrawShip(g);

            //иллюминаторы
            if (Illum)
            {
                br = new SolidBrush(DopColor);
                g.FillEllipse(br, _startPosX + 40, _startPosY + 12, 15, 15);
                g.FillEllipse(br, _startPosX + 65, _startPosY + 12, 15, 15);
                g.FillEllipse(br, _startPosX + 90, _startPosY + 12, 15, 15);
            }

            //пушка
            if (Gun)
            {
                br = new SolidBrush(MainColor);
                Point point1_1 = new Point((int) _startPosX + 125, (int) _startPosY);
                Point point2_1 = new Point((int) _startPosX + 195, (int) _startPosY - 20);
                Point point3_1 = new Point((int) _startPosX + 203, (int) _startPosY - 20);
                Point point4_1 = new Point((int) _startPosX + 133, (int) _startPosY);
                Point[] curvePoints_1 = { point1_1, point2_1, point3_1, point4_1 };
                g.FillPolygon(br, curvePoints_1);
                g.DrawPolygon(pen, curvePoints_1);
            }
        }
    }
}