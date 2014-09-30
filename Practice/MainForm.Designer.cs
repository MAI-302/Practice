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
            this.SimulateTheFilter2 = new System.Windows.Forms.Button();
            this.SimulateTheFilter3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gBParams = new System.Windows.Forms.GroupBox();
            this.gBFactor = new System.Windows.Forms.GroupBox();
            this.mTBFactor3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mTBFactor2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mTBFactor1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.mTBn = new System.Windows.Forms.MaskedTextBox();
            this.ln = new System.Windows.Forms.Label();
            this.mTBm = new System.Windows.Forms.MaskedTextBox();
            this.lm = new System.Windows.Forms.Label();
            this.mTBSv = new System.Windows.Forms.MaskedTextBox();
            this.lSv = new System.Windows.Forms.Label();
            this.mTBBeta = new System.Windows.Forms.MaskedTextBox();
            this.lBeta = new System.Windows.Forms.Label();
            this.mTBAlpha = new System.Windows.Forms.MaskedTextBox();
            this.lAlpha = new System.Windows.Forms.Label();
            this.mTBSmalla = new System.Windows.Forms.MaskedTextBox();
            this.lsmalla = new System.Windows.Forms.Label();
            this.mTBA = new System.Windows.Forms.MaskedTextBox();
            this.lA = new System.Windows.Forms.Label();
            this.mTBTau = new System.Windows.Forms.MaskedTextBox();
            this.lTau = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.gBPlot = new System.Windows.Forms.GroupBox();
            this.gBParams.SuspendLayout();
            this.gBFactor.SuspendLayout();
            this.gBPlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeX_Plot
            // 
            this.DeX_Plot.Location = new System.Drawing.Point(6, 19);
            this.DeX_Plot.Name = "DeX_Plot";
            this.DeX_Plot.Size = new System.Drawing.Size(201, 25);
            this.DeX_Plot.TabIndex = 1;
            this.DeX_Plot.Text = "DeX Plot";
            this.DeX_Plot.UseVisualStyleBackColor = true;
            this.DeX_Plot.Click += new System.EventHandler(this.DeX_Plot_Click);
            // 
            // DeH_Plot
            // 
            this.DeH_Plot.Location = new System.Drawing.Point(6, 50);
            this.DeH_Plot.Name = "DeH_Plot";
            this.DeH_Plot.Size = new System.Drawing.Size(201, 25);
            this.DeH_Plot.TabIndex = 2;
            this.DeH_Plot.Text = "DeH Plot";
            this.DeH_Plot.UseVisualStyleBackColor = true;
            this.DeH_Plot.Click += new System.EventHandler(this.DeH_Plot_Click);
            // 
            // KeXH_Plot
            // 
            this.KeXH_Plot.Location = new System.Drawing.Point(6, 143);
            this.KeXH_Plot.Name = "KeXH_Plot";
            this.KeXH_Plot.Size = new System.Drawing.Size(201, 25);
            this.KeXH_Plot.TabIndex = 3;
            this.KeXH_Plot.Text = "KeXH Plot";
            this.KeXH_Plot.UseVisualStyleBackColor = true;
            this.KeXH_Plot.Click += new System.EventHandler(this.KeXH_Plot_Click);
            // 
            // Time1_Plot
            // 
            this.Time1_Plot.Location = new System.Drawing.Point(6, 81);
            this.Time1_Plot.Name = "Time1_Plot";
            this.Time1_Plot.Size = new System.Drawing.Size(201, 25);
            this.Time1_Plot.TabIndex = 4;
            this.Time1_Plot.Text = "a(t,t)[1] Plot";
            this.Time1_Plot.UseVisualStyleBackColor = true;
            this.Time1_Plot.Click += new System.EventHandler(this.Time1_Plot_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.EditModifierKeys = System.Windows.Forms.Keys.None;
            this.zedGraph.Location = new System.Drawing.Point(443, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(662, 396);
            this.zedGraph.TabIndex = 6;
            // 
            // Help_Button
            // 
            this.Help_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Help_Button.Location = new System.Drawing.Point(1111, 12);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(57, 25);
            this.Help_Button.TabIndex = 7;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = false;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Time2_Plot
            // 
            this.Time2_Plot.Location = new System.Drawing.Point(6, 112);
            this.Time2_Plot.Name = "Time2_Plot";
            this.Time2_Plot.Size = new System.Drawing.Size(201, 25);
            this.Time2_Plot.TabIndex = 8;
            this.Time2_Plot.Text = "a(t,t)[2] Plot";
            this.Time2_Plot.UseVisualStyleBackColor = true;
            this.Time2_Plot.Click += new System.EventHandler(this.Time2_Plot_Click);
            // 
            // SimulateTheFilter
            // 
            this.SimulateTheFilter.Location = new System.Drawing.Point(6, 174);
            this.SimulateTheFilter.Name = "SimulateTheFilter";
            this.SimulateTheFilter.Size = new System.Drawing.Size(66, 105);
            this.SimulateTheFilter.TabIndex = 9;
            this.SimulateTheFilter.Text = "Моделировать работу фильтра k=0.2";
            this.SimulateTheFilter.UseVisualStyleBackColor = true;
            this.SimulateTheFilter.Click += new System.EventHandler(this.SimulateTheFilter_Click);
            // 
            // SimulateTheFilter2
            // 
            this.SimulateTheFilter2.Location = new System.Drawing.Point(75, 174);
            this.SimulateTheFilter2.Name = "SimulateTheFilter2";
            this.SimulateTheFilter2.Size = new System.Drawing.Size(66, 105);
            this.SimulateTheFilter2.TabIndex = 11;
            this.SimulateTheFilter2.Text = "Моделировать работу фильтра k=0.5";
            this.SimulateTheFilter2.UseVisualStyleBackColor = true;
            this.SimulateTheFilter2.Click += new System.EventHandler(this.SimulateTheFilter2_Click);
            // 
            // SimulateTheFilter3
            // 
            this.SimulateTheFilter3.Location = new System.Drawing.Point(144, 174);
            this.SimulateTheFilter3.Name = "SimulateTheFilter3";
            this.SimulateTheFilter3.Size = new System.Drawing.Size(66, 105);
            this.SimulateTheFilter3.TabIndex = 12;
            this.SimulateTheFilter3.Text = "Моделировать работу фильтра k=0.8";
            this.SimulateTheFilter3.UseVisualStyleBackColor = true;
            this.SimulateTheFilter3.Click += new System.EventHandler(this.SimulateTheFilter3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Оценки статистических характеристик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "XML-документ|*.xml";
            this.openFileDialog.Title = "Открытие файла с параметрами";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML-документ|*.xml";
            this.saveFileDialog.Title = "Сохранение файла с параметрами";
            // 
            // gBParams
            // 
            this.gBParams.Controls.Add(this.gBFactor);
            this.gBParams.Controls.Add(this.bApply);
            this.gBParams.Controls.Add(this.mTBn);
            this.gBParams.Controls.Add(this.ln);
            this.gBParams.Controls.Add(this.mTBm);
            this.gBParams.Controls.Add(this.lm);
            this.gBParams.Controls.Add(this.mTBSv);
            this.gBParams.Controls.Add(this.lSv);
            this.gBParams.Controls.Add(this.mTBBeta);
            this.gBParams.Controls.Add(this.lBeta);
            this.gBParams.Controls.Add(this.mTBAlpha);
            this.gBParams.Controls.Add(this.lAlpha);
            this.gBParams.Controls.Add(this.mTBSmalla);
            this.gBParams.Controls.Add(this.lsmalla);
            this.gBParams.Controls.Add(this.mTBA);
            this.gBParams.Controls.Add(this.lA);
            this.gBParams.Controls.Add(this.mTBTau);
            this.gBParams.Controls.Add(this.lTau);
            this.gBParams.Controls.Add(this.bSave);
            this.gBParams.Controls.Add(this.bLoad);
            this.gBParams.Location = new System.Drawing.Point(12, 12);
            this.gBParams.Name = "gBParams";
            this.gBParams.Size = new System.Drawing.Size(204, 396);
            this.gBParams.TabIndex = 21;
            this.gBParams.TabStop = false;
            this.gBParams.Text = "Параметры";
            // 
            // gBFactor
            // 
            this.gBFactor.Controls.Add(this.mTBFactor3);
            this.gBFactor.Controls.Add(this.label6);
            this.gBFactor.Controls.Add(this.mTBFactor2);
            this.gBFactor.Controls.Add(this.label7);
            this.gBFactor.Controls.Add(this.mTBFactor1);
            this.gBFactor.Controls.Add(this.label8);
            this.gBFactor.Location = new System.Drawing.Point(9, 227);
            this.gBFactor.Name = "gBFactor";
            this.gBFactor.Size = new System.Drawing.Size(189, 97);
            this.gBFactor.TabIndex = 39;
            this.gBFactor.TabStop = false;
            this.gBFactor.Text = "Factor";
            // 
            // mTBFactor3
            // 
            this.mTBFactor3.Location = new System.Drawing.Point(44, 71);
            this.mTBFactor3.Mask = "0.0000";
            this.mTBFactor3.Name = "mTBFactor3";
            this.mTBFactor3.Size = new System.Drawing.Size(139, 20);
            this.mTBFactor3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "3";
            // 
            // mTBFactor2
            // 
            this.mTBFactor2.Location = new System.Drawing.Point(44, 45);
            this.mTBFactor2.Mask = "0.0000";
            this.mTBFactor2.Name = "mTBFactor2";
            this.mTBFactor2.Size = new System.Drawing.Size(139, 20);
            this.mTBFactor2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "2";
            // 
            // mTBFactor1
            // 
            this.mTBFactor1.Location = new System.Drawing.Point(44, 19);
            this.mTBFactor1.Mask = "0.0000";
            this.mTBFactor1.Name = "mTBFactor1";
            this.mTBFactor1.Size = new System.Drawing.Size(139, 20);
            this.mTBFactor1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "1";
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(9, 330);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(189, 23);
            this.bApply.TabIndex = 38;
            this.bApply.Text = "Применить";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // mTBn
            // 
            this.mTBn.Location = new System.Drawing.Point(47, 201);
            this.mTBn.Mask = "00000";
            this.mTBn.Name = "mTBn";
            this.mTBn.Size = new System.Drawing.Size(151, 20);
            this.mTBn.TabIndex = 36;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(7, 208);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(13, 13);
            this.ln.TabIndex = 37;
            this.ln.Text = "n";
            // 
            // mTBm
            // 
            this.mTBm.Location = new System.Drawing.Point(47, 175);
            this.mTBm.Mask = "00000";
            this.mTBm.Name = "mTBm";
            this.mTBm.Size = new System.Drawing.Size(151, 20);
            this.mTBm.TabIndex = 34;
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(7, 178);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(15, 13);
            this.lm.TabIndex = 35;
            this.lm.Text = "m";
            // 
            // mTBSv
            // 
            this.mTBSv.Location = new System.Drawing.Point(47, 149);
            this.mTBSv.Mask = "0.0000";
            this.mTBSv.Name = "mTBSv";
            this.mTBSv.Size = new System.Drawing.Size(151, 20);
            this.mTBSv.TabIndex = 32;
            // 
            // lSv
            // 
            this.lSv.AutoSize = true;
            this.lSv.Location = new System.Drawing.Point(6, 152);
            this.lSv.Name = "lSv";
            this.lSv.Size = new System.Drawing.Size(20, 13);
            this.lSv.TabIndex = 33;
            this.lSv.Text = "Sv";
            // 
            // mTBBeta
            // 
            this.mTBBeta.Location = new System.Drawing.Point(47, 123);
            this.mTBBeta.Mask = "0.0000";
            this.mTBBeta.Name = "mTBBeta";
            this.mTBBeta.Size = new System.Drawing.Size(151, 20);
            this.mTBBeta.TabIndex = 30;
            // 
            // lBeta
            // 
            this.lBeta.AutoSize = true;
            this.lBeta.Location = new System.Drawing.Point(7, 126);
            this.lBeta.Name = "lBeta";
            this.lBeta.Size = new System.Drawing.Size(29, 13);
            this.lBeta.TabIndex = 31;
            this.lBeta.Text = "Beta";
            // 
            // mTBAlpha
            // 
            this.mTBAlpha.Location = new System.Drawing.Point(47, 97);
            this.mTBAlpha.Mask = "0.0000";
            this.mTBAlpha.Name = "mTBAlpha";
            this.mTBAlpha.Size = new System.Drawing.Size(151, 20);
            this.mTBAlpha.TabIndex = 28;
            // 
            // lAlpha
            // 
            this.lAlpha.AutoSize = true;
            this.lAlpha.Location = new System.Drawing.Point(7, 100);
            this.lAlpha.Name = "lAlpha";
            this.lAlpha.Size = new System.Drawing.Size(34, 13);
            this.lAlpha.TabIndex = 29;
            this.lAlpha.Text = "Alpha";
            // 
            // mTBSmalla
            // 
            this.mTBSmalla.Location = new System.Drawing.Point(47, 71);
            this.mTBSmalla.Mask = "0.0000";
            this.mTBSmalla.Name = "mTBSmalla";
            this.mTBSmalla.Size = new System.Drawing.Size(151, 20);
            this.mTBSmalla.TabIndex = 26;
            // 
            // lsmalla
            // 
            this.lsmalla.AutoSize = true;
            this.lsmalla.Location = new System.Drawing.Point(7, 74);
            this.lsmalla.Name = "lsmalla";
            this.lsmalla.Size = new System.Drawing.Size(13, 13);
            this.lsmalla.TabIndex = 27;
            this.lsmalla.Text = "a";
            // 
            // mTBA
            // 
            this.mTBA.Location = new System.Drawing.Point(47, 45);
            this.mTBA.Mask = "0.0000";
            this.mTBA.Name = "mTBA";
            this.mTBA.Size = new System.Drawing.Size(151, 20);
            this.mTBA.TabIndex = 24;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(7, 48);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(14, 13);
            this.lA.TabIndex = 25;
            this.lA.Text = "A";
            // 
            // mTBTau
            // 
            this.mTBTau.Location = new System.Drawing.Point(47, 19);
            this.mTBTau.Mask = "0.0000";
            this.mTBTau.Name = "mTBTau";
            this.mTBTau.Size = new System.Drawing.Size(151, 20);
            this.mTBTau.TabIndex = 22;
            // 
            // lTau
            // 
            this.lTau.AutoSize = true;
            this.lTau.Location = new System.Drawing.Point(7, 22);
            this.lTau.Name = "lTau";
            this.lTau.Size = new System.Drawing.Size(26, 13);
            this.lTau.TabIndex = 23;
            this.lTau.Text = "Tau";
            // 
            // bSave
            // 
            this.bSave.AutoSize = true;
            this.bSave.Location = new System.Drawing.Point(113, 359);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(85, 25);
            this.bSave.TabIndex = 22;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.AutoSize = true;
            this.bLoad.Location = new System.Drawing.Point(9, 359);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(86, 25);
            this.bLoad.TabIndex = 21;
            this.bLoad.Text = "Загрузить";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // gBPlot
            // 
            this.gBPlot.Controls.Add(this.DeX_Plot);
            this.gBPlot.Controls.Add(this.DeH_Plot);
            this.gBPlot.Controls.Add(this.KeXH_Plot);
            this.gBPlot.Controls.Add(this.Time1_Plot);
            this.gBPlot.Controls.Add(this.Time2_Plot);
            this.gBPlot.Controls.Add(this.SimulateTheFilter);
            this.gBPlot.Controls.Add(this.SimulateTheFilter2);
            this.gBPlot.Controls.Add(this.SimulateTheFilter3);
            this.gBPlot.Location = new System.Drawing.Point(222, 12);
            this.gBPlot.Name = "gBPlot";
            this.gBPlot.Size = new System.Drawing.Size(215, 285);
            this.gBPlot.TabIndex = 22;
            this.gBPlot.TabStop = false;
            this.gBPlot.Text = "Построение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 416);
            this.Controls.Add(this.gBPlot);
            this.Controls.Add(this.gBParams);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.zedGraph);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Фильтр Калмана - Файл с параметрами не загружен";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gBParams.ResumeLayout(false);
            this.gBParams.PerformLayout();
            this.gBFactor.ResumeLayout(false);
            this.gBFactor.PerformLayout();
            this.gBPlot.ResumeLayout(false);
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
        private System.Windows.Forms.Button SimulateTheFilter2;
        private System.Windows.Forms.Button SimulateTheFilter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox gBParams;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label lTau;
        private System.Windows.Forms.MaskedTextBox mTBTau;
        private System.Windows.Forms.MaskedTextBox mTBn;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.MaskedTextBox mTBm;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.MaskedTextBox mTBSv;
        private System.Windows.Forms.Label lSv;
        private System.Windows.Forms.MaskedTextBox mTBBeta;
        private System.Windows.Forms.Label lBeta;
        private System.Windows.Forms.MaskedTextBox mTBAlpha;
        private System.Windows.Forms.Label lAlpha;
        private System.Windows.Forms.MaskedTextBox mTBSmalla;
        private System.Windows.Forms.Label lsmalla;
        private System.Windows.Forms.MaskedTextBox mTBA;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.GroupBox gBPlot;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.GroupBox gBFactor;
        private System.Windows.Forms.MaskedTextBox mTBFactor3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mTBFactor2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mTBFactor1;
        private System.Windows.Forms.Label label8;
    }
}

