using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void BFS_Click(object sender, EventArgs e)
        {
            DrawResult(BFS.ResultOfSearching);
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BFS = new BreadthFirstSearchAlgorithm(Graph);
        }

        public Graphics Circle { get; set; }
        public void DrawNameOfNode()
        {
            Circle.DrawString(Name, new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.Blue), CoordinateX + 3, CoordinateY + 5);
        }
        public void MarkNodeAsUnVisited()
        {
            Circle.DrawEllipse(new Pen(Color.Black, 2), X, Y, 35, 35);
        }
        public void MarkNodeAsVisited()
        {
            Circle.DrawEllipse(new Pen(Color.MintCream, 3), X, Y, 35, 35);
        }

        private void Reset(bool DrawNameOfEdge)
        {
            Visualizer.Refresh();

            for (int Index = 0; Index < Graph.NumberOfNodes; Index++)
            {
                Graph.SetOfNodes[Index].MarkNodeAsUnVisited();
            }

            for (int Index = 0; Index < Graph.NumberOfEdges; Index++)
            {
                Graph.SetOfEdges[Index].MarkEdgeAsUnVisited();

                if (DrawNameOfEdge.Equals(true))
                {
                    Graph.SetOfEdges[Index].DrawNameOfEdge();
                }
            }

            for (int Index = 0; Index < Graph.NumberOfNodes; Index++)
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


    }
}
