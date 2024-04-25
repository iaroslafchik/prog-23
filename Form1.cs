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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace lab_prog_3 {


    public partial class Form1 : Form {
        int verticesCount;
        double graphAngle;

        public Form1() {
            InitializeComponent();

            numericUpDownVertices.Value = 5;
            graphAngle = (60 / 360) * (Math.PI * 2);

            NumericUpDownVertices_ValueChanged(this, EventArgs.Empty);
            ButtonPopulate_Click(this, EventArgs.Empty);
        }

        //private void Form1_Paint(object sender, PaintEventArgs e) {
        //    buttonPopulate.Text = string.Format("Заполнить {0}", dataGridViewAdjacencyTable.Rows.Count * dataGridViewAdjacencyTable.Columns.Count);
        //    buttonClear.Text = string.Format("Удалить {0}", dataGridViewAdjacencyTable.Rows.Count * dataGridViewAdjacencyTable.Columns.Count);
        //}

        private void ButtonPopulate_Click(object sender, EventArgs e) {
            var rand = new Random();

            foreach (DataGridViewRow row in dataGridViewAdjacencyTable.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {
                    if (cell.Value != null)
                        continue;
                    if (cell.RowIndex == cell.ColumnIndex)
                        cell.Value = 0;

                    if (cell.RowIndex < cell.ColumnIndex)
                        cell.Value = rand.Next(2);

                    if (cell.RowIndex > cell.ColumnIndex)
                        cell.Value = dataGridViewAdjacencyTable[cell.RowIndex, cell.ColumnIndex].Value;
                }
            }
            panelGraph.Invalidate();
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridViewAdjacencyTable.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {
                    cell.Value = null;
                }
            }
            panelGraph.Invalidate();
        }

        private void NumericUpDownVertices_ValueChanged(object sender, EventArgs e) {
            verticesCount = (int)numericUpDownVertices.Value;
            dataGridViewAdjacencyTable.RowCount = dataGridViewAdjacencyTable.ColumnCount = verticesCount;
            panelGraph.Invalidate();
        }

        private void DataGridViewAdjacencyTable_CellClick(object sender, DataGridViewCellEventArgs e) {
            int j = e.RowIndex;
            int i = e.ColumnIndex;
            if (i == j || dataGridViewAdjacencyTable[i,j].Value == null)
                return;
            int value = (int)dataGridViewAdjacencyTable[i, j].Value;
            value = value == 0 ? 1 : 0;
            dataGridViewAdjacencyTable[i, j].Value = value;
            dataGridViewAdjacencyTable[j, i].Value = value;
            panelGraph.Invalidate();
        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e) {
            Graphics graph = panelGraph.CreateGraphics();

            double circleRadius = (int)(0.8 * Math.Min(panelGraph.Width, panelGraph.Height));
            int vertexRadius = 16;
            double vertexStep = 2 * Math.PI / verticesCount;

            for (int i = 0; i < verticesCount; i++) {
                for (int j = i; j < verticesCount; j++) {
                    if (i == j || dataGridViewAdjacencyTable[i, j].Value == null || (int)dataGridViewAdjacencyTable[i,j].Value != 1)
                        continue;
                    graph.DrawLine(Pens.Black,
                        (int)(circleRadius / 2 * Math.Cos(i * vertexStep + graphAngle) + panelGraph.Width / 2),
                        (int)(circleRadius / 2 * Math.Sin(i * vertexStep + graphAngle) + panelGraph.Height / 2),
                        (int)(circleRadius / 2 * Math.Cos(j * vertexStep + graphAngle) + panelGraph.Width / 2),
                        (int)(circleRadius / 2 * Math.Sin(j * vertexStep + graphAngle) + panelGraph.Height / 2)
                        );
                }
                graph.FillEllipse(Brushes.OrangeRed,
                    (int)(circleRadius / 2 * Math.Cos(i * vertexStep + graphAngle) + panelGraph.Width / 2 - vertexRadius / 2),
                    (int)(circleRadius / 2 * Math.Sin(i * vertexStep + graphAngle) + panelGraph.Height / 2 - vertexRadius / 2),
                    vertexRadius,
                    vertexRadius
                    );
                graph.DrawString((i + 1).ToString(), SystemFonts.DefaultFont, Brushes.Black,
                    (int)((circleRadius + 50) / 2 * Math.Cos(i * vertexStep + graphAngle) + panelGraph.Width / 2 - vertexRadius / 2),
                    (int)((circleRadius + 50) / 2 * Math.Sin(i * vertexStep + graphAngle) + panelGraph.Height / 2 - vertexRadius / 2)
                    );
            }
        }

        private void NumericUpDownAngle_ValueChanged(object sender, EventArgs e) {
            numericUpDownAngle.Value %= 360;
            graphAngle = ((int)numericUpDownAngle.Value / 360.0) * (Math.PI * 2);
            panelGraph.Invalidate();
        }

        private void ButtonAnimation_Click(object sender, EventArgs e) {
            Thread animation = new Thread(Animation);
            animation.Start();
        }

        void Animation() {
            while (true) {
                graphAngle++;
                panelGraph.Invalidate();
                Thread.Sleep(1);
            } 
        }
    }
}