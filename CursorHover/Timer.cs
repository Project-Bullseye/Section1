﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace timer.Timer
{
    class Timer
    {
        public static void timer()
        {
            int maxTime = 10000;
            int currentTime = 0;

            int sloth = 200;
            int giantTurtle = 100;
            int greenIguana = 40;
            int cheetah = 20;
            int peregrineFalcon = 10;

            Console.WriteLine("Choose a time difficulty 1:Sloth 2:Giant Turtle 3:Green Iguana 4:Cheetah 5:Peregrine Falcon. Please enter the number.");
            int choiceTimer = Convert.ToInt32(Console.ReadLine());

            switch (choiceTimer)
            {
                case 1:
                    maxTime = sloth;
                    break;
                case 2:
                    maxTime = giantTurtle;
                    break;
                case 3:
                    maxTime = greenIguana;
                    break;
                case 4:
                    maxTime = cheetah;
                    break;
                case 5:
                    maxTime = peregrineFalcon;
                    break;
            }

            Console.WriteLine($"{maxTime}");
            Console.ReadLine();
            while (currentTime < maxTime)
            {
                Console.WriteLine($"{currentTime}");
                Thread.Sleep(1000);
                currentTime++;
            }

        }
    }
}

