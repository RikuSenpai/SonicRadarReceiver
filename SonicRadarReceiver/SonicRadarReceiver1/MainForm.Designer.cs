namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DisConnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.RefleshPortsButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // DisConnectButton
            // 
            this.DisConnectButton.Enabled = false;
            this.DisConnectButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisConnectButton.Location = new System.Drawing.Point(393, 13);
            this.DisConnectButton.Name = "DisConnectButton";
            this.DisConnectButton.Size = new System.Drawing.Size(75, 33);
            this.DisConnectButton.TabIndex = 14;
            this.DisConnectButton.Text = "切断";
            this.DisConnectButton.UseVisualStyleBackColor = true;
            this.DisConnectButton.Click += new System.EventHandler(this.DisConnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConnectButton.Location = new System.Drawing.Point(312, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 33);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "接続";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(93, 12);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(202, 32);
            this.PortsComboBox.TabIndex = 12;
            // 
            // RefleshPortsButton
            // 
            this.RefleshPortsButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RefleshPortsButton.Location = new System.Drawing.Point(12, 12);
            this.RefleshPortsButton.Name = "RefleshPortsButton";
            this.RefleshPortsButton.Size = new System.Drawing.Size(75, 33);
            this.RefleshPortsButton.TabIndex = 11;
            this.RefleshPortsButton.Text = "更新";
            this.RefleshPortsButton.UseVisualStyleBackColor = true;
            this.RefleshPortsButton.Click += new System.EventHandler(this.RefleshPortsButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisY.Maximum = 300D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "距離";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 51);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Legend = "Legend1";
            series1.Name = "m";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(500, 500);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 564);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.DisConnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortsComboBox);
            this.Controls.Add(this.RefleshPortsButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisConnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Button RefleshPortsButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

