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
    public partial class FormDock : Form
    {
        Dock<ITransport> dock;
        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<ITransport>(10, pictureBoxDock.Width, pictureBoxDock.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }

        private void buttonParkingCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Cruiser(100, 1000, dialog.Color);
                int place = dock + ship;
                Draw();
            }
        }

        private void buttonParkingWarShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new WarShip(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = dock + ship;
                    Draw();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var ship = dock - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxShip.Width,
                    pictureBoxShip.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(5, 5, pictureBoxDock.Width, pictureBoxShip.Height);
                    ship.DrawShip(gr);
                    pictureBoxShip.Image = bmp;
                } else
                {
                    Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                    pictureBoxShip.Image = bmp;
                }
                Draw();
            }
        }
    }
}