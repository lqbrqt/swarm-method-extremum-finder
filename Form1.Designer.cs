namespace ReviewedJuliaPractice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.GroupBox bestAnsBox;
            this._swarmGraph = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.yAnsBox = new System.Windows.Forms.TextBox();
            this.xAnsBox = new System.Windows.Forms.TextBox();
            this.yAnsLabel = new System.Windows.Forms.Label();
            this.xAnsLabel = new System.Windows.Forms.Label();
            this.AlgoConfigBox = new System.Windows.Forms.GroupBox();
            this.maxValueBox = new System.Windows.Forms.TextBox();
            this.minValueBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.initParticlesButton = new System.Windows.Forms.Button();
            this.particleCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.globalBestAnsRatioBox = new System.Windows.Forms.TextBox();
            this.localBestAnsRatioBox = new System.Windows.Forms.TextBox();
            this.currentVelocityRatioBox = new System.Windows.Forms.TextBox();
            this.particleCountLabel = new System.Windows.Forms.Label();
            this.globalBestAnsLabel = new System.Windows.Forms.Label();
            this.selfBestAnsLabel = new System.Windows.Forms.Label();
            this.velocityCoeffLabel = new System.Windows.Forms.Label();
            this.AlgoDriveBox = new System.Windows.Forms.GroupBox();
            this.iterationCountRatio = new System.Windows.Forms.TextBox();
            this.nIterationButton = new System.Windows.Forms.Button();
            this.hundredIterationButton = new System.Windows.Forms.Button();
            this.tenIterationButton = new System.Windows.Forms.Button();
            this.oneIterationButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            groupBox3 = new System.Windows.Forms.GroupBox();
            bestAnsBox = new System.Windows.Forms.GroupBox();
            groupBox3.SuspendLayout();
            bestAnsBox.SuspendLayout();
            this.AlgoConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particleCountNumeric)).BeginInit();
            this.AlgoDriveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.Controls.Add(this._swarmGraph);
            groupBox3.Location = new System.Drawing.Point(397, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(389, 338);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Область решения";
            // 
            // _swarmGraph
            // 
            this._swarmGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this._swarmGraph.Location = new System.Drawing.Point(3, 16);
            this._swarmGraph.Name = "_swarmGraph";
            this._swarmGraph.ScrollGrace = 0D;
            this._swarmGraph.ScrollMaxX = 0D;
            this._swarmGraph.ScrollMaxY = 0D;
            this._swarmGraph.ScrollMaxY2 = 0D;
            this._swarmGraph.ScrollMinX = 0D;
            this._swarmGraph.ScrollMinY = 0D;
            this._swarmGraph.ScrollMinY2 = 0D;
            this._swarmGraph.Size = new System.Drawing.Size(383, 319);
            this._swarmGraph.TabIndex = 0;
            // 
            // bestAnsBox
            // 
            bestAnsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bestAnsBox.Controls.Add(this.label1);
            bestAnsBox.Controls.Add(this.yAnsBox);
            bestAnsBox.Controls.Add(this.xAnsBox);
            bestAnsBox.Controls.Add(this.yAnsLabel);
            bestAnsBox.Controls.Add(this.xAnsLabel);
            bestAnsBox.Location = new System.Drawing.Point(402, 351);
            bestAnsBox.Name = "bestAnsBox";
            bestAnsBox.Size = new System.Drawing.Size(389, 98);
            bestAnsBox.TabIndex = 5;
            bestAnsBox.TabStop = false;
            bestAnsBox.Text = "Лучшее решение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Исследуемая функция: 0.5*x^2 - 4.8*x + 3.5";
            // 
            // yAnsBox
            // 
            this.yAnsBox.Location = new System.Drawing.Point(162, 40);
            this.yAnsBox.Name = "yAnsBox";
            this.yAnsBox.ReadOnly = true;
            this.yAnsBox.Size = new System.Drawing.Size(219, 20);
            this.yAnsBox.TabIndex = 15;
            this.yAnsBox.Text = "0";
            // 
            // xAnsBox
            // 
            this.xAnsBox.Location = new System.Drawing.Point(162, 14);
            this.xAnsBox.Name = "xAnsBox";
            this.xAnsBox.ReadOnly = true;
            this.xAnsBox.Size = new System.Drawing.Size(219, 20);
            this.xAnsBox.TabIndex = 14;
            this.xAnsBox.Text = "0";
            // 
            // yAnsLabel
            // 
            this.yAnsLabel.AutoSize = true;
            this.yAnsLabel.Location = new System.Drawing.Point(48, 43);
            this.yAnsLabel.Name = "yAnsLabel";
            this.yAnsLabel.Size = new System.Drawing.Size(83, 13);
            this.yAnsLabel.TabIndex = 5;
            this.yAnsLabel.Text = "Значение по Y:";
            // 
            // xAnsLabel
            // 
            this.xAnsLabel.AutoSize = true;
            this.xAnsLabel.Location = new System.Drawing.Point(48, 17);
            this.xAnsLabel.Name = "xAnsLabel";
            this.xAnsLabel.Size = new System.Drawing.Size(83, 13);
            this.xAnsLabel.TabIndex = 4;
            this.xAnsLabel.Text = "Значение по X:";
            // 
            // AlgoConfigBox
            // 
            this.AlgoConfigBox.Controls.Add(this.maxValueBox);
            this.AlgoConfigBox.Controls.Add(this.minValueBox);
            this.AlgoConfigBox.Controls.Add(this.maxLabel);
            this.AlgoConfigBox.Controls.Add(this.minLabel);
            this.AlgoConfigBox.Controls.Add(this.initParticlesButton);
            this.AlgoConfigBox.Controls.Add(this.particleCountNumeric);
            this.AlgoConfigBox.Controls.Add(this.globalBestAnsRatioBox);
            this.AlgoConfigBox.Controls.Add(this.localBestAnsRatioBox);
            this.AlgoConfigBox.Controls.Add(this.currentVelocityRatioBox);
            this.AlgoConfigBox.Controls.Add(this.particleCountLabel);
            this.AlgoConfigBox.Controls.Add(this.globalBestAnsLabel);
            this.AlgoConfigBox.Controls.Add(this.selfBestAnsLabel);
            this.AlgoConfigBox.Controls.Add(this.velocityCoeffLabel);
            this.AlgoConfigBox.Location = new System.Drawing.Point(10, 10);
            this.AlgoConfigBox.Name = "AlgoConfigBox";
            this.AlgoConfigBox.Size = new System.Drawing.Size(381, 232);
            this.AlgoConfigBox.TabIndex = 0;
            this.AlgoConfigBox.TabStop = false;
            this.AlgoConfigBox.Text = "Настройки";
            // 
            // maxValueBox
            // 
            this.maxValueBox.Location = new System.Drawing.Point(292, 168);
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(67, 20);
            this.maxValueBox.TabIndex = 12;
            this.maxValueBox.Text = "50";
            // 
            // minValueBox
            // 
            this.minValueBox.Location = new System.Drawing.Point(292, 141);
            this.minValueBox.Name = "minValueBox";
            this.minValueBox.Size = new System.Drawing.Size(67, 20);
            this.minValueBox.TabIndex = 11;
            this.minValueBox.Text = "-50";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(14, 171);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(191, 13);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Максимальное значение диапазона";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(14, 144);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(185, 13);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "Минимальное значение диапазона";
            // 
            // initParticlesButton
            // 
            this.initParticlesButton.Location = new System.Drawing.Point(78, 203);
            this.initParticlesButton.Name = "initParticlesButton";
            this.initParticlesButton.Size = new System.Drawing.Size(240, 23);
            this.initParticlesButton.TabIndex = 8;
            this.initParticlesButton.Text = "Инициализировать систему";
            this.initParticlesButton.UseVisualStyleBackColor = true;
            this.initParticlesButton.Click += new System.EventHandler(this.initParticlesButton_Click);
            // 
            // particleCountNumeric
            // 
            this.particleCountNumeric.Location = new System.Drawing.Point(292, 113);
            this.particleCountNumeric.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.particleCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.particleCountNumeric.Name = "particleCountNumeric";
            this.particleCountNumeric.Size = new System.Drawing.Size(67, 20);
            this.particleCountNumeric.TabIndex = 7;
            this.particleCountNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // globalBestAnsRatioBox
            // 
            this.globalBestAnsRatioBox.Location = new System.Drawing.Point(292, 81);
            this.globalBestAnsRatioBox.Name = "globalBestAnsRatioBox";
            this.globalBestAnsRatioBox.Size = new System.Drawing.Size(67, 20);
            this.globalBestAnsRatioBox.TabIndex = 5;
            this.globalBestAnsRatioBox.Text = "5";
            // 
            // localBestAnsRatioBox
            // 
            this.localBestAnsRatioBox.Location = new System.Drawing.Point(292, 51);
            this.localBestAnsRatioBox.Name = "localBestAnsRatioBox";
            this.localBestAnsRatioBox.Size = new System.Drawing.Size(67, 20);
            this.localBestAnsRatioBox.TabIndex = 6;
            this.localBestAnsRatioBox.Text = "3";
            // 
            // currentVelocityRatioBox
            // 
            this.currentVelocityRatioBox.Location = new System.Drawing.Point(292, 21);
            this.currentVelocityRatioBox.Name = "currentVelocityRatioBox";
            this.currentVelocityRatioBox.Size = new System.Drawing.Size(67, 20);
            this.currentVelocityRatioBox.TabIndex = 5;
            this.currentVelocityRatioBox.Text = "0,2";
            // 
            // particleCountLabel
            // 
            this.particleCountLabel.AutoSize = true;
            this.particleCountLabel.Location = new System.Drawing.Point(14, 115);
            this.particleCountLabel.Name = "particleCountLabel";
            this.particleCountLabel.Size = new System.Drawing.Size(103, 13);
            this.particleCountLabel.TabIndex = 3;
            this.particleCountLabel.Text = "Количество частиц";
            // 
            // globalBestAnsLabel
            // 
            this.globalBestAnsLabel.AutoSize = true;
            this.globalBestAnsLabel.Location = new System.Drawing.Point(14, 84);
            this.globalBestAnsLabel.Name = "globalBestAnsLabel";
            this.globalBestAnsLabel.Size = new System.Drawing.Size(238, 13);
            this.globalBestAnsLabel.TabIndex = 2;
            this.globalBestAnsLabel.Text = "Коэффициент глобального лучшего значения";
            // 
            // selfBestAnsLabel
            // 
            this.selfBestAnsLabel.AutoSize = true;
            this.selfBestAnsLabel.Location = new System.Drawing.Point(14, 54);
            this.selfBestAnsLabel.Name = "selfBestAnsLabel";
            this.selfBestAnsLabel.Size = new System.Drawing.Size(222, 13);
            this.selfBestAnsLabel.TabIndex = 1;
            this.selfBestAnsLabel.Text = "Коэффициент текущего лучшего значения";
            // 
            // velocityCoeffLabel
            // 
            this.velocityCoeffLabel.AutoSize = true;
            this.velocityCoeffLabel.Location = new System.Drawing.Point(14, 24);
            this.velocityCoeffLabel.Name = "velocityCoeffLabel";
            this.velocityCoeffLabel.Size = new System.Drawing.Size(173, 13);
            this.velocityCoeffLabel.TabIndex = 0;
            this.velocityCoeffLabel.Text = "Коэффициент текущей скорости";
            // 
            // AlgoDriveBox
            // 
            this.AlgoDriveBox.Controls.Add(this.iterationCountRatio);
            this.AlgoDriveBox.Controls.Add(this.nIterationButton);
            this.AlgoDriveBox.Controls.Add(this.hundredIterationButton);
            this.AlgoDriveBox.Controls.Add(this.tenIterationButton);
            this.AlgoDriveBox.Controls.Add(this.oneIterationButton);
            this.AlgoDriveBox.Location = new System.Drawing.Point(12, 248);
            this.AlgoDriveBox.Name = "AlgoDriveBox";
            this.AlgoDriveBox.Size = new System.Drawing.Size(381, 201);
            this.AlgoDriveBox.TabIndex = 1;
            this.AlgoDriveBox.TabStop = false;
            this.AlgoDriveBox.Text = "Управление";
            // 
            // iterationCountRatio
            // 
            this.iterationCountRatio.Location = new System.Drawing.Point(290, 172);
            this.iterationCountRatio.Name = "iterationCountRatio";
            this.iterationCountRatio.Size = new System.Drawing.Size(67, 20);
            this.iterationCountRatio.TabIndex = 13;
            this.iterationCountRatio.Text = "1000";
            // 
            // nIterationButton
            // 
            this.nIterationButton.Location = new System.Drawing.Point(15, 169);
            this.nIterationButton.Name = "nIterationButton";
            this.nIterationButton.Size = new System.Drawing.Size(240, 23);
            this.nIterationButton.TabIndex = 12;
            this.nIterationButton.Text = "Произвести N итераций";
            this.nIterationButton.UseVisualStyleBackColor = true;
            this.nIterationButton.Click += new System.EventHandler(this.nIterationButton_Click);
            // 
            // hundredIterationButton
            // 
            this.hundredIterationButton.Location = new System.Drawing.Point(76, 120);
            this.hundredIterationButton.Name = "hundredIterationButton";
            this.hundredIterationButton.Size = new System.Drawing.Size(240, 23);
            this.hundredIterationButton.TabIndex = 11;
            this.hundredIterationButton.Text = "Произвести 100 итераций";
            this.hundredIterationButton.UseVisualStyleBackColor = true;
            this.hundredIterationButton.Click += new System.EventHandler(this.hundredIterationButton_Click);
            // 
            // tenIterationButton
            // 
            this.tenIterationButton.Location = new System.Drawing.Point(76, 81);
            this.tenIterationButton.Name = "tenIterationButton";
            this.tenIterationButton.Size = new System.Drawing.Size(240, 23);
            this.tenIterationButton.TabIndex = 10;
            this.tenIterationButton.Text = "Произвести 10 итераций";
            this.tenIterationButton.UseVisualStyleBackColor = true;
            this.tenIterationButton.Click += new System.EventHandler(this.tenIterationButton_Click);
            // 
            // oneIterationButton
            // 
            this.oneIterationButton.Location = new System.Drawing.Point(76, 41);
            this.oneIterationButton.Name = "oneIterationButton";
            this.oneIterationButton.Size = new System.Drawing.Size(240, 23);
            this.oneIterationButton.TabIndex = 9;
            this.oneIterationButton.Text = "Произвести одну итерацию";
            this.oneIterationButton.UseVisualStyleBackColor = true;
            this.oneIterationButton.Click += new System.EventHandler(this.oneIterationButton_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(bestAnsBox);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.AlgoDriveBox);
            this.Controls.Add(this.AlgoConfigBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SwampAlgo by Yulia Belousova";
            groupBox3.ResumeLayout(false);
            bestAnsBox.ResumeLayout(false);
            bestAnsBox.PerformLayout();
            this.AlgoConfigBox.ResumeLayout(false);
            this.AlgoConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particleCountNumeric)).EndInit();
            this.AlgoDriveBox.ResumeLayout(false);
            this.AlgoDriveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AlgoConfigBox;
        private System.Windows.Forms.Label velocityCoeffLabel;
        private System.Windows.Forms.Label selfBestAnsLabel;
        private System.Windows.Forms.TextBox currentVelocityRatioBox;
        private System.Windows.Forms.Label particleCountLabel;
        private System.Windows.Forms.Label globalBestAnsLabel;
        private System.Windows.Forms.NumericUpDown particleCountNumeric;
        private System.Windows.Forms.TextBox globalBestAnsRatioBox;
        private System.Windows.Forms.TextBox localBestAnsRatioBox;
        private System.Windows.Forms.Button initParticlesButton;
        private System.Windows.Forms.GroupBox AlgoDriveBox;
        private System.Windows.Forms.TextBox iterationCountRatio;
        private System.Windows.Forms.Button nIterationButton;
        private System.Windows.Forms.Button hundredIterationButton;
        private System.Windows.Forms.Button tenIterationButton;
        private System.Windows.Forms.Button oneIterationButton;
        private ZedGraph.ZedGraphControl _swarmGraph;
        private System.Windows.Forms.TextBox yAnsBox;
        private System.Windows.Forms.TextBox xAnsBox;
        private System.Windows.Forms.Label yAnsLabel;
        private System.Windows.Forms.Label xAnsLabel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TextBox maxValueBox;
        private System.Windows.Forms.TextBox minValueBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label1;
    }
}

