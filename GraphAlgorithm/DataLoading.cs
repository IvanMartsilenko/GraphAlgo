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
        public void LoadNodes(Graph GraphEx)
        {
            foreach (string line in File.ReadLines(@"C:\Users\Ivan\source\repos\GraphAlgorithm\GraphAlgorithm\bin\GraphData\nodes.txt"))
            {
                string[] param = line.Split(new char[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
                GraphEx.AddNode(new Node(Convert.ToInt32(param[0]), param[1], new Coordinate(Convert.ToInt32(param[2]), Convert.ToInt32(param[3]))));
            }
        }

        public void LoadTwoWayEdges(Graph GraphEx)
        {
            foreach (string line in File.ReadLines(@"C:\Users\Ivan\source\repos\GraphAlgorithm\GraphAlgorithm\bin\GraphData\twowayedges.txt"))
            {
                string[] param = line.Split(new char[] { ' ' }, 3, StringSplitOptions.RemoveEmptyEntries);
                GraphEx.AddTwoWayEdge(new Edge(Convert.ToInt32(param[0]), GraphEx.SetOfNodes[Convert.ToInt32(param[1])], GraphEx.SetOfNodes[Convert.ToInt32(param[2])]));
            }
        }
    }
}
