using System;

namespace Elimination_Machine_Problem
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.cmbEliminate = new System.Windows.Forms.ComboBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1.Location = new System.Drawing.Point(20, 51);
            this.txtA1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA1.Multiline = true;
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(132, 35);
            this.txtA1.TabIndex = 0;
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(236, 51);
            this.txtB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(132, 35);
            this.txtB1.TabIndex = 1;
            this.txtB1.TextChanged += new System.EventHandler(this.txtB1_TextChanged);
            // 
            // txtA2
            // 
            this.txtA2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA2.Location = new System.Drawing.Point(22, 136);
            this.txtA2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA2.Multiline = true;
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(132, 37);
            this.txtA2.TabIndex = 2;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(236, 136);
            this.txtB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(132, 37);
            this.txtB2.TabIndex = 3;
            // 
            // txtC1
            // 
            this.txtC1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.Location = new System.Drawing.Point(455, 51);
            this.txtC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC1.Multiline = true;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(132, 37);
            this.txtC1.TabIndex = 4;
            // 
            // txtC2
            // 
            this.txtC2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2.Location = new System.Drawing.Point(457, 136);
            this.txtC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC2.Multiline = true;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(132, 37);
            this.txtC2.TabIndex = 5;
            // 
            // cmbEliminate
            // 
            this.cmbEliminate.AccessibleName = "";
            this.cmbEliminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEliminate.FormattingEnabled = true;
            this.cmbEliminate.Location = new System.Drawing.Point(20, 216);
            this.cmbEliminate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEliminate.Name = "cmbEliminate";
            this.cmbEliminate.Size = new System.Drawing.Size(348, 28);
            this.cmbEliminate.TabIndex = 6;
            this.cmbEliminate.Text = "CHOOSE WHICH TO ELIMINATE FIRST";
            this.cmbEliminate.SelectedIndexChanged += new System.EventHandler(this.cmbEliminate_SelectedIndexChanged_1);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(22, 526);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(176, 60);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "SOLVE";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(415, 526);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 60);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSteps.Location = new System.Drawing.Point(616, 24);
            this.rtbSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(577, 562);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(198, 431);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 35);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "x₁ +";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(165, 136);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(63, 37);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "x₁ +";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(385, 51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(53, 33);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "x₂ =";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(387, 136);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(53, 37);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "x₂ =";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1221, 611);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.cmbEliminate);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Elimination Method Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        private void cmbEliminate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event handler can be used to respond to selection changes if needed
            // Currently no action required - selection will be checked when Solve is clicked
        }

        #endregion

        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.ComboBox cmbEliminate;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}