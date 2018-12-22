using NLog;
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
        FormShipConfig shipConfig;

        MultiDocks dock;

        private const int countDocks = 5;

        private Logger logger;

        public FormDock()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            dock = new MultiDocks(countDocks, pictureBoxDock.Width, pictureBoxDock.Height);
            for (int i = 0; i < countDocks; i++)
            {
                listBoxDocks.Items.Add("Док " + (i + 1));
            }
            listBoxDocks.SelectedIndex = 0;
            Draw();
        }

        private void Draw()
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dock[listBoxDocks.SelectedIndex].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
        }

        private void buttonParkingCruiser_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Cruiser(100, 1000, dialog.Color);
                    int place = dock[listBoxDocks.SelectedIndex] + ship;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }

            }
        }

        private void buttonParkingWarShip_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new WarShip(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        int place = dock[listBoxDocks.SelectedIndex] + ship;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    try
                    {
                        var ship = dock[listBoxDocks.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
                        Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
                        ship.DrawShip(gr);
                        pictureBoxShip.Image = bmp;
                        logger.Info("Изъят корабль " + ship.ToString() + " с места " +
                       maskedTextBoxPlace.Text);
                        Draw();
                    } catch (DockNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                        pictureBoxShip.Image = bmp;
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonChooseShip_Click(object sender, EventArgs e)
        {
            shipConfig = new FormShipConfig();
            shipConfig.AddEvent(AddShip);
            shipConfig.Show();
        }

        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxDocks.SelectedIndex > -1)
            {
                try
                {
                    int place = dock[listBoxDocks.SelectedIndex] + ship;
                    logger.Info("Добавлен корабль " + ship.ToString() + " на место " + place);
                    Draw();
                }
                catch (DockOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DockAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dock.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dock.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                } catch (DockOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dock.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}