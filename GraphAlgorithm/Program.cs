// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class Program
    {
        private static Graph Graph = new Graph();
        private static DataLoading Load = new DataLoading(); 
        static void Main(string[] args)
        {
            Load.LoadNodes(Graph);
            Load.LoadOneWayEdges(Graph);
            Load.LoadTwoWayEdges(Graph);
            Console.WriteLine("Loading finished");
            Console.ReadKey();
        }
    }

}
