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
    class A_Star
    {
        private static Graph InnerGraph { get; set; }
        private List<Node> ActualNodes { get; set; }
        private List<Node> ClosedNodes { get; set; }
        private List<Node> VisitedNodes { get; }
        public List<Edge> ShortesPath { get; }

        public A_Star(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();
            ClosedNodes = new List<Node>();
            ActualNodes = new List<Node>();
            VisitedNodes = new List<Node>();
            ShortesPath = new List<Edge>();
        }
    }
}
