// Created by Ivan Martsilenko K-24

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Graph
    {


    }

    /// <summary>
    /// public class Coordinate create field with Decard coordinate system
    /// </summary>
    public class Coordinate
    {
        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
    }

}
