// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// main part

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

        private static BreadthFirstSearchAlgorithm BFS = new BreadthFirstSearchAlgorithm(Graph);
        private static DepthFirstSearchAlgorithm DFS = new DepthFirstSearchAlgorithm(Graph);
        private static KruscalAlgorithm Kruscal = new KruscalAlgorithm(Graph);
        private static PrimaAlgorithm Prima = new PrimaAlgorithm(Graph);
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
