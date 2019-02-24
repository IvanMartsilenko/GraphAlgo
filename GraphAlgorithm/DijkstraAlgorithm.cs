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
    class DijkstraAlgorithm : Node
    {
        public List<Node> ShortestPath { get; private set; }
        private List<Node> VisitedNodes { get; }
        private static Graph InnerGraph { get; set; }
        private int Index { get; set; }


        public DijkstraAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            ShortestPath = InnerGraph.SetOfNodes;

            VisitedNodes = new List<Node>();

            SetInfinityWeightsForNode(ShortestPath);
        }

    }
    }
