using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DockOccupiedPlaceException : Exception
    {
        public DockOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит корабль")
        {
        }
    }
}
