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
        private static BellmanFordAlgorithm BellmanFord = new BellmanFordAlgorithm(Graph);
        private static DijkstraAlgorithm Dijkstra = new DijkstraAlgorithm(Graph);
        private static Floyd_WarshallAlgorithm Floyd_Warshall = new Floyd_WarshallAlgorithm(Graph);
        private static JohnsonAlgorithm Johnson = new JohnsonAlgorithm(Graph);
        private static FordFulkersonAlgorithm FordFulkerson = new FordFulkersonAlgorithm(Graph);
        private static A_Star A_Star = new A_Star(Graph);

        static void Main(string[] args)
        {
            // data loading module 
            {
                Load.LoadNodes(Graph);
                Load.LoadOneWayEdges(Graph);
                Load.LoadTwoWayEdges(Graph);
            }

            Console.WriteLine("Loading finished");
            // algo module

            {
                BFS.BreadthFirstSearch(Graph.SetOfNodes[0]);
            }
            {
                DFS.DepthFirstSearch(Graph.SetOfNodes[0]);
            }
            {
                Kruscal.KruskalSMSTAlgorithm();
            }
            {
                Prima.PrimaSMSTAlgorithm();
            }
            {
                BellmanFord.BellmanFordShortestPathSearchAlgorithm(Graph.SetOfNodes[0]);
            }
            {
                Dijkstra.DijkstraSWSAlgorithm(Graph.SetOfNodes[0]);
            }
            {
                Floyd_Warshall.Floyd_WarshalSATSPAlgorithm();
            }
            {
                Johnson.JonhsonFATSPAlgorithm();
            }
            {
                FordFulkerson.FordFulkersonBFSTypeAlgorithm(Graph.SetOfNodes[0], Graph.SetOfNodes[1]);
            }
            {
                A_Star.A_StarAlgorithm(Graph.SetOfNodes[0], Graph.SetOfNodes[1]);
            }

                Console.ReadKey();
        }
    }

}
