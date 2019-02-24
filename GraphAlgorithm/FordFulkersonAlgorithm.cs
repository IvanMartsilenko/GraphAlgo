// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// algo module 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class FordFulkersonAlgorithm
    {
        private static BreadthFirstSearchAlgorithm BreadthFirstSearch { get; set; }
        private static Graph InnerGraph { get; set; }
        private Node[] Path { get; set; }
        public double CapacityOfFlow { get; private set; }
        public FordFulkersonAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            BreadthFirstSearch = new BreadthFirstSearchAlgorithm(InnerGraph);
            Path = new Node[InnerGraph.QuantityOfNodes];
            CapacityOfFlow = 0.0;
        }
    }
}
