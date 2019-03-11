// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// Data Loading Module 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphAlgorithm
{
    class DataLoading : Program
    {
        private void LoadNodes(Graph Graph, Graph GraphEx)
        {
            foreach (string line in File.ReadLines(@"C:\Users\Ivan\source\repos\GraphAlgorithm\GraphAlgorithm\bin\GraphData\nodes.txt"))
            {
                string[] param = line.Split(new char[] { ' ' }, 5, StringSplitOptions.RemoveEmptyEntries);
                if (param[4] == "1")
                {
                    GraphEx.AddNode(new Node(Convert.ToInt32(param[0]), param[1], new Coordinate(Convert.ToInt32(param[2]), Convert.ToInt32(param[3]))));
                }
                else
                {
                    Graph.AddNode(new Node(Convert.ToInt32(param[0]), param[1], new Coordinate(Convert.ToInt32(param[2]), Convert.ToInt32(param[3]))));
                }
            }
        }

        private void LoadEdges(Graph Graph, Graph GraphEx)
        {
            foreach (string line in File.ReadLines(@"C:\Users\Ivan\source\repos\GraphAlgorithm\GraphAlgorithm\bin\GraphData\edges.txt"))
            {
                string[] param = line.Split(new char[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToBoolean(param[3]))
                {
                    GraphEx.AddOneWayEdge(new Edge(Convert.ToInt32(param[0]), GraphEx.SetOfNodes[Convert.ToInt32(param[1])], GraphEx.SetOfNodes[Convert.ToInt32(param[2])]));
                }
                else
                {
                    Graph.AddTwoWayEdge(new Edge(Convert.ToInt32(param[0]), GraphEx.SetOfNodes[Convert.ToInt32(param[1])], GraphEx.SetOfNodes[Convert.ToInt32(param[2])]));
                }
            }
        }

        public void LoadGraph (Graph Graph, Graph GraphEx)
        {
            LoadNodes(Graph, GraphEx);
            LoadEdges(Graph, GraphEx);
        }
    }
}
