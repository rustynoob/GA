namespace GA
{
    partial class WindowGA
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
            this.MaxGen = new System.Windows.Forms.Label();
            this.init = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setMutFact = new System.Windows.Forms.NumericUpDown();
            this.setPopSize = new System.Windows.Forms.NumericUpDown();
            this.setMaxGens = new System.Windows.Forms.NumericUpDown();
            this.mutFact = new System.Windows.Forms.Label();
            this.PopSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fit = new System.Windows.Forms.TextBox();
            this.CityCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SampSize = new System.Windows.Forms.NumericUpDown();
            this.MapDivrg = new System.Windows.Forms.NumericUpDown();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setMutFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMaxGens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapDivrg)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxGen
            // 
            this.MaxGen.AutoSize = true;
            this.MaxGen.Location = new System.Drawing.Point(6, 16);
            this.MaxGen.Name = "MaxGen";
            this.MaxGen.Size = new System.Drawing.Size(85, 13);
            this.MaxGen.TabIndex = 0;
            this.MaxGen.Text = "Max generations";
            // 
            // init
            // 
            this.init.Location = new System.Drawing.Point(166, 118);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 23);
            this.init.TabIndex = 1;
            this.init.Text = "initilize";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.run_Click_1);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.CityCount);
            this.settings.Controls.Add(this.setMutFact);
            this.settings.Controls.Add(this.setPopSize);
            this.settings.Controls.Add(this.setMaxGens);
            this.settings.Controls.Add(this.mutFact);
            this.settings.Controls.Add(this.PopSize);
            this.settings.Controls.Add(this.init);
            this.settings.Controls.Add(this.MaxGen);
            this.settings.Location = new System.Drawing.Point(12, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(247, 148);
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            this.settings.Text = "GA settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Cities";
            // 
            // setMutFact
            // 
            this.setMutFact.Location = new System.Drawing.Point(121, 66);
            this.setMutFact.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setMutFact.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setMutFact.Name = "setMutFact";
            this.setMutFact.Size = new System.Drawing.Size(120, 20);
            this.setMutFact.TabIndex = 5;
            this.setMutFact.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // setPopSize
            // 
            this.setPopSize.AccessibleName = "";
            this.setPopSize.Location = new System.Drawing.Point(121, 40);
            this.setPopSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.setPopSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.setPopSize.Name = "setPopSize";
            this.setPopSize.Size = new System.Drawing.Size(120, 20);
            this.setPopSize.TabIndex = 4;
            this.setPopSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // setMaxGens
            // 
            this.setMaxGens.Location = new System.Drawing.Point(121, 14);
            this.setMaxGens.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.setMaxGens.Name = "setMaxGens";
            this.setMaxGens.Size = new System.Drawing.Size(120, 20);
            this.setMaxGens.TabIndex = 3;
            this.setMaxGens.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // mutFact
            // 
            this.mutFact.AutoSize = true;
            this.mutFact.Location = new System.Drawing.Point(6, 68);
            this.mutFact.Name = "mutFact";
            this.mutFact.Size = new System.Drawing.Size(78, 13);
            this.mutFact.TabIndex = 2;
            this.mutFact.Text = "Mutation factor";
            // 
            // PopSize
            // 
            this.PopSize.AutoSize = true;
            this.PopSize.Location = new System.Drawing.Point(6, 42);
            this.PopSize.Name = "PopSize";
            this.PopSize.Size = new System.Drawing.Size(80, 13);
            this.PopSize.TabIndex = 1;
            this.PopSize.Text = "Population Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fittness";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(165, 80);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 5;
            this.run.Text = " run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fit
            // 
            this.fit.AllowDrop = true;
            this.fit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fit.Location = new System.Drawing.Point(281, 42);
            this.fit.Multiline = true;
            this.fit.Name = "fit";
            this.fit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fit.Size = new System.Drawing.Size(646, 483);
            this.fit.TabIndex = 7;
            this.fit.Text = "  ";
            // 
            // CityCount
            // 
            this.CityCount.Location = new System.Drawing.Point(121, 92);
            this.CityCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CityCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CityCount.Name = "CityCount";
            this.CityCount.Size = new System.Drawing.Size(120, 20);
            this.CityCount.TabIndex = 8;
            this.CityCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MapDivrg);
            this.groupBox1.Controls.Add(this.SampSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.run);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "batch settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sample size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "map divergance";
            // 
            // SampSize
            // 
            this.SampSize.Location = new System.Drawing.Point(121, 24);
            this.SampSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SampSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SampSize.Name = "SampSize";
            this.SampSize.Size = new System.Drawing.Size(120, 20);
            this.SampSize.TabIndex = 8;
            this.SampSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MapDivrg
            // 
            this.MapDivrg.Location = new System.Drawing.Point(121, 54);
            this.MapDivrg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MapDivrg.Name = "MapDivrg";
            this.MapDivrg.Size = new System.Drawing.Size(120, 20);
            this.MapDivrg.TabIndex = 9;
            this.MapDivrg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WindowGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings);
            this.Name = "WindowGA";
            this.Text = "GA";
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setMutFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMaxGens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapDivrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MaxGen;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.Label PopSize;
        private System.Windows.Forms.Label mutFact;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown setMutFact;
        private System.Windows.Forms.NumericUpDown setPopSize;
        private System.Windows.Forms.NumericUpDown setMaxGens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fit;
        private System.Windows.Forms.NumericUpDown CityCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MapDivrg;
        private System.Windows.Forms.NumericUpDown SampSize;

    }
}

