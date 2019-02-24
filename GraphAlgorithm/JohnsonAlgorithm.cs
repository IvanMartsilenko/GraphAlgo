using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class JohnsonAlgorithm
    {
        private static DijkstraAlgorithm DijkstraPathSearch { get; set; }
        private static Graph InnerGraph { get; set; }
        public double[,] MatrixOfTheShortesPathes { get; private set; }

        public JohnsonAlgorithm(Graph Graph)
        {
            MatrixOfTheShortesPathes = new double[Graph.QuantityOfNodes, Graph.QuantityOfNodes];
            InnerGraph = (Graph)Graph.Clone();
        }
    }
}
