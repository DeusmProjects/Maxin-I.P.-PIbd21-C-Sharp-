using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ShipForm : Form
    {
        private Ship ship;
        public ShipForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawShip(gr);
            pictureBoxShip.Image = bmp;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Ship.Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Ship.Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Ship.Direction.Left);
                    break;
                case "buttonRight":

                    ship.MoveTransport(Ship.Direction.Right);
                    break;
            }
            Draw();
        }

        private void bottonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray,
            Color.LightBlue, true, true);
            ship.SetPosition(rnd.Next(150, 200), rnd.Next(200, 300), pictureBoxShip.Width,
            pictureBoxShip.Height);
            Draw();
        }
    }
}
