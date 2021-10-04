
namespace SimpleCalculator
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
            this.additionBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNumBOX = new System.Windows.Forms.TextBox();
            this.firstNumBOX = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.substrBTN = new System.Windows.Forms.Button();
            this.multipliBTN = new System.Windows.Forms.Button();
            this.divisionBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionBTN
            // 
            this.additionBTN.Location = new System.Drawing.Point(12, 176);
            this.additionBTN.Name = "additionBTN";
            this.additionBTN.Size = new System.Drawing.Size(49, 40);
            this.additionBTN.TabIndex = 0;
            this.additionBTN.Text = "+";
            this.additionBTN.UseVisualStyleBackColor = true;
            this.additionBTN.Click += new System.EventHandler(this.additionBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.secondNumBOX);
            this.panel1.Controls.Add(this.firstNumBOX);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 98);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SECOND NUMBER:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FIRST NUMBER:";
            // 
            // secondNumBOX
            // 
            this.secondNumBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.secondNumBOX.Location = new System.Drawing.Point(114, 55);
            this.secondNumBOX.Name = "secondNumBOX";
            this.secondNumBOX.Size = new System.Drawing.Size(214, 23);
            this.secondNumBOX.TabIndex = 9;
            // 
            // firstNumBOX
            // 
            this.firstNumBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNumBOX.Location = new System.Drawing.Point(114, 18);
            this.firstNumBOX.Name = "firstNumBOX";
            this.firstNumBOX.Size = new System.Drawing.Size(214, 23);
            this.firstNumBOX.TabIndex = 8;
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OutputBox.Location = new System.Drawing.Point(12, 31);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(347, 30);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OUTPUT";
            // 
            // substrBTN
            // 
            this.substrBTN.Location = new System.Drawing.Point(67, 175);
            this.substrBTN.Name = "substrBTN";
            this.substrBTN.Size = new System.Drawing.Size(49, 41);
            this.substrBTN.TabIndex = 4;
            this.substrBTN.Text = "-";
            this.substrBTN.UseVisualStyleBackColor = true;
            this.substrBTN.Click += new System.EventHandler(this.substrBTN_Click);
            // 
            // multipliBTN
            // 
            this.multipliBTN.Location = new System.Drawing.Point(122, 175);
            this.multipliBTN.Name = "multipliBTN";
            this.multipliBTN.Size = new System.Drawing.Size(49, 41);
            this.multipliBTN.TabIndex = 5;
            this.multipliBTN.Text = "*";
            this.multipliBTN.UseVisualStyleBackColor = true;
            this.multipliBTN.Click += new System.EventHandler(this.multipliBTN_Click);
            // 
            // divisionBTN
            // 
            this.divisionBTN.Location = new System.Drawing.Point(177, 175);
            this.divisionBTN.Name = "divisionBTN";
            this.divisionBTN.Size = new System.Drawing.Size(49, 41);
            this.divisionBTN.TabIndex = 6;
            this.divisionBTN.Text = "/";
            this.divisionBTN.UseVisualStyleBackColor = true;
            this.divisionBTN.Click += new System.EventHandler(this.divisionBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(232, 175);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(127, 41);
            this.closeBTN.TabIndex = 7;
            this.closeBTN.Text = "CLOSE";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 228);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.divisionBTN);
            this.Controls.Add(this.multipliBTN);
            this.Controls.Add(this.substrBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.additionBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button additionBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button substrBTN;
        private System.Windows.Forms.Button multipliBTN;
        private System.Windows.Forms.Button divisionBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.TextBox firstNumBOX;
        private System.Windows.Forms.TextBox secondNumBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

