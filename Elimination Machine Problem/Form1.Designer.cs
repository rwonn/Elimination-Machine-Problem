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
            this.txtA1.Location = new System.Drawing.Point(148, 87);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 0;
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(288, 87);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 20);
            this.txtB1.TabIndex = 1;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(148, 139);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 2;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(288, 139);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 20);
            this.txtB2.TabIndex = 3;
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(450, 87);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(100, 20);
            this.txtC1.TabIndex = 4;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(450, 139);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(100, 20);
            this.txtC2.TabIndex = 5;
            // 
            // cmbEliminate
            // 
            this.cmbEliminate.FormattingEnabled = true;
            this.cmbEliminate.Location = new System.Drawing.Point(148, 201);
            this.cmbEliminate.Name = "cmbEliminate";
            this.cmbEliminate.Size = new System.Drawing.Size(121, 21);
            this.cmbEliminate.TabIndex = 6;
            this.cmbEliminate.Text = "x";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(313, 199);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(453, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(148, 257);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(380, 96);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(148, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "x +";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "x +";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(395, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "y =";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(395, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(27, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "y =";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Elimination Method Solver";
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