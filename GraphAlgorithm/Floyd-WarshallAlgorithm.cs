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
    class Floyd_WarshallAlgorithm
    {
        private static Graph InnerGraph { get; set; }
        public double[,] MatrixOfTheShortesPathes { get; private set; }

        public Floyd_WarshallAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            MatrixOfTheShortesPathes = new double[Graph.QuantityOfNodes, Graph.QuantityOfNodes];
            // Initialise MatrixOfTheShortestPathes
            for (int FirstIndex = 0; FirstIndex < InnerGraph.QuantityOfNodes; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                {
                    if (InnerGraph.SetOfNodes[FirstIndex][SecondIndex] != null)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = InnerGraph.FindEdge(InnerGraph.SetOfNodes[FirstIndex], InnerGraph.SetOfNodes[SecondIndex]).Weight;
                    }
                    else
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = double.PositiveInfinity;
                    }
                }
            }
        }
        public void Floyd_WarshalSATSPAlgorithm()
        {
            for (int Index = 0; Index < InnerGraph.QuantityOfNodes; Index++)
            {
                MatrixOfTheShortesPathes[Index, Index] = 0;
            }

            for (int FirstIndex = 0; FirstIndex < InnerGraph.QuantityOfNodes; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.QuantityOfNodes; SecondIndex++)
                {
                    for (int ThirdIndex = 0; ThirdIndex < InnerGraph.QuantityOfNodes; ThirdIndex++)
                    {
                        if (MatrixOfTheShortesPathes[SecondIndex, ThirdIndex] >
                            MatrixOfTheShortesPathes[SecondIndex, FirstIndex] + MatrixOfTheShortesPathes[FirstIndex, ThirdIndex])
                        {
                            MatrixOfTheShortesPathes[SecondIndex, ThirdIndex] = MatrixOfTheShortesPathes[SecondIndex, ThirdIndex];
                        }
                        else
                        {
                            MatrixOfTheShortesPathes[SecondIndex, ThirdIndex] =
                                MatrixOfTheShortesPathes[SecondIndex, FirstIndex] + MatrixOfTheShortesPathes[FirstIndex, ThirdIndex];
                        }
                    }
                }
            }
        }
    }

}
