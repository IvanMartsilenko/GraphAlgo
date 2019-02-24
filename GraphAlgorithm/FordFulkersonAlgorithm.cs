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
        public bool FordFulkersonBFSTypeAlgorithm(Node Start, Node Target)
        {
            if (Start.Equals(Target))
            {
                CapacityOfFlow = 0.0;
                return true;
            }
            Node CurrentNode = new Node();
            for (; BreadthFirstSearch.BreadthFirstSearch(Start, Target, Path);)
            {
                double CurrentStreamCapacity = double.PositiveInfinity;
                for (int Index = Target.Index; Index != Start.Index; Index = Path[Index].Index)
                {
                    CurrentNode = Path[Index];
                    if (CurrentStreamCapacity < InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight)
                        CurrentStreamCapacity = InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight;
                }
                for (int Index = Target.Index; Index != Start.Index; Index = Path[Index].Index)
                {
                    InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight -= CurrentStreamCapacity;
                    InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], CurrentNode).Weight += CurrentStreamCapacity;
                }
                CapacityOfFlow += CurrentStreamCapacity;
                BreadthFirstSearch = new BreadthFirstSearchAlgorithm(InnerGraph);
            }
            return true;
        }
    }
}
