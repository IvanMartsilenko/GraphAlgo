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
        private Graph Graph { get; set; }
        private static DataLoading Load = new DataLoading();

        private BreadthFirstSearchAlgorithm BFS { get; set; }
        private DepthFirstSearchAlgorithm DFS { get; set; }
        private KruscalAlgorithm Kruscal { get; set; }
        private PrimaAlgorithm Prima { get; set; }
        private BellmanFordAlgorithm BellmanFord { get; set; }
        private DijkstraAlgorithm Dijkstra { get; set; }
        private Floyd_WarshallAlgorithm Floyd_Warshall { get; set; }
        private JohnsonAlgorithm Johnson { get; set; }
        private FordFulkersonAlgorithm FordFulkerson { get; set; }
        private A_Star A_Star { get; set; }


        static void Main(string[] args)
        {
            // data loading module 
            {
                Load.LoadNodes(Graph);
                Load.LoadEdges(Graph);
            }
            Console.WriteLine("Loading finished");


                Console.ReadKey();
        }
    }

}
