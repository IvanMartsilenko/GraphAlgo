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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Root"> start of our research</param>
        /// <returns></returns>
        private Node FindSubTree(Node Root)
        {
            Node OldNode = new Node();
            Node RootOfTree = Root;
            for (; !RootOfTree.Equals(InnerGraph.SetOfNodes[RootOfTree.Index]);)
            {
                RootOfTree = InnerGraph.SetOfNodes[RootOfTree.Index];
            }
            for (; !Root.Equals(RootOfTree);)
            {
                OldNode = InnerGraph.SetOfNodes[Root.Index];

                InnerGraph.SetOfNodes[Root.Index] = RootOfTree;

                Root = OldNode;
            }
            return RootOfTree;
        }
        /// <summary>
        /// Using Findsub tree develop from starting tree (root) to minimum spanning tree
        /// Don't if it should be bool type</summary>
        /// <returns></returns>
        public bool KruskalSMSTAlgorithm()
        {
            InnerGraph.SetOfEdges = InnerGraph.SetOfEdges.OrderBy(Edge => Edge.Weight).ToList<Edge>();
            for (int Index = 0; Index < InnerGraph.QuantityOfEdges; Index++)
            {
                Node StartNode = FindSubTree(InnerGraph.SetOfEdges[Index][0]);
                Node EndNode = FindSubTree(InnerGraph.SetOfEdges[Index][1]);
                if (!StartNode.Equals(EndNode))
                {
                    MinimumSpanningTree.Add(InnerGraph.SetOfEdges[Index]);
                    InnerGraph.SetOfNodes[EndNode.Index] = StartNode;
                }
            }
            return true;
        }
    }
}
