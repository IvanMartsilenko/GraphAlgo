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
    class DijkstraAlgorithm : Node
    {
        public List<Node> ShortestPath { get; private set; }
        private List<Node> VisitedNodes { get; }
        private static Graph InnerGraph { get; set; }

        public DijkstraAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            ShortestPath = InnerGraph.SetOfNodes;
            VisitedNodes = new List<Node>();
            SetInfinityWeightsForNode(ShortestPath);
        }
        public bool DijkstraSWSAlgorithm(Node Start)
        {
            ShortestPath[Start.Index].Weight = 0;

            for (int FirstIndex = 0; FirstIndex < InnerGraph.QuantityOfNodes - 1; FirstIndex++)
            {
                Node CurrentNode = new Node { Weight = double.PositiveInfinity };
                for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                {
                    if (!VisitedNodes.Contains(ShortestPath[SecondIndex]) && ShortestPath[SecondIndex].Weight <= CurrentNode.Weight)
                    {
                        CurrentNode = ShortestPath[SecondIndex];
                        Index = ShortestPath[SecondIndex].Index;
                    }
                }
                VisitedNodes.Add(ShortestPath[Index]);
                for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                {
                    if (!VisitedNodes.Contains(ShortestPath[SecondIndex]) && InnerGraph.SetOfNodes[Index][SecondIndex] != null 
                        && !ShortestPath[Index].Weight.Equals(double.PositiveInfinity) 
                        && ShortestPath[SecondIndex].Weight > 
                        ShortestPath[Index].Weight + InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], InnerGraph.SetOfNodes[SecondIndex]).Weight)

                    {
                    ShortestPath[SecondIndex].Weight = ShortestPath[Index].Weight + InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], InnerGraph.SetOfNodes[SecondIndex]).Weight;
                    }
                }
            }

            return InnerGraph.NegativeCycleChecker(ShortestPath);
        }
    }
    }
