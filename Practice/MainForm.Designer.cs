namespace Practice
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeX_Plot = new System.Windows.Forms.Button();
            this.DeH_Plot = new System.Windows.Forms.Button();
            this.KeXH_Plot = new System.Windows.Forms.Button();
            this.Time1_Plot = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.Help_Button = new System.Windows.Forms.Button();
            this.Time2_Plot = new System.Windows.Forms.Button();
            this.SimulateTheFilter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SimulateTheFilter2 = new System.Windows.Forms.Button();
            this.SimulateTheFilter3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeX_Plot
            // 
            this.DeX_Plot.Location = new System.Drawing.Point(15, 55);
            this.DeX_Plot.Name = "DeX_Plot";
            this.DeX_Plot.Size = new System.Drawing.Size(140, 25);
            this.DeX_Plot.TabIndex = 1;
            this.DeX_Plot.Text = "DeX Plot";
            this.DeX_Plot.UseVisualStyleBackColor = true;
            this.DeX_Plot.Click += new System.EventHandler(this.DeX_Plot_Click);
            // 
            // DeH_Plot
            // 
            this.DeH_Plot.Location = new System.Drawing.Point(15, 95);
            this.DeH_Plot.Name = "DeH_Plot";
            this.DeH_Plot.Size = new System.Drawing.Size(140, 25);
            this.DeH_Plot.TabIndex = 2;
            this.DeH_Plot.Text = "DeH Plot";
            this.DeH_Plot.UseVisualStyleBackColor = true;
            this.DeH_Plot.Click += new System.EventHandler(this.DeH_Plot_Click);
            // 
            // KeXH_Plot
            // 
            this.KeXH_Plot.Location = new System.Drawing.Point(15, 135);
            this.KeXH_Plot.Name = "KeXH_Plot";
            this.KeXH_Plot.Size = new System.Drawing.Size(140, 25);
            this.KeXH_Plot.TabIndex = 3;
            this.KeXH_Plot.Text = "KeXH Plot";
            this.KeXH_Plot.UseVisualStyleBackColor = true;
            this.KeXH_Plot.Click += new System.EventHandler(this.KeXH_Plot_Click);
            // 
            // Time1_Plot
            // 
            this.Time1_Plot.Location = new System.Drawing.Point(15, 175);
            this.Time1_Plot.Name = "Time1_Plot";
            this.Time1_Plot.Size = new System.Drawing.Size(140, 25);
            this.Time1_Plot.TabIndex = 4;
            this.Time1_Plot.Text = "a(t,t)[1] Plot";
            this.Time1_Plot.UseVisualStyleBackColor = true;
            this.Time1_Plot.Click += new System.EventHandler(this.Time1_Plot_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(250, 20);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(900, 530);
            this.zedGraph.TabIndex = 6;
            // 
            // Help_Button
            // 
            this.Help_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Help_Button.Location = new System.Drawing.Point(15, 20);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(140, 25);
            this.Help_Button.TabIndex = 7;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = false;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Time2_Plot
            // 
            this.Time2_Plot.Location = new System.Drawing.Point(15, 215);
            this.Time2_Plot.Name = "Time2_Plot";
            this.Time2_Plot.Size = new System.Drawing.Size(140, 25);
            this.Time2_Plot.TabIndex = 8;
            this.Time2_Plot.Text = "a(t,t)[2] Plot";
            this.Time2_Plot.UseVisualStyleBackColor = true;
            this.Time2_Plot.Click += new System.EventHandler(this.Time2_Plot_Click);
            // 
            // SimulateTheFilter
            // 
            this.SimulateTheFilter.Location = new System.Drawing.Point(15, 250);
            this.SimulateTheFilter.Name = "SimulateTheFilter";
            this.SimulateTheFilter.Size = new System.Drawing.Size(63, 85);
            this.SimulateTheFilter.TabIndex = 9;
            this.SimulateTheFilter.Text = "Моделировать работу фильтра k=0.2";
            this.SimulateTheFilter.UseVisualStyleBackColor = true;
            this.SimulateTheFilter.Click += new System.EventHandler(this.SimulateTheFilter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "y[2]L[2]";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SimulateTheFilter2
            // 
            this.SimulateTheFilter2.Location = new System.Drawing.Point(84, 250);
            this.SimulateTheFilter2.Name = "SimulateTheFilter2";
            this.SimulateTheFilter2.Size = new System.Drawing.Size(63, 85);
            this.SimulateTheFilter2.TabIndex = 11;
            this.SimulateTheFilter2.Text = "Моделировать работу фильтра k=0.5";
            this.SimulateTheFilter2.UseVisualStyleBackColor = true;
            this.SimulateTheFilter2.Click += new System.EventHandler(this.SimulateTheFilter2_Click);
            // 
            // SimulateTheFilter3
            // 
            this.SimulateTheFilter3.Location = new System.Drawing.Point(153, 250);
            this.SimulateTheFilter3.Name = "SimulateTheFilter3";
            this.SimulateTheFilter3.Size = new System.Drawing.Size(63, 85);
            this.SimulateTheFilter3.TabIndex = 12;
            this.SimulateTheFilter3.Text = "Моделировать работу фильтра k=0.8";
            this.SimulateTheFilter3.UseVisualStyleBackColor = true;
            this.SimulateTheFilter3.Click += new System.EventHandler(this.SimulateTheFilter3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Оценки статистических характеристик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(15, 523);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(140, 23);
            this.Exitbutton.TabIndex = 16;
            this.Exitbutton.Text = "Выход";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "y[2]L[2]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimulateTheFilter3);
            this.Controls.Add(this.SimulateTheFilter2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SimulateTheFilter);
            this.Controls.Add(this.Time2_Plot);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.Time1_Plot);
            this.Controls.Add(this.KeXH_Plot);
            this.Controls.Add(this.DeH_Plot);
            this.Controls.Add(this.DeX_Plot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "Фильтр Калмана";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeX_Plot;
        private System.Windows.Forms.Button DeH_Plot;
        private System.Windows.Forms.Button KeXH_Plot;
        private System.Windows.Forms.Button Time1_Plot;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Button Time2_Plot;
        private System.Windows.Forms.Button SimulateTheFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SimulateTheFilter2;
        private System.Windows.Forms.Button SimulateTheFilter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

