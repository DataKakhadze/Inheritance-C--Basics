﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Other : Other_2
    {
        public void CallMethodRecall()
        {
            Console.WriteLine("second method call");

            CallMethod();
        }

    }
}
