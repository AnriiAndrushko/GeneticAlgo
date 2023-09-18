namespace GeneticAlgo
{
    partial class GeneticAlgo
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MutatorSlider = new System.Windows.Forms.TrackBar();
            this.CitiesInput = new System.Windows.Forms.NumericUpDown();
            this.IterationsInput = new System.Windows.Forms.NumericUpDown();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgentsInput = new System.Windows.Forms.NumericUpDown();
            this.AliveSlider = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MutatorSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliveSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(1253, 812);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(119, 48);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of cities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1240, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mutator chance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1240, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of iterations";
            // 
            // MutatorSlider
            // 
            this.MutatorSlider.Location = new System.Drawing.Point(1232, 79);
            this.MutatorSlider.Maximum = 100;
            this.MutatorSlider.Name = "MutatorSlider";
            this.MutatorSlider.Size = new System.Drawing.Size(130, 45);
            this.MutatorSlider.TabIndex = 7;
            this.MutatorSlider.Value = 10;
            // 
            // CitiesInput
            // 
            this.CitiesInput.Location = new System.Drawing.Point(1243, 29);
            this.CitiesInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CitiesInput.Name = "CitiesInput";
            this.CitiesInput.Size = new System.Drawing.Size(120, 20);
            this.CitiesInput.TabIndex = 8;
            this.CitiesInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // IterationsInput
            // 
            this.IterationsInput.Location = new System.Drawing.Point(1243, 143);
            this.IterationsInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IterationsInput.Name = "IterationsInput";
            this.IterationsInput.Size = new System.Drawing.Size(120, 20);
            this.IterationsInput.TabIndex = 9;
            this.IterationsInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1222, 848);
            this.canvas.TabIndex = 10;
            this.canvas.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1232, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1347, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1240, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of agents in \r\nthe sample";
            // 
            // AgentsInput
            // 
            this.AgentsInput.Location = new System.Drawing.Point(1243, 207);
            this.AgentsInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AgentsInput.Name = "AgentsInput";
            this.AgentsInput.Size = new System.Drawing.Size(120, 20);
            this.AgentsInput.TabIndex = 14;
            this.AgentsInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // AliveSlider
            // 
            this.AliveSlider.Location = new System.Drawing.Point(1239, 266);
            this.AliveSlider.Maximum = 100;
            this.AliveSlider.Name = "AliveSlider";
            this.AliveSlider.Size = new System.Drawing.Size(130, 45);
            this.AliveSlider.TabIndex = 15;
            this.AliveSlider.Value = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1246, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alive from previous \r\ngeneration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1351, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1236, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "0";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(1249, 305);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.results.Size = new System.Drawing.Size(113, 459);
            this.results.TabIndex = 19;
            // 
            // GeneticAlgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 872);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AliveSlider);
            this.Controls.Add(this.AgentsInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.IterationsInput);
            this.Controls.Add(this.CitiesInput);
            this.Controls.Add(this.MutatorSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GeneticAlgo";
            this.Text = "Genetic Algo lab1";
            this.Load += new System.EventHandler(this.GeneticAlgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MutatorSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliveSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar MutatorSlider;
        private System.Windows.Forms.NumericUpDown CitiesInput;
        private System.Windows.Forms.NumericUpDown IterationsInput;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AgentsInput;
        private System.Windows.Forms.TrackBar AliveSlider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox results;
    }
}

