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
        private static BellmanFordAlgorithm BellmanFordPathSearch { get; set; }
        private static Graph InnerGraph { get; set; }
        private static Graph AuxiliaryGraph { get; set; }
        public double[,] MatrixOfTheShortesPathes { get; private set; }

        public JohnsonAlgorithm(Graph Graph)
        {
            MatrixOfTheShortesPathes = new double[Graph.QuantityOfNodes, Graph.QuantityOfNodes];
            InnerGraph = (Graph)Graph.Clone();
            AuxiliaryGraph = (Graph)Graph.Clone();
        }
        public bool FindAllTheShortestPathes()
        {
            AuxiliaryGraph.AddNode(new Node(AuxiliaryGraph.QuantityOfNodes, "Temporary"));

            for (int Index = 0; Index < AuxiliaryGraph.QuantityOfNodes - 1; Index++)
            {
                AuxiliaryGraph.AddTwoWayEdge(new Edge(0, AuxiliaryGraph.SetOfNodes[AuxiliaryGraph.QuantityOfNodes - 1], AuxiliaryGraph.SetOfNodes[Index]));
            }

            BellmanFordPathSearch = new BellmanFordAlgorithm(AuxiliaryGraph);

            if (BellmanFordPathSearch.BellmanFordShortestPathSearchAlgorithm(AuxiliaryGraph.SetOfNodes[AuxiliaryGraph.QuantityOfNodes - 1]))
            {
                for (int FirstIndex = 0; FirstIndex < InnerGraph.QuantityOfNodes; FirstIndex++)
                {
                    DijkstraPathSearch = new DijkstraAlgorithm(InnerGraph);

                    DijkstraPathSearch.DijkstraSWSAlgorithm(InnerGraph.SetOfNodes[FirstIndex]);

                    for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = DijkstraPathSearch.ShortestPath[SecondIndex].Weight;
                    }
                }

                return true;
            }
            else
            {
                for (int Index = 0; Index < InnerGraph.QuantityOfEdges; Index++)
                {
                    InnerGraph.SetOfEdges[Index].Weight = 
                        InnerGraph.SetOfEdges[Index].Weight + 
                        BellmanFordPathSearch.ShortestPath[InnerGraph.SetOfEdges[Index][0].Index].Weight - 
                        BellmanFordPathSearch.ShortestPath[InnerGraph.SetOfEdges[Index][1].Index].Weight;
                }

                for (int FirstIndex = 0; FirstIndex < InnerGraph.QuantityOfNodes; FirstIndex++)
                {
                    DijkstraPathSearch = new DijkstraAlgorithm(InnerGraph);

                    DijkstraPathSearch.DijkstraSWSAlgorithm(InnerGraph.SetOfNodes[FirstIndex]);

                    for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = DijkstraPathSearch.ShortestPath[SecondIndex].Weight;
                    }
                }
            }

            return true;
        }

    }
}
