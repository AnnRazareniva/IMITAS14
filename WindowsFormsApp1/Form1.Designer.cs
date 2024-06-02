namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.peopleCount = new System.Windows.Forms.Label();
            this.queueCount = new System.Windows.Forms.Label();
            this.operatrr = new System.Windows.Forms.NumericUpDown();
            this.stop = new System.Windows.Forms.Button();
            this.cl2 = new System.Windows.Forms.Label();
            this.cl3 = new System.Windows.Forms.Label();
            this.cl1 = new System.Windows.Forms.Label();
            this.RUN = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.operatrr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleCount
            // 
            this.peopleCount.AutoSize = true;
            this.peopleCount.Location = new System.Drawing.Point(781, 96);
            this.peopleCount.Name = "peopleCount";
            this.peopleCount.Size = new System.Drawing.Size(13, 13);
            this.peopleCount.TabIndex = 20;
            this.peopleCount.Text = "0";
            // 
            // queueCount
            // 
            this.queueCount.AutoSize = true;
            this.queueCount.Location = new System.Drawing.Point(781, 43);
            this.queueCount.Name = "queueCount";
            this.queueCount.Size = new System.Drawing.Size(13, 13);
            this.queueCount.TabIndex = 19;
            this.queueCount.Text = "0";
            // 
            // operatrr
            // 
            this.operatrr.Location = new System.Drawing.Point(417, 49);
            this.operatrr.Name = "operatrr";
            this.operatrr.Size = new System.Drawing.Size(120, 20);
            this.operatrr.TabIndex = 18;
            this.operatrr.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(96, 114);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(74, 35);
            this.stop.TabIndex = 17;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // cl2
            // 
            this.cl2.AutoSize = true;
            this.cl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl2.Location = new System.Drawing.Point(614, 39);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(157, 17);
            this.cl2.TabIndex = 16;
            this.cl2.Text = "Количество в очереди";
            // 
            // cl3
            // 
            this.cl3.AutoSize = true;
            this.cl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl3.Location = new System.Drawing.Point(614, 92);
            this.cl3.Name = "cl3";
            this.cl3.Size = new System.Drawing.Size(91, 17);
            this.cl3.TabIndex = 15;
            this.cl3.Text = "Всего людей";
            // 
            // cl1
            // 
            this.cl1.AutoSize = true;
            this.cl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl1.Location = new System.Drawing.Point(243, 52);
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(168, 17);
            this.cl1.TabIndex = 14;
            this.cl1.Text = "Количество операторов";
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(55, 29);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(155, 64);
            this.RUN.TabIndex = 13;
            this.RUN.Text = "RUN!!!!";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 155);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Количество занятых операторов";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1402, 605);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 830);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.peopleCount);
            this.Controls.Add(this.queueCount);
            this.Controls.Add(this.operatrr);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.cl2);
            this.Controls.Add(this.cl3);
            this.Controls.Add(this.cl1);
            this.Controls.Add(this.RUN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.operatrr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleCount;
        private System.Windows.Forms.Label queueCount;
        private System.Windows.Forms.NumericUpDown operatrr;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label cl2;
        private System.Windows.Forms.Label cl3;
        private System.Windows.Forms.Label cl1;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

