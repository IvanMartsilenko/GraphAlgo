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
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
    }

    /// <summary>
    /// class Node connected to class Coodinate and class Edge
    /// </summary>
    public class Node
    {
        public Coordinate Coordinate { get; private set; }
        public string Name { get; set; }

        public Node[] Incomers { get; set; }

        public double HeuristicCost { get; set; }
        public double PastWayCost { get; set; }
        public double TotalPathCost { get; set; }

        public override bool Equals(object Object)
        {
            Node Node = (Node)Object;

            return this.Name.Equals(Node.Name);
        }
    }


}
