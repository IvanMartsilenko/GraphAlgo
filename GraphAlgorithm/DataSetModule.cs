// Created by Ivan Martsilenko
// Lab 1 Sem 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    public class Graph : ICloneable
    {
        public List<Node> SetOfNodes { get; set; }
        public List<Edge> SetOfEdges { get; set; }
        public Graph()
        {
            SetOfNodes = new List<Node>();
            SetOfEdges = new List<Edge>();
        }
        public int QuantityOfNodes { get { return SetOfNodes.Count; } }
        public int QuantityOfEdges { get { return SetOfEdges.Count; } }

        public void AddNode(Node Node)
        {
            SetOfNodes.Add(Node);
            SetOfNodes[SetOfNodes.Count - 1].Index = SetOfNodes.Count - 1;
        }
        public void AddOneWayEdge(Edge Edge)
        {
            SetOfEdges.Add(Edge);
            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;
        }
        public void AddTwoWayEdge(Edge Edge)
        {
            SetOfEdges.Add(Edge);
            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;
            SetOfEdges.Add(new Edge(Edge.Weight, Edge[1], Edge[0]));
            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;
        }
        public Edge FindEdge(params Node[] Nodes)
        {
            for (int Index = 0; Index < QuantityOfEdges; Index++)
            {
                if (SetOfEdges[Index][0].Equals(Nodes[0]) && SetOfEdges[Index][1].Equals(Nodes[1]))
                {
                    return SetOfEdges[Index];
                }
            }

            return new Edge { Weight = double.PositiveInfinity };
        }
        public object Clone()
        {
            List<Node> SetOfNodes = new List<Node>();
            List<Edge> SetOfEdges = new List<Edge>();
            Graph Graph = new Graph
            {
                SetOfNodes = SetOfNodes,
                SetOfEdges = SetOfEdges
            };
            for (int Index = 0; Index < QuantityOfNodes; Index++)
            {
                SetOfNodes.Add((Node)this.SetOfNodes[Index].Clone());
            }
            for (int Index = 0; Index < QuantityOfEdges; Index++)
            {
                SetOfEdges.Add((Edge)this.SetOfEdges[Index].Clone());
            }
            return Graph;
        }

        public bool NegativeCycleChecker(List<Node> Nodes)
        {
            for (int Index = 0; Index < QuantityOfEdges; Index++)
            {
                if (Nodes[SetOfEdges[Index][1].Index].Weight > Nodes[SetOfEdges[Index][0].Index].Weight + SetOfEdges[Index].Weight)
                {
                    return false;
                }
            }
            return true;
        }
    }

    /// <summary>
    /// class Node connected to class Coodinate and class Edge
    /// </summary>
    public class Node : ICloneable
    {
        public Coordinate Coordinate { get; private set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Node[] Incomers { get; set; }

        // need for A*, TotalPathCost = PastWayCost + HeuristicCost;
        public double HeuristicCost { get; set; }
        public double PastWayCost { get; set; }
        public double TotalPathCost { get; set; }

        Circle = Box.CreateGraphics();

        Circle.SmoothingMode = SmoothingMode.HighQuality;

        Circle.DrawEllipse(new Pen(Color.Black, 2), CoordinateX, CoordinateY, 35, 35);

        public int Index { get; set; }

        protected void SetInfinityWeightsForNode(List<Node> Nodes)
        {
            Nodes[Index].Weight = double.PositiveInfinity;
        }

        public override bool Equals(object Object)
        {
            Node Node = (Node)Object;
            return this.Name.Equals(Node.Name);
        }

        // need for realization of ICloneable interface
        public object Clone()
        {
            Node Node = new Node
            {
                Coordinate = this.Coordinate,
                Incomers = this.Incomers,
                Name = this.Name,
                Index = this.Index,
                Weight = this.Weight,
            };
            return Node;
        }

        public Node()
        {
            HeuristicCost = 0.0;
            PastWayCost = 0.0;
            TotalPathCost = 0.0;
            Name = string.Empty;
            Coordinate = null;
            Incomers = null;
            Index = 0;
            Weight = 0.0;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index < Incomers.Length)
                {
                    return Incomers[Index];
                }
                return null;
            }
            set
            {
                if (Index >= 0 && Index < Incomers.Length)
                {
                    Incomers[Index] = value;
                }
            }
        }

        public Node(int NumberOfIncomers, string Name, Coordinate Coordinate)
        {
            Incomers = new Node[NumberOfIncomers + 1];

            this.Coordinate = Coordinate;

            this.Name = $"[{Name}]";

            Index = 0;
        }
        public Node(int NumberOfIncomers, string Name)
        {
            Incomers = new Node[NumberOfIncomers + 1];

            this.Name = $"[{Name}]";

            Index = 0;
        }

        public void MarkNodeAsUnVisited()
        {
            Circle.DrawEllipse(new Pen(Color.Black, 2), CoordinateX, CoordinateY, 35, 35);
        }
        public void MarkNodeAsVisited()
        {
            Circle.DrawEllipse(new Pen(Color.MintCream, 3), CoordinateX, CoordinateY, 35, 35);
        }
        public void DrawNameOfNode()
        {
            Circle.DrawString(Name, new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.Blue), CoordinateX + 3, CoordinateY + 5);
        }
    }

    public class Edge : ICloneable
    {

        public string Name { get; private set; }
        public double Weight { get; set; }
        public int Index { get; set; }
        public List<Node> Ends { get; private set; }

        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index <= 1)
                {
                    return Ends[Index];
                }

                return null;
            }
        }
        public Edge()
        {
            Ends = new List<Node>();

            Name = string.Empty;

            Weight = 0.0;

            Index = 0;
        }
        public Edge(double Weight, params Node[] Nodes)
        {
            Ends = new List<Node>();

            for (int Index = 0; Index < Nodes.Length; Index++)
            {
                Ends.Add(Nodes[Index]);
            }

            this.Weight = Weight;

            Ends[0][Nodes[1].Index] = Nodes[1];

            Name = $"{Nodes[0].Name}{Nodes[1].Name}";
        }
        public object Clone()
        {
            List<Node> EndsOfEdge = new List<Node>()
            {
                (Node)this.Ends[0].Clone(),

                (Node)this.Ends[1].Clone()
            };

            Edge Edge = new Edge
            {
                Weight = this.Weight,

                Name = this.Name,

                Index = this.Index,

                Ends = EndsOfEdge
            };
            return Edge;
        }
    }
}
