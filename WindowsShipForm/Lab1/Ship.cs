using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Ship
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        private const int shipWidth = 100;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        private const int shipHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed
        {
            private set; get;
        }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight
        {
            private set; get;
        }

        public Color MainColor
        {
            private set; get;
        }
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
        public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
        illum, bool gun)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Illum = illum;
            Gun = gun;

        }
        /// <summary>
        /// Установка позиции корабля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
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
        public void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //корпус
            Brush br = new SolidBrush(MainColor);
            Point point1 = new Point((int) _startPosX, (int) _startPosY);
            Point point2 = new Point((int) _startPosX + 170, (int) _startPosY);
            Point point3 = new Point((int) _startPosX + 100, (int) _startPosY + 40);
            Point point4 = new Point((int) _startPosX + 30, (int) _startPosY + 40);
            Point[] curvePoints = { point1, point2, point3, point4 };
            g.FillPolygon(br, curvePoints);
            g.DrawPolygon(pen, curvePoints);
            br = new SolidBrush(DopColor);
            //иллюминаторы
            if (Illum)
            {
                g.FillEllipse(br, _startPosX + 40, _startPosY + 12, 15, 15);
                g.FillEllipse(br, _startPosX + 65, _startPosY + 12, 15, 15);
                g.FillEllipse(br, _startPosX + 90, _startPosY + 12, 15, 15);
            }
            //линии на корпусе
            g.DrawLine(pen, _startPosX + 6, _startPosY + 7, _startPosX + 154, _startPosY + 7);
            g.DrawLine(pen, _startPosX + 26, _startPosY + 33, _startPosX + 110, _startPosY + 33);
            //мачта
            g.DrawLine(pen, _startPosX + 70, _startPosY, _startPosX + 70, _startPosY - 50);
            g.DrawLine(pen, _startPosX + 65, _startPosY - 45, _startPosX + 75, _startPosY - 45);
            g.DrawLine(pen, _startPosX + 55, _startPosY - 35, _startPosX + 85, _startPosY - 35);
            g.DrawLine(pen, _startPosX + 45, _startPosY - 25, _startPosX + 95, _startPosY - 25);
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
            //флаг
            g.DrawLine(pen, _startPosX + 20, _startPosY, _startPosX + 20, _startPosY - 50);
            br = new SolidBrush(Color.Red);
            g.FillRectangle(br, _startPosX, _startPosY - 50, 20, 15);

        }
    }
}
