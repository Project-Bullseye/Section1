﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorHover.NameOfPlayer
{
    class PlayerName
    {
        static void playerName()
        {
            Console.WriteLine("Please enter your name");
            string playerName = Console.ReadLine();
            Console.Write($"{playerName}");

        }
        
    }
}
