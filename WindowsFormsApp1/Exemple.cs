using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Exemple
    {
        public int[,] graph;
        public int startPoint, endPoint;
        public int integer;

        public void Exemplu1()
        {
            graph = new int[,] { {0, 16, 13, 0, 0, 0},
                                    {0, 0, 10, 12, 0, 0},
                                    {0, 4, 0, 0, 14, 0},
                                    {0, 0, 9, 0, 0, 20},
                                    {0, 0, 0, 7, 0, 4},
                                    {0, 0, 0, 0, 0, 0}
                                    };
            startPoint = 0;
            endPoint = 5;
            integer = 6;
        }

        public void Exemplu2()
        {
            graph = new int[,] { {0, 10, 0, 10, 0, 0},
                                 {0, 0, 4, 2, 8, 0 },
                                 {0, 0, 0, 0, 0, 10 },
                                 {0, 0, 0, 0, 9, 0 },
                                 {0, 0, 6, 0, 0, 10 },
                                 {0, 0, 0, 0, 0, 0 }
                                 };

            startPoint = 0;
            endPoint = 5;
            integer = 6;
        }

        public void Exemplu3()
        {
            graph = new int[,] {{0, 3, 2, 2, 0, 0, 0, 0},
                                {0, 0, 0, 0, 5, 1, 0, 0},
                                {0, 0, 0, 0, 1, 3, 1, 0},
                                {0, 0, 0, 0, 0, 1, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 4},
                                {0, 0, 0, 0, 0, 0, 0, 2},
                                {0, 0, 0, 0, 0, 0, 0, 4},
                                {0, 0, 0, 0, 0, 0, 0, 0}
                                };

            startPoint = 0;
            endPoint = 7;
            integer = 8;
        }
    }
}
