﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Knuckle knuckle = new Knuckle(@"d:\MasOfKnuckle.txt");
            Console.ReadKey();
        }
    }
}
