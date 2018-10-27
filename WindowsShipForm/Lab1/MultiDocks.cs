using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MultiDocks
    {
        List<Dock<ITransport>> dockNumbers;
        private const int countPlaces = 10;

        public MultiDocks(int countDocks, int pictureWidth, int pictureHeight)
        {
            dockNumbers = new List<Dock<ITransport>>();
            for (int i = 0; i < countDocks; ++i)            {
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
    }
}
