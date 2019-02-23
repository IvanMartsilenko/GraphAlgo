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
     
    }
}
