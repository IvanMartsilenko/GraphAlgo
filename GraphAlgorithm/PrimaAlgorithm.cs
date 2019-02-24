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
    public class PrimaAlgorithm
    {
        public List<Edge> MinimumSpanningTree { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }

       public PrimaAlgorithm(Graph Graph)
       {
           MinimumSpanningTree = new List<Edge>();
           InnerGraph = (Graph)Graph.Clone();
           VisitedNodes = new List<Node>();
       }
        public bool PrimaSMSTAlgorithm()
        {
        VisitedNodes.Add(InnerGraph.SetOfNodes[0]);

        for (; VisitedNodes.Count < InnerGraph.QuantityOfNodes;)
        {
            Node Start = new Node();
            Node Finish = new Node();
            // maybe throw infinity to group of special onjects and instruments fo algorithm
            Edge CurrentEdge = new Edge { Weight = double.PositiveInfinity };
            for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
            {
                if (VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                {
                    foreach (Node Incomer in InnerGraph.SetOfNodes[Index].Incomers.Where(Node => Node != null 
                                              && !VisitedNodes.Contains(Node)))
                    {
                        if (CurrentEdge.Weight > InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], Incomer).Weight)
                        {
                            CurrentEdge = InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], Incomer);
                            Start = CurrentEdge[0];
                            Finish = CurrentEdge[1];
                        }
                    }
                }
            }
            VisitedNodes.Add(Finish);
            MinimumSpanningTree.Add(InnerGraph.FindEdge(Start, Finish));
        }
        return VisitedNodes.Count.Equals(InnerGraph.QuantityOfNodes);
        }

    }
}
