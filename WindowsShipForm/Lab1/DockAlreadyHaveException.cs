﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("В доке уже есть такой корабль")
        { }
    }
}
