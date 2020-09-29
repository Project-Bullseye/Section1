using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyThreading
{
    class Program
    {


        public static void Main(string[] args)
        {
            Random r = new Random();
            int randomX = r.Next(1, 1080);
            Console.WriteLine($"{randomX}"); // generates Random X coord
                                             // write a WriteLine saying this is "x" coord
            Random n = new Random();
            int randomY = n.Next(1, 1920);
            Console.WriteLine($"{randomY}"); // generates a random Y coord
                                             // write a WriteLine saying this is "y" coord



           

            while (true)
            {
                int userX = Cursor.Position.X;
                int userY = Cursor.Position.Y;
                Console.WriteLine($"{userX},{userY}");
            }


        }
    }


}
