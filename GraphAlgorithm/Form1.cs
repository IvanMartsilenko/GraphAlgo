using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics Circle { get; set; }

        private void BFS_Click(object sender, EventArgs e)
        {
            DrawResult(BFS.ResultOfSearching);
        }

        private void DFS_Click(object sender, EventArgs e)
        {

        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BFS = new BreadthFirstSearchAlgorithm(Graph);
            DFS = new DepthFirstSearchAlgorithm(Graph);
            Kruscal = new KruscalAlgorithm(Graph);
            Prima = new PrimaAlgorithm(Graph);
            BellmanFord = new BellmanFordAlgorithm(Graph);
            Dijkstra = new DijkstraAlgorithm(Graph);
            Floyd_Warshall = new Floyd_WarshallAlgorithm(Graph);
            Johnson = new JohnsonAlgorithm(Graph);
            FordFulkerson = new FordFulkersonAlgorithm(Graph);
            A_Star = new A_Star(Graph);
        }


        private void Reset(bool DrawNameOfEdge)
        {
            Visualizer.Refresh();

            for (int Index = 0; Index < Graph.QuantityOfNodes; Index++)
            {
                Graph.QuantityOfNodes[Index].MarkNodeAsUnVisited();
            }

            for (int Index = 0; Index < Graph.QuantityOfEdges; Index++)
            {
                Graph.SetOfEdges[Index].MarkEdgeAsUnVisited();

                if (DrawNameOfEdge.Equals(true))
                {
                    Graph.SetOfEdges[Index].DrawNameOfEdge();
                }
            }

            for (int Index = 0; Index < Graph.QuantityOfNodes; Index++)
            {
                Graph.SetOfNodes[Index].FillCircle();

                Graph.SetOfNodes[Index].DrawNameOfNode();
            }
        }
        private void DrawResult(List<Edge> Edges)
        {
            Reset(true);

            for (int Index = 0; Index < Edges.Count; Index++)
            {
                Edges[Index][0].MarkNodeAsVisited();

                Edges[Index][0].FillCircle();

                Edges[Index][0].DrawNameOfNode();

                Thread.Sleep(500);

                Edges[Index].MarkEdgeAsVisited();

                Edges[Index].DrawNameOfEdge();

                Edges[Index][0].FillCircle();

                Edges[Index][0].DrawNameOfNode();

                Edges[Index][1].FillCircle();

                Edges[Index][1].DrawNameOfNode();

                Thread.Sleep(500);

                Edges[Index][1].MarkNodeAsVisited();

                Thread.Sleep(500);
            }
        }
        public void FillCircle()
        {
            Circle.FillEllipse(new SolidBrush(Color.Silver), CoordinateX + 2, CoordinateY + 2, 31, 31);
        }

    }
}
    
