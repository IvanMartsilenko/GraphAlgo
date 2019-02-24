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
    public class BreadthFirstSearchAlgorithm
    {
        public List<Edge> ResultOfSearching { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }
        private Queue<Node> Queue { get; }

        public BreadthFirstSearchAlgorithm(Graph Graph)
        {
            Queue = new Queue<Node>();
            InnerGraph = (Graph)Graph.Clone();
            ResultOfSearching = new List<Edge>();
            VisitedNodes = new List<Node>();
        }

        /// bool  BreadthFirstSearch(Node Start) starting from StartNode
        /// adding that Node in queue, afterthat starting cycle for all Graph
        /// </summary>
        /// <param name="Start"></param> - first Node
        /// <returns></returns>
        public bool BreadthFirstSearch(Node Start)
        {
            Queue.Enqueue(Start);

            VisitedNodes.Add(Start);

            for (; Queue.Count > 0;)
            {
                Start = Queue.Dequeue();
                for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
                {
                    if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                    {
                        ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));
                        Queue.Enqueue(InnerGraph.SetOfNodes[Index]);
                        VisitedNodes.Add(InnerGraph.SetOfNodes[Index]);
                    }
                }
            }
            return VisitedNodes.Count.Equals(InnerGraph.QuantityOfNodes);
        }

        /// 
        /// bfs var 2  
        /// searching path to target node from some start node
        /// 
        /// <param name="Start"> - first node
        /// <param name="Target"> - our scope
        /// <param name="Path"> - for our scope
        /// <returns></returns>
        public bool BreadthFirstSearch(Node Start, Node Target, Node[] Path)
        {
            Queue.Enqueue(Start);

            VisitedNodes.Add(Start);

            Path[Start.Index] = Start;

            if (VisitedNodes.Contains(Target))
            {
                return true;
            }

            for (; Queue.Count > 0;)
            {
                Start = Queue.Dequeue();

                for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
                {
                    if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]) && InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]).Weight > 0)
                    {
                        Path[Index] = Start;

                        Queue.Enqueue(InnerGraph.SetOfNodes[Index]);

                        VisitedNodes.Add(InnerGraph.SetOfNodes[Index]);
                    }
                }
            }

            return VisitedNodes.Contains(Target);
        }


    }
}
