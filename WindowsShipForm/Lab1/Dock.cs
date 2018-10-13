using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Dock<T> where T : class, ITransport
    {
        private T[] _places;
        private int PictureWidth
        {
            get; set;
        }
        private int PictureHeight
        {
            get; set;
        }
        private int _placeSizeWidth = 310;
        private int _placeSizeHeight = 120;

        public Dock(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }

        public static int operator +(Dock<T> d, T ship)
        {
            for (int i = 0; i < d._places.Length; i++)
            {
                if (d.CheckFreePlace(i))
                {
                    d._places[i] = ship;
                    if (i < d._places.Length / 2)
                    {
                        d._places[i].SetPosition(3 + i / 5 * d._placeSizeWidth + 5, i % 5 * d._placeSizeHeight + 15, d.PictureWidth, d.PictureHeight);
                    } else
                    {
                        d._places[i].SetPosition(63 + i / 5 * d._placeSizeWidth + 5, i % 5 * d._placeSizeHeight + 15, d.PictureWidth, d.PictureHeight);
                    }
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Dock<T> d, int index)
        {
            if (index < 0 || index > d._places.Length)
            {
                return null;
            }
            if (!d.CheckFreePlace(index))
            {
                T ship = d._places[index];
                d._places[index] = null;
                return ship;
            }
            return null;
        }

        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {//если место не пустое
                    _places[i].DrawShip(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 7);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_places.Length / 4) * _placeSizeWidth, 600);
            for (int i = 0; i < 1; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 5; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 210, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 600);
            }
            for (int i = 0; i < 1; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 5; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth + 368, j * _placeSizeHeight, i * _placeSizeWidth + 600, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 600, 0, i * _placeSizeWidth + 600, 600);
            }
        }

    }
}