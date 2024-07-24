﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace inlarn
{
    public class Program
    {
        public static inlarn inlarn;

        private static void Main(string[] args)
        {
            if (inlarn.user != null && inlarn.pass != null)
            {
                Console.WriteLine(inlarn.user);
                Console.WriteLine(inlarn.pass);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Proceding...");
                Console.Clear();
                inlarn.Start();
            } else
            {
                Console.WriteLine("inlarn [user] [password]");
            }
        }
    }
}
