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
        public void LoadNodes( Graph GraphEx)
        {
            foreach (string line in File.ReadLines(@"C:\Users\Ivan\source\repos\GraphAlgorithm\GraphAlgorithm\bin\GraphData\nodes.txt"))
            {
                string[] words = line.Split(new char[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
                GraphEx.AddNode(new Node(Convert.ToInt32(words[0]), words[1], new Coordinate(Convert.ToInt32(words[2]), Convert.ToInt32(words[3]))));
            }
        }
    }
}
