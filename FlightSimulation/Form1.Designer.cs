
namespace FlightSimulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_launch = new System.Windows.Forms.Button();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_angle = new System.Windows.Forms.NumericUpDown();
            this.numeric_speed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_minutes = new System.Windows.Forms.Label();
            this.label_seconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 174);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 357);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(489, 71);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(96, 31);
            this.button_launch.TabIndex = 1;
            this.button_launch.Text = "Launch!";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(118, 28);
            this.numeric_height.Name = "numeric_height";
            this.numeric_height.Size = new System.Drawing.Size(120, 22);
            this.numeric_height.TabIndex = 2;
            // 
            // numeric_angle
            // 
            this.numeric_angle.Location = new System.Drawing.Point(118, 76);
            this.numeric_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numeric_angle.Name = "numeric_angle";
            this.numeric_angle.Size = new System.Drawing.Size(120, 22);
            this.numeric_angle.TabIndex = 3;
            this.numeric_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numeric_speed
            // 
            this.numeric_speed.Location = new System.Drawing.Point(118, 128);
            this.numeric_speed.Name = "numeric_speed";
            this.numeric_speed.Size = new System.Drawing.Size(120, 22);
            this.numeric_speed.TabIndex = 4;
            this.numeric_speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed:";
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(613, 71);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(96, 31);
            this.button_pause.TabIndex = 8;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minutes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seconds:";
            // 
            // label_minutes
            // 
            this.label_minutes.AutoSize = true;
            this.label_minutes.Location = new System.Drawing.Point(574, 133);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(16, 17);
            this.label_minutes.TabIndex = 11;
            this.label_minutes.Text = "0";
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Location = new System.Drawing.Point(687, 133);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(16, 17);
            this.label_seconds.TabIndex = 12;
            this.label_seconds.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label_seconds);
            this.Controls.Add(this.label_minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_speed);
            this.Controls.Add(this.numeric_angle);
            this.Controls.Add(this.numeric_height);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.NumericUpDown numeric_height;
        private System.Windows.Forms.NumericUpDown numeric_angle;
        private System.Windows.Forms.NumericUpDown numeric_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_minutes;
        private System.Windows.Forms.Label label_seconds;
    }
}

