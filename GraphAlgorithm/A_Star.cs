// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// algo module 

using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithm
{
    class A_Star
    {
        private static Graph InnerGraph { get; set; }
        private List<Node> ActualNodes { get; set; }
        private List<Node> ClosedNodes { get; set; }
        private List<Node> VisitedNodes { get; }
        public List<Edge> ShortesPath { get; }

        public A_Star(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            ClosedNodes = new List<Node>();
            ActualNodes = new List<Node>();
            VisitedNodes = new List<Node>();
            ShortesPath = new List<Edge>();
        }

        private double HeruisticPath(Node Start, Node Target)
        {
            return Math.Sqrt(Math.Pow(Start.Coordinate.X - Target.Coordinate.X, 2) + Math.Pow(Start.Coordinate.Y - Target.Coordinate.Y, 2));
        }

        public bool A_StarAlgorithm(Node Start, Node Target)
        {
            Node CurrentNode = Start;

            ActualNodes.Add(CurrentNode);

            for (; ActualNodes.Count > 0;)
            {
                CurrentNode = ActualNodes[0];

                if (CurrentNode.Equals(Target))
                {
                    VisitedNodes.Add(Target);

                    for (int Index = 0; Index < VisitedNodes.Count - 1; Index++)
                    {
                        ShortesPath.Add(InnerGraph.FindEdge(VisitedNodes[Index], VisitedNodes[Index + 1]));
                    }

                    return true;
                }

                ActualNodes.Remove(CurrentNode);

                ClosedNodes.Add(CurrentNode);

                foreach (Node Incomer in CurrentNode.Incomers.Where(Node => Node != null && Node.Index != Node.Incomers.Length - 1))
                {
                    if (!ClosedNodes.Contains(Incomer))
                    {
                        if (!ActualNodes.Contains(Incomer))
                        {
                            Incomer[Incomer.Index] = CurrentNode;

                            Incomer.HeuristicCost = HeruisticPath(Incomer, Target);

                            Incomer.PastWayCost = InnerGraph.FindEdge(CurrentNode, Incomer).Weight;

                            Incomer.TotalPathCost = Incomer.PastWayCost + Incomer.HeuristicCost;

                            ActualNodes.Add(Incomer);

                            ActualNodes = ActualNodes.OrderBy(Node => Node.TotalPathCost).ToList<Node>();
                        }
                    }
                }

                VisitedNodes.Add(CurrentNode);
            }

            return true;
        }
    }
}
