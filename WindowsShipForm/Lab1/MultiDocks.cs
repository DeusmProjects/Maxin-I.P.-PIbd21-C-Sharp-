using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MultiDocks
    {
        List<Dock<ITransport>> dockNumbers;
        private const int countPlaces = 10;

        private int pictureWidth;

        private int pictureHeight;

        public MultiDocks(int countDocks, int pictureWidth, int pictureHeight)
        {
            dockNumbers = new List<Dock<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;

            dockNumbers = new List<Dock<ITransport>>();
            for (int i = 0; i < countDocks; ++i)
            {
                dockNumbers.Add(new Dock<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Dock<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < dockNumbers.Count)
                {
                    return dockNumbers[ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountDocks:" + dockNumbers.Count + Environment.NewLine, fs);
                    foreach (var level in dockNumbers)
                    {
                        WriteToFile("Dock" + Environment.NewLine, fs);
                        foreach (ITransport ship in level)
                        {
                            if (ship.GetType().Name == "Cruiser")
                            {
                                WriteToFile(level.GetKey + ":Cruiser:", fs);
                            }
                            if (ship.GetType().Name == "WarShip")
                            {
                                WriteToFile(level.GetKey + ":WarShip:", fs);
                            }
                            WriteToFile(ship + Environment.NewLine, fs);
                        }
                    }
                }
            }
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountDocks"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (dockNumbers != null)
                {
                    dockNumbers.Clear();
                }
                dockNumbers = new List<Dock<ITransport>>(count);
            } else
            {
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            int counterShip = 0;
            ITransport ship = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Dock")
                {
                    counter++;
                    counterShip = 0;
                    dockNumbers.Add(new Dock<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Cruiser")
                {
                    ship = new Cruiser(strs[i].Split(':')[2]);
                } else if (strs[i].Split(':')[1] == "WarShip")
                {
                    ship = new WarShip(strs[i].Split(':')[2]);
                }
                dockNumbers[counter][counterShip++] = ship;
            }
        }

        public void Sort()
        {
            dockNumbers.Sort();
        }
    }
}
