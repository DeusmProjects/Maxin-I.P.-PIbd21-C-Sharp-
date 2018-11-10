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
    public partial class FormShipConfig : Form
    {
        ITransport ship = null;

        private event shipDelegate eventAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawShip(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            } else
            {
                eventAddShip += ev;
            }
        }

        private void labelCruiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiser.DoDragDrop(labelCruiser.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelWarShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelWarShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Крейсер":
                    ship = new Cruiser(100, 500, Color.Gray);
                    break;
                case "Военный корабль":
                    ship = new WarShip(100, 500, Color.Gray, Color.Red, true, true);
                    break;
            }
            DrawShip();
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color) e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is WarShip)
                {
                    (ship as WarShip).SetDopColor((Color) e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }      

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
