using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_prog_3
{
    public partial class Form1 : Form
    {
        int oldNodeCount = 4;
        int nodeCount = 5;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = nodeCount;
            dataGridView1.RowCount = nodeCount;
            dataGridView1.ColumnCount = nodeCount;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            button3.Text = string.Format("Заполнить ({0})", dataGridView1.Rows.Count * dataGridView1.Columns.Count);
            button4.Text = string.Format("Удалить ({0})", dataGridView1.Rows.Count * dataGridView1.Columns.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.RowIndex == cell.ColumnIndex)
                        cell.Value = 0;

                    if (cell.RowIndex < cell.ColumnIndex)
                        cell.Value = rand.Next(2);

                    if (cell.RowIndex > cell.ColumnIndex)
                        cell.Value = dataGridView1[cell.RowIndex, cell.ColumnIndex].Value;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            oldNodeCount = nodeCount;
            nodeCount = (int)numericUpDown1.Value;
            
            if (nodeCount > oldNodeCount)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.CellTemplate = new DataGridViewTextBoxCell();
                dataGridView1.Columns.Add(column);
                dataGridView1.Rows.Add(new DataGridViewRow());
            }
            else if (nodeCount < oldNodeCount)
            {
                dataGridView1.Columns.Remove(new DataGridViewColumn());
                dataGridView1.Rows.Remove(new DataGridViewRow());
            }

            pictureBox1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = e.RowIndex;
            int i = e.ColumnIndex;
            if (i == j)
                return;
            int value = (int)(dataGridView1[i, j].Value);
            value = (value + 1) % 2;
            dataGridView1[i, j].Value = value;
            dataGridView1[j, i].Value = value;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            Pen circle = new Pen(Color.Black);
            Pen edge = new Pen(Color.Blue)
            {
                Width = 4
            };
            int nodeRadius = 16;
            double nodeStep = 2 * Math.PI / nodeCount;
            Font nodeFont = new Font(FontFamily.GenericSansSerif, 10);

            int circleRadius = 200;

            Point pictureBoxCenter = new Point()
            {
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2
            };

            for (int i = 0; i < nodeCount; i++)
            {
                Size nodeSize = new Size()
                {
                    Width = nodeRadius,
                    Height = nodeRadius
                };
                Point nodePosition = new Point()
                {
                    X = (int)(circleRadius / 2 * Math.Cos(i * nodeStep) + pictureBoxCenter.X - nodeSize.Width / 2),
                    Y = (int)(circleRadius / 2 * Math.Sin(i * nodeStep) + pictureBoxCenter.Y - nodeSize.Height / 2)
                };
                Rectangle nodeFrame = new Rectangle(nodePosition, nodeSize);
                gr.FillEllipse(Brushes.Red, nodeFrame);
                gr.DrawString((i + 1).ToString(), nodeFont, Brushes.Black, nodePosition);
            }
        }
    }
}