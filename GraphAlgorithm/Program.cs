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
        private Graph Graph = new Graph();
        private DataLoading Load = new DataLoading();

        private BreadthFirstSearchAlgorithm BFS = new BreadthFirstSearchAlgorithm(Graph);
        private DepthFirstSearchAlgorithm DFS = new DepthFirstSearchAlgorithm(Graph);
        private KruscalAlgorithm Kruscal = new KruscalAlgorithm(Graph);
        private PrimaAlgorithm Prima = new PrimaAlgorithm(Graph);
        private BellmanFordAlgorithm BellmanFord = new BellmanFordAlgorithm(Graph);
        private DijkstraAlgorithm Dijkstra = new DijkstraAlgorithm(Graph);
        private Floyd_WarshallAlgorithm Floyd_Warshall = new Floyd_WarshallAlgorithm(Graph);
        private JohnsonAlgorithm Johnson = new JohnsonAlgorithm(Graph);
        private FordFulkersonAlgorithm FordFulkerson = new FordFulkersonAlgorithm(Graph);
        private A_Star A_Star = new A_Star(Graph);

        static void Main(string[] args)
        { 
                Console.ReadKey();
        }
    }

}
