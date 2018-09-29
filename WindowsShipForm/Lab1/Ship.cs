using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Ship : ITransport
    {        
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        //Высота окна отрисовки
        protected int _pictureHeight;
        
        public int MaxSpeed
        {
            protected set; get;
        }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight
        {
            protected set; get;
        }

        public Color MainColor
        {
            protected set; get;
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

        public abstract void DrawShip(Graphics g);

        public abstract void MoveTransport(Direction direction);
    }
}
