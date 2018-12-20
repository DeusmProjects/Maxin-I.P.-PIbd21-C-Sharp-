using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Dock<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Dock<T>>
        where T : class, ITransport
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

        private int _currentIndex;

        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }

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
                throw new DockOverflowException();
            }
            if (d._places.ContainsValue(ship))
            {
                throw new DockAlreadyHaveException();
            }
            for (int i = 0; i < d._maxCount; i++)
            {
                if (d.CheckFreePlace(i))
                {
                    d._places.Add(i, ship);
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
            throw new DockNotFoundException(index);
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach(var ship in _places)
            {
                ship.Value.DrawShip(g);
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

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new DockNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                } else
                {
                    throw new DockOccupiedPlaceException(ind);
                }
            }
        }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Dock<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Cruiser && other._places[thisKeys[i]] is WarShip)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is WarShip && other._places[thisKeys[i]] is Cruiser)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Cruiser && other._places[thisKeys[i]] is Cruiser)
                    {
                        return (_places[thisKeys[i]] is Cruiser).CompareTo(other._places[thisKeys[i]] is Cruiser);
                    }
                    if (_places[thisKeys[i]] is WarShip && other._places[thisKeys[i]] is WarShip)
                    {
                        return (_places[thisKeys[i]] is WarShip).CompareTo(other._places[thisKeys[i]] is WarShip);
                    }
                }
            }
            return 0;
        }
    }
}