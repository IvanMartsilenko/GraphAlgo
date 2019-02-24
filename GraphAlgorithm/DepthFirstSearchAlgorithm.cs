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
    public class DepthFirstSearchAlgorithm
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

        /// <summary>
        ///  that type of DFS that start from one Node ( that give as param) and researche all graph </summary>
        /// <param name="Start">< Node that our research start>
        /// <returns> true if we find all Nodes</returns>
        public bool DepthFirstSearch(Node Start)
        {
            VisitedNodes.Add(Start);
            for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null 
                    && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                {
                    ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));
                    DepthFirstSearch(InnerGraph.SetOfNodes[Index]);
                }
            }
            return VisitedNodes.Count.Equals(InnerGraph.QuantityOfNodes);
        }

        /// <summary>
        /// that type of DFS that start from one Node ( that give as param) and researche targeted node. </summary>
        /// <param name="Start"> first Node in queue</param>
        /// <param name="Target"> Scope of our researche</param>
        /// <param name="FoundPath"></param>
        /// <returns> True if we find target (target in list of visited nodes)</returns>
        public bool DepthFirstSearch(Node Start, Node Target, Node[] FoundPath)
        {
            VisitedNodes.Add(Start);
            if (VisitedNodes.Contains(Target))
            {
                return true;
            }
            for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null 
                    && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]) 
                    && InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]).Weight > 0)
                {
                    FoundPath[Index] = Start;
                    if (DepthFirstSearch(InnerGraph.SetOfNodes[Index], Target, FoundPath))
                    {
                        return true;
                    }
                }
            }
            return VisitedNodes.Contains(Target);
        }
    }
}
