using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    public class KruscalAlgorithm
    {
        public List<Edge> MinimumSpanningTree { get; }
        private static Graph InnerGraph { get; set; }
        public KruscalAlgorithm(Graph Graph)
        {
            MinimumSpanningTree = new List<Edge>();
            InnerGraph = (Graph)Graph.Clone();
        }


    }
}
