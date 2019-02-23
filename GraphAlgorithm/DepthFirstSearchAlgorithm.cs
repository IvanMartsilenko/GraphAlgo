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
    }
}
