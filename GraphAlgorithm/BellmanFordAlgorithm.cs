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
            SetInfinityWeightsForNode(ShortestPath);
        }
        
    }
}
