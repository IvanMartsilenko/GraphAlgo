using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class DepthFirstSearchAlgorithm
    {
        public List<Edge> ResultOfSearching { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }
        public DepthFirstSearchAlgorithm(Graph Graph)
        {

            InnerGraph = (Graph)Graph.Clone();
            ResultOfSearching = new List<Edge>();
            VisitedNodes = new List<Node>();
        }

        ///  that type of DFS that start from one Node ( that give as param) and researche all graph
        /// 
        /// <param name="Start">< Node that our research start>
        /// <returns> true if we find all Nodes</returns>
        public bool DepthFirstSearch(Node Start)
        {
            VisitedNodes.Add(Start);
            for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                {
                    ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));
                    DepthFirstSearch(InnerGraph.SetOfNodes[Index]);
                }
            }
            return VisitedNodes.Count.Equals(InnerGraph.QuantityOfNodes);
        }
    }
}
