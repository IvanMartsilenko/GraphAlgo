// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// 1st algo

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


    }
}
