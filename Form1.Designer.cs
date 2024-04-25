namespace lab_prog_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDownVertices = new System.Windows.Forms.NumericUpDown();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewAdjacencyTable = new System.Windows.Forms.DataGridView();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.buttonAnimation = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertices)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelParameters, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelGraph, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelParameters
            // 
            this.panelParameters.Controls.Add(this.buttonPopulate);
            this.panelParameters.Controls.Add(this.buttonClear);
            this.panelParameters.Controls.Add(this.numericUpDownVertices);
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParameters.Location = new System.Drawing.Point(3, 3);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(380, 26);
            this.panelParameters.TabIndex = 0;
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPopulate.Location = new System.Drawing.Point(257, 3);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(120, 20);
            this.buttonPopulate.TabIndex = 0;
            this.buttonPopulate.Text = "Заполнить";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            this.buttonPopulate.Click += new System.EventHandler(this.ButtonPopulate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(131, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 20);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // numericUpDownVertices
            // 
            this.numericUpDownVertices.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownVertices.Name = "numericUpDownVertices";
            this.numericUpDownVertices.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVertices.TabIndex = 0;
            this.numericUpDownVertices.ValueChanged += new System.EventHandler(this.NumericUpDownVertices_ValueChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonAnimation);
            this.panelInfo.Controls.Add(this.numericUpDownAngle);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(389, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(380, 26);
            this.panelInfo.TabIndex = 1;
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAngle.TabIndex = 1;
            this.numericUpDownAngle.ValueChanged += new System.EventHandler(this.NumericUpDownAngle_ValueChanged);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewAdjacencyTable);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(3, 35);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(380, 476);
            this.panelDataGridView.TabIndex = 2;
            // 
            // dataGridViewAdjacencyTable
            // 
            this.dataGridViewAdjacencyTable.AllowUserToAddRows = false;
            this.dataGridViewAdjacencyTable.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacencyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAdjacencyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAdjacencyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacencyTable.ColumnHeadersVisible = false;
            this.dataGridViewAdjacencyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdjacencyTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdjacencyTable.Name = "dataGridViewAdjacencyTable";
            this.dataGridViewAdjacencyTable.ReadOnly = true;
            this.dataGridViewAdjacencyTable.RowHeadersVisible = false;
            this.dataGridViewAdjacencyTable.Size = new System.Drawing.Size(380, 476);
            this.dataGridViewAdjacencyTable.TabIndex = 0;
            this.dataGridViewAdjacencyTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAdjacencyTable_CellClick);
            // 
            // panelGraph
            // 
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(389, 35);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(380, 476);
            this.panelGraph.TabIndex = 3;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraph_Paint);
            // 
            // buttonAnimation
            // 
            this.buttonAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnimation.Location = new System.Drawing.Point(257, 3);
            this.buttonAnimation.Name = "buttonAnimation";
            this.buttonAnimation.Size = new System.Drawing.Size(120, 20);
            this.buttonAnimation.TabIndex = 2;
            this.buttonAnimation.Text = "Анимация";
            this.buttonAnimation.UseVisualStyleBackColor = true;
            this.buttonAnimation.Click += new System.EventHandler(this.ButtonAnimation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertices)).EndInit();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.DataGridView dataGridViewAdjacencyTable;
        private System.Windows.Forms.NumericUpDown numericUpDownVertices;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button buttonAnimation;
    }
}

