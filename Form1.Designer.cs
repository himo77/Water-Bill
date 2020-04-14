namespace Water_Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.secondtxt = new System.Windows.Forms.TextBox();
            this.thirdtxt = new System.Windows.Forms.TextBox();
            this.fourthtxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.avgtxt = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Quarter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Quarter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Third Quarter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fourth Quarter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Average";
            // 
            // firsttxt
            // 
            this.firsttxt.Location = new System.Drawing.Point(215, 36);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(100, 31);
            this.firsttxt.TabIndex = 6;
            // 
            // secondtxt
            // 
            this.secondtxt.Location = new System.Drawing.Point(214, 88);
            this.secondtxt.Name = "secondtxt";
            this.secondtxt.Size = new System.Drawing.Size(100, 31);
            this.secondtxt.TabIndex = 7;
            // 
            // thirdtxt
            // 
            this.thirdtxt.Location = new System.Drawing.Point(214, 141);
            this.thirdtxt.Name = "thirdtxt";
            this.thirdtxt.Size = new System.Drawing.Size(100, 31);
            this.thirdtxt.TabIndex = 8;
            // 
            // fourthtxt
            // 
            this.fourthtxt.Location = new System.Drawing.Point(214, 196);
            this.fourthtxt.Name = "fourthtxt";
            this.fourthtxt.Size = new System.Drawing.Size(100, 31);
            this.fourthtxt.TabIndex = 9;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(651, 135);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(100, 31);
            this.totaltxt.TabIndex = 10;
            // 
            // avgtxt
            // 
            this.avgtxt.Location = new System.Drawing.Point(651, 196);
            this.avgtxt.Name = "avgtxt";
            this.avgtxt.ReadOnly = true;
            this.avgtxt.Size = new System.Drawing.Size(100, 31);
            this.avgtxt.TabIndex = 11;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(85, 307);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(132, 44);
            this.btncalc.TabIndex = 12;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(336, 307);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 44);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 307);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.avgtxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.fourthtxt);
            this.Controls.Add(this.thirdtxt);
            this.Controls.Add(this.secondtxt);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Water bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.TextBox secondtxt;
        private System.Windows.Forms.TextBox thirdtxt;
        private System.Windows.Forms.TextBox fourthtxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox avgtxt;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

