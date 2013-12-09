namespace JugProblem
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
            this.numericUpDownMaxJug1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxJug2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindTheWay = new System.Windows.Forms.Button();
            this.numericUpDownTarget = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMaxEmber1 = new System.Windows.Forms.Panel();
            this.panelMaxEmber2 = new System.Windows.Forms.Panel();
            this.panelIsiEmber1 = new System.Windows.Forms.Panel();
            this.panelIsiEmber2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinimumStep = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewDebug = new System.Windows.Forms.DataGridView();
            this.labelIsiJug1 = new System.Windows.Forms.Label();
            this.labelIsiJug2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxJug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxJug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownMaxJug1
            // 
            this.numericUpDownMaxJug1.Location = new System.Drawing.Point(120, 12);
            this.numericUpDownMaxJug1.Name = "numericUpDownMaxJug1";
            this.numericUpDownMaxJug1.Size = new System.Drawing.Size(75, 25);
            this.numericUpDownMaxJug1.TabIndex = 0;
            this.numericUpDownMaxJug1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownMaxJug2
            // 
            this.numericUpDownMaxJug2.Location = new System.Drawing.Point(120, 43);
            this.numericUpDownMaxJug2.Name = "numericUpDownMaxJug2";
            this.numericUpDownMaxJug2.Size = new System.Drawing.Size(75, 25);
            this.numericUpDownMaxJug2.TabIndex = 1;
            this.numericUpDownMaxJug2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukuran Ember 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukuran Ember 2";
            // 
            // buttonFindTheWay
            // 
            this.buttonFindTheWay.Location = new System.Drawing.Point(120, 105);
            this.buttonFindTheWay.Name = "buttonFindTheWay";
            this.buttonFindTheWay.Size = new System.Drawing.Size(75, 23);
            this.buttonFindTheWay.TabIndex = 4;
            this.buttonFindTheWay.Text = "Calculate";
            this.buttonFindTheWay.UseVisualStyleBackColor = true;
            this.buttonFindTheWay.Click += new System.EventHandler(this.buttonFindTheWay_Click);
            // 
            // numericUpDownTarget
            // 
            this.numericUpDownTarget.Location = new System.Drawing.Point(120, 74);
            this.numericUpDownTarget.Name = "numericUpDownTarget";
            this.numericUpDownTarget.Size = new System.Drawing.Size(75, 25);
            this.numericUpDownTarget.TabIndex = 5;
            this.numericUpDownTarget.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target";
            // 
            // panelMaxEmber1
            // 
            this.panelMaxEmber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaxEmber1.Location = new System.Drawing.Point(219, 12);
            this.panelMaxEmber1.Name = "panelMaxEmber1";
            this.panelMaxEmber1.Size = new System.Drawing.Size(52, 252);
            this.panelMaxEmber1.TabIndex = 7;
            // 
            // panelMaxEmber2
            // 
            this.panelMaxEmber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaxEmber2.Location = new System.Drawing.Point(299, 12);
            this.panelMaxEmber2.Name = "panelMaxEmber2";
            this.panelMaxEmber2.Size = new System.Drawing.Size(52, 252);
            this.panelMaxEmber2.TabIndex = 8;
            // 
            // panelIsiEmber1
            // 
            this.panelIsiEmber1.BackColor = System.Drawing.Color.LimeGreen;
            this.panelIsiEmber1.Location = new System.Drawing.Point(220, 263);
            this.panelIsiEmber1.Name = "panelIsiEmber1";
            this.panelIsiEmber1.Size = new System.Drawing.Size(50, 0);
            this.panelIsiEmber1.TabIndex = 8;
            // 
            // panelIsiEmber2
            // 
            this.panelIsiEmber2.BackColor = System.Drawing.Color.LimeGreen;
            this.panelIsiEmber2.Location = new System.Drawing.Point(300, 263);
            this.panelIsiEmber2.Name = "panelIsiEmber2";
            this.panelIsiEmber2.Size = new System.Drawing.Size(50, 0);
            this.panelIsiEmber2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minimum step";
            // 
            // numericUpDownMinimumStep
            // 
            this.numericUpDownMinimumStep.Location = new System.Drawing.Point(120, 134);
            this.numericUpDownMinimumStep.Name = "numericUpDownMinimumStep";
            this.numericUpDownMinimumStep.Size = new System.Drawing.Size(75, 25);
            this.numericUpDownMinimumStep.TabIndex = 11;
            // 
            // dataGridViewDebug
            // 
            this.dataGridViewDebug.AllowUserToAddRows = false;
            this.dataGridViewDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDebug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebug.Location = new System.Drawing.Point(367, 12);
            this.dataGridViewDebug.Name = "dataGridViewDebug";
            this.dataGridViewDebug.Size = new System.Drawing.Size(433, 272);
            this.dataGridViewDebug.TabIndex = 12;
            // 
            // labelIsiJug1
            // 
            this.labelIsiJug1.Location = new System.Drawing.Point(219, 267);
            this.labelIsiJug1.Name = "labelIsiJug1";
            this.labelIsiJug1.Size = new System.Drawing.Size(52, 17);
            this.labelIsiJug1.TabIndex = 13;
            this.labelIsiJug1.Text = "0";
            this.labelIsiJug1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIsiJug2
            // 
            this.labelIsiJug2.Location = new System.Drawing.Point(299, 267);
            this.labelIsiJug2.Name = "labelIsiJug2";
            this.labelIsiJug2.Size = new System.Drawing.Size(52, 17);
            this.labelIsiJug2.TabIndex = 14;
            this.labelIsiJug2.Text = "0";
            this.labelIsiJug2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(180, 119);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIsiJug2);
            this.Controls.Add(this.labelIsiJug1);
            this.Controls.Add(this.dataGridViewDebug);
            this.Controls.Add(this.numericUpDownMinimumStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelIsiEmber1);
            this.Controls.Add(this.panelIsiEmber2);
            this.Controls.Add(this.panelMaxEmber2);
            this.Controls.Add(this.panelMaxEmber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTarget);
            this.Controls.Add(this.buttonFindTheWay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMaxJug2);
            this.Controls.Add(this.numericUpDownMaxJug1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxJug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxJug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMaxJug1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxJug2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindTheWay;
        private System.Windows.Forms.NumericUpDown numericUpDownTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMaxEmber1;
        private System.Windows.Forms.Panel panelMaxEmber2;
        private System.Windows.Forms.Panel panelIsiEmber1;
        private System.Windows.Forms.Panel panelIsiEmber2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumStep;
        private System.Windows.Forms.DataGridView dataGridViewDebug;
        private System.Windows.Forms.Label labelIsiJug1;
        private System.Windows.Forms.Label labelIsiJug2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

