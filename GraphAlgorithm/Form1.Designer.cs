namespace GraphAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BFS = new System.Windows.Forms.Button();
            this.DFS = new System.Windows.Forms.Button();
            this.Kruskal = new System.Windows.Forms.Button();
            this.Prima = new System.Windows.Forms.Button();
            this.BellmanFord = new System.Windows.Forms.Button();
            this.Dijkstra = new System.Windows.Forms.Button();
            this.FloydWarshall = new System.Windows.Forms.Button();
            this.Johnson = new System.Windows.Forms.Button();
            this.FordFulkerson = new System.Windows.Forms.Button();
            this.A_Star = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(13, 59);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(87, 23);
            this.BFS.TabIndex = 0;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(13, 88);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(87, 23);
            this.DFS.TabIndex = 1;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // Kruskal
            // 
            this.Kruskal.Location = new System.Drawing.Point(13, 118);
            this.Kruskal.Name = "Kruskal";
            this.Kruskal.Size = new System.Drawing.Size(87, 23);
            this.Kruskal.TabIndex = 2;
            this.Kruskal.Text = "Kruskal";
            this.Kruskal.UseVisualStyleBackColor = true;
            // 
            // Prima
            // 
            this.Prima.Location = new System.Drawing.Point(13, 147);
            this.Prima.Name = "Prima";
            this.Prima.Size = new System.Drawing.Size(87, 23);
            this.Prima.TabIndex = 3;
            this.Prima.Text = "Prima";
            this.Prima.UseVisualStyleBackColor = true;
            // 
            // BellmanFord
            // 
            this.BellmanFord.Location = new System.Drawing.Point(13, 177);
            this.BellmanFord.Name = "BellmanFord";
            this.BellmanFord.Size = new System.Drawing.Size(87, 23);
            this.BellmanFord.TabIndex = 4;
            this.BellmanFord.Text = "BellmanFord";
            this.BellmanFord.UseVisualStyleBackColor = true;
            // 
            // Dijkstra
            // 
            this.Dijkstra.Location = new System.Drawing.Point(13, 207);
            this.Dijkstra.Name = "Dijkstra";
            this.Dijkstra.Size = new System.Drawing.Size(87, 23);
            this.Dijkstra.TabIndex = 5;
            this.Dijkstra.Text = "Dijkstra";
            this.Dijkstra.UseVisualStyleBackColor = true;
            // 
            // FloydWarshall
            // 
            this.FloydWarshall.Location = new System.Drawing.Point(13, 236);
            this.FloydWarshall.Name = "FloydWarshall";
            this.FloydWarshall.Size = new System.Drawing.Size(87, 23);
            this.FloydWarshall.TabIndex = 6;
            this.FloydWarshall.Text = "FloydWarshall";
            this.FloydWarshall.UseVisualStyleBackColor = true;
            // 
            // Johnson
            // 
            this.Johnson.Location = new System.Drawing.Point(13, 266);
            this.Johnson.Name = "Johnson";
            this.Johnson.Size = new System.Drawing.Size(87, 23);
            this.Johnson.TabIndex = 7;
            this.Johnson.Text = "Johnson";
            this.Johnson.UseVisualStyleBackColor = true;
            // 
            // FordFulkerson
            // 
            this.FordFulkerson.Location = new System.Drawing.Point(12, 295);
            this.FordFulkerson.Name = "FordFulkerson";
            this.FordFulkerson.Size = new System.Drawing.Size(88, 23);
            this.FordFulkerson.TabIndex = 8;
            this.FordFulkerson.Text = "FordFulkerson";
            this.FordFulkerson.UseVisualStyleBackColor = true;
            // 
            // A_Star
            // 
            this.A_Star.Location = new System.Drawing.Point(13, 324);
            this.A_Star.Name = "A_Star";
            this.A_Star.Size = new System.Drawing.Size(87, 23);
            this.A_Star.TabIndex = 9;
            this.A_Star.Text = "A_Star";
            this.A_Star.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A_Star);
            this.Controls.Add(this.FordFulkerson);
            this.Controls.Add(this.Johnson);
            this.Controls.Add(this.FloydWarshall);
            this.Controls.Add(this.Dijkstra);
            this.Controls.Add(this.BellmanFord);
            this.Controls.Add(this.Prima);
            this.Controls.Add(this.Kruskal);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Button DFS;
        private System.Windows.Forms.Button Kruskal;
        private System.Windows.Forms.Button Prima;
        private System.Windows.Forms.Button BellmanFord;
        private System.Windows.Forms.Button Dijkstra;
        private System.Windows.Forms.Button FloydWarshall;
        private System.Windows.Forms.Button Johnson;
        private System.Windows.Forms.Button FordFulkerson;
        private System.Windows.Forms.Button A_Star;
    }
}