using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Dock<T> where T : class, ITransport
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
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
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        public static int operator +(Dock<T> d, T ship)
        {
            if(d._places.Count == d._maxCount)
            {
                return -1;
            }

            for (int i = 0; i < d._maxCount; i++)
            {
                if (d.CheckFreePlace(i))
                {
                    d._places[i] = ship;
                    if (i < d._maxCount / 2)
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
            if (!d.CheckFreePlace(index))
            {
                T ship = d._places[index];
                d._places.Remove(index);
                return ship;
            }
            return null;
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawShip(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 7);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 4) * _placeSizeWidth, 600);
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