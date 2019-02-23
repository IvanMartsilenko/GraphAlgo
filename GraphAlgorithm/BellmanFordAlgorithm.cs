using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class BellmanFordAlgorithm : Node
    {
        public List<Node> ShortestPath { get; private set; }
        private static Graph InnerGraph { get; set; }
        public BellmanFordAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            ShortestPath = InnerGraph.SetOfNodes;
            SetInfinityWeightsForNode ( ShortestPath);
        }
        public bool FindTheShortestPath(Node Start)
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
