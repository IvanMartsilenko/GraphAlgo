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
    public class BellmanFordAlgorithm : Node
    {
        public List<Node> ShortestPath { get; private set; }
        private static Graph InnerGraph { get; set; }
        public BellmanFordAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            ShortestPath = InnerGraph.SetOfNodes;
            SetInfinityWeightsForNode ( ShortestPath);
        }
        public bool BellmanFordShortestPathSearchAlgorithm(Node Start)
        {
            ShortestPath[Start.Index].Weight = 0;

            for (int FirstIndex = 1; FirstIndex < InnerGraph.QuantityOfNodes - 1; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfEdges; SecondIndex++)
                {
                    if (ShortestPath[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight >
                        ShortestPath[InnerGraph.SetOfEdges[SecondIndex][0].Index].Weight + InnerGraph.SetOfEdges[SecondIndex].Weight)
                    {
                        ShortestPath[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight =
                            ShortestPath[InnerGraph.SetOfEdges[SecondIndex][0].Index].Weight + InnerGraph.SetOfEdges[SecondIndex].Weight;
                    }
                    else
                    ShortestPath[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight = ShortestPath[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight; 
                                   
                }
            }

            return InnerGraph.NegativeCycleChecker(ShortestPath);
        }
    }
}
