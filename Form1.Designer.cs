namespace WinForms___Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblDashborad = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            lblOrders = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblDashborad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 42);
            panel1.TabIndex = 0;
            // 
            // lblDashborad
            // 
            lblDashborad.Anchor = AnchorStyles.None;
            lblDashborad.AutoSize = true;
            lblDashborad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashborad.Location = new Point(395, 9);
            lblDashborad.Name = "lblDashborad";
            lblDashborad.Size = new Size(105, 25);
            lblDashborad.TabIndex = 0;
            lblDashborad.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(907, 551);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 264F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(chart3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(10, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(887, 180);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(887, 87);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 192);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(442, 0);
            panel6.Margin = new Padding(0, 0, 5, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(216, 82);
            panel6.TabIndex = 3;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(4, 58);
            label12.Name = "label12";
            label12.Size = new Size(51, 18);
            label12.TabIndex = 0;
            label12.Text = "Completed";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(111, 60);
            label13.Name = "label13";
            label13.Size = new Size(102, 16);
            label13.TabIndex = 0;
            label13.Text = "789";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.ImageAlign = ContentAlignment.MiddleRight;
            label14.Location = new Point(39, 29);
            label14.Name = "label14";
            label14.Size = new Size(146, 18);
            label14.TabIndex = 0;
            label14.Text = "123456";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(4, 3);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 0;
            label15.Text = "Orders";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(663, 0);
            panel5.Margin = new Padding(0, 0, 0, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 82);
            panel5.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 58);
            label8.Name = "label8";
            label8.Size = new Size(51, 18);
            label8.TabIndex = 0;
            label8.Text = "Completed";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(110, 58);
            label9.Name = "label9";
            label9.Size = new Size(102, 16);
            label9.TabIndex = 0;
            label9.Text = "789";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(36, 29);
            label10.Name = "label10";
            label10.Size = new Size(146, 18);
            label10.TabIndex = 0;
            label10.Text = "123456";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(4, 3);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 0;
            label11.Text = "Orders";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0, 0, 5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 82);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(4, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 0;
            label3.Text = "Completed";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(111, 60);
            label5.Name = "label5";
            label5.Size = new Size(102, 16);
            label5.TabIndex = 0;
            label5.Text = "789";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(39, 29);
            label6.Name = "label6";
            label6.Size = new Size(146, 18);
            label6.TabIndex = 0;
            label6.Text = "123456";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(4, 3);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 0;
            label7.Text = "Orders";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblOrders);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(221, 0);
            panel3.Margin = new Padding(0, 0, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 82);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(4, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 0;
            label2.Text = "Completed";
            label2.TextAlign = ContentAlignment.BottomLeft;
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(111, 60);
            label4.Name = "label4";
            label4.Size = new Size(102, 16);
            label4.TabIndex = 0;
            label4.Text = "789";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(146, 18);
            label1.TabIndex = 0;
            label1.Text = "123456";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.ForeColor = SystemColors.ButtonHighlight;
            lblOrders.Location = new Point(4, 3);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(42, 15);
            lblOrders.TabIndex = 0;
            lblOrders.Text = "Orders";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(chart1);
            flowLayoutPanel1.Controls.Add(chart2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(623, 180);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Margin = new Padding(0, 0, 10, 10);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 170);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(310, 0);
            chart2.Margin = new Padding(0, 0, 10, 10);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(300, 170);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(623, 0);
            chart3.Margin = new Padding(0, 0, 0, 10);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(264, 170);
            chart3.TabIndex = 2;
            chart3.Text = "chart3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDashborad;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label lblOrders;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel6;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}
