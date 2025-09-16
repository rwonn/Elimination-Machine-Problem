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
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.cmbEliminate = new System.Windows.Forms.ComboBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblX1Plus1 = new System.Windows.Forms.TextBox();
            this.lblX1Plus2 = new System.Windows.Forms.TextBox();
            this.lblX2Plus1 = new System.Windows.Forms.TextBox();
            this.lblX2Plus2 = new System.Windows.Forms.TextBox();
            this.rbTwoVariables = new System.Windows.Forms.RadioButton();
            this.rbThreeVariables = new System.Windows.Forms.RadioButton();
            this.lblX2Plus3 = new System.Windows.Forms.TextBox();
            this.lblX1Plus3 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.lblX3Equals1 = new System.Windows.Forms.TextBox();
            this.lblX3Equals2 = new System.Windows.Forms.TextBox();
            this.lblX3Equals3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1.Location = new System.Drawing.Point(16, 133);
            this.txtA1.Multiline = true;
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 29);
            this.txtA1.TabIndex = 0;
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(179, 131);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 29);
            this.txtB1.TabIndex = 1;
           
            // 
            // txtA2
            // 
            this.txtA2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA2.Location = new System.Drawing.Point(16, 193);
            this.txtA2.Multiline = true;
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 31);
            this.txtA2.TabIndex = 2;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(179, 193);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 31);
            this.txtB2.TabIndex = 3;
            this.txtB2.TextChanged += new System.EventHandler(this.txtB2_TextChanged);
            // 
            // txtD1
            // 
            this.txtD1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD1.Location = new System.Drawing.Point(586, 133);
            this.txtD1.Multiline = true;
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(100, 31);
            this.txtD1.TabIndex = 4;
            // 
            // txtD2
            // 
            this.txtD2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD2.Location = new System.Drawing.Point(586, 195);
            this.txtD2.Multiline = true;
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(100, 31);
            this.txtD2.TabIndex = 5;
            // 
            // cmbEliminate
            // 
            this.cmbEliminate.AccessibleName = "";
            this.cmbEliminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEliminate.FormattingEnabled = true;
            this.cmbEliminate.Location = new System.Drawing.Point(18, 338);
            this.cmbEliminate.Name = "cmbEliminate";
            this.cmbEliminate.Size = new System.Drawing.Size(408, 28);
            this.cmbEliminate.TabIndex = 6;
            this.cmbEliminate.Text = "CHOOSE WHICH VARIABLE TO ELIMINATE FIRST";
  
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(16, 427);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(132, 49);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "SOLVE";
            this.btnSolve.UseVisualStyleBackColor = false;
      
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(311, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 49);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSteps.Location = new System.Drawing.Point(767, 49);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(434, 457);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(18, 390);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 11;
            // 
            // lblX1Plus1
            // 
            this.lblX1Plus1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1Plus1.Location = new System.Drawing.Point(124, 131);
            this.lblX1Plus1.Multiline = true;
            this.lblX1Plus1.Name = "lblX1Plus1";
            this.lblX1Plus1.ReadOnly = true;
            this.lblX1Plus1.Size = new System.Drawing.Size(49, 29);
            this.lblX1Plus1.TabIndex = 12;
            this.lblX1Plus1.Text = "x₁ +";
            this.lblX1Plus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX1Plus2
            // 
            this.lblX1Plus2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1Plus2.Location = new System.Drawing.Point(124, 193);
            this.lblX1Plus2.Multiline = true;
            this.lblX1Plus2.Name = "lblX1Plus2";
            this.lblX1Plus2.ReadOnly = true;
            this.lblX1Plus2.Size = new System.Drawing.Size(48, 31);
            this.lblX1Plus2.TabIndex = 13;
            this.lblX1Plus2.Text = "x₁ +";
            this.lblX1Plus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX2Plus1
            // 
            this.lblX2Plus1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2Plus1.Location = new System.Drawing.Point(291, 131);
            this.lblX2Plus1.Multiline = true;
            this.lblX2Plus1.Name = "lblX2Plus1";
            this.lblX2Plus1.ReadOnly = true;
            this.lblX2Plus1.Size = new System.Drawing.Size(55, 28);
            this.lblX2Plus1.TabIndex = 14;
            this.lblX2Plus1.Text = "x₂ +";
            this.lblX2Plus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        
            // 
            // lblX2Plus2
            // 
            this.lblX2Plus2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2Plus2.Location = new System.Drawing.Point(291, 193);
            this.lblX2Plus2.Multiline = true;
            this.lblX2Plus2.Name = "lblX2Plus2";
            this.lblX2Plus2.ReadOnly = true;
            this.lblX2Plus2.Size = new System.Drawing.Size(55, 31);
            this.lblX2Plus2.TabIndex = 15;
            this.lblX2Plus2.Text = "x₂ +";
            this.lblX2Plus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbTwoVariables
            // 
            this.rbTwoVariables.AutoSize = true;
            this.rbTwoVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTwoVariables.Location = new System.Drawing.Point(142, 47);
            this.rbTwoVariables.Name = "rbTwoVariables";
            this.rbTwoVariables.Size = new System.Drawing.Size(152, 24);
            this.rbTwoVariables.TabIndex = 16;
            this.rbTwoVariables.TabStop = true;
            this.rbTwoVariables.Text = "2 Variables (x₁, x₂)";
            this.rbTwoVariables.UseVisualStyleBackColor = true;
            this.rbTwoVariables.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbThreeVariables
            // 
            this.rbThreeVariables.AutoSize = true;
            this.rbThreeVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThreeVariables.Location = new System.Drawing.Point(374, 49);
            this.rbThreeVariables.Name = "rbThreeVariables";
            this.rbThreeVariables.Size = new System.Drawing.Size(172, 24);
            this.rbThreeVariables.TabIndex = 17;
            this.rbThreeVariables.TabStop = true;
            this.rbThreeVariables.Text = "3 Variables (x₁, x₂, x₃)";
            this.rbThreeVariables.UseVisualStyleBackColor = true;
            // 
            // lblX2Plus3
            // 
            this.lblX2Plus3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2Plus3.Location = new System.Drawing.Point(291, 251);
            this.lblX2Plus3.Multiline = true;
            this.lblX2Plus3.Name = "lblX2Plus3";
            this.lblX2Plus3.ReadOnly = true;
            this.lblX2Plus3.Size = new System.Drawing.Size(55, 31);
            this.lblX2Plus3.TabIndex = 22;
            this.lblX2Plus3.Text = "x₂ +";
            this.lblX2Plus3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX1Plus3
            // 
            this.lblX1Plus3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1Plus3.Location = new System.Drawing.Point(124, 251);
            this.lblX1Plus3.Multiline = true;
            this.lblX1Plus3.Name = "lblX1Plus3";
            this.lblX1Plus3.ReadOnly = true;
            this.lblX1Plus3.Size = new System.Drawing.Size(48, 31);
            this.lblX1Plus3.TabIndex = 21;
            this.lblX1Plus3.Text = "x₁ +";
            this.lblX1Plus3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD3
            // 
            this.txtD3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD3.Location = new System.Drawing.Point(586, 253);
            this.txtD3.Multiline = true;
            this.txtD3.Name = "txtD3";
            this.txtD3.Size = new System.Drawing.Size(100, 31);
            this.txtD3.TabIndex = 20;
            // 
            // txtB3
            // 
            this.txtB3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB3.Location = new System.Drawing.Point(179, 251);
            this.txtB3.Multiline = true;
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(100, 31);
            this.txtB3.TabIndex = 19;
            // 
            // txtA3
            // 
            this.txtA3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA3.Location = new System.Drawing.Point(18, 251);
            this.txtA3.Multiline = true;
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 31);
            this.txtA3.TabIndex = 18;
            // 
            // txtC3
            // 
            this.txtC3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC3.Location = new System.Drawing.Point(365, 253);
            this.txtC3.Multiline = true;
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(100, 31);
            this.txtC3.TabIndex = 25;
            // 
            // txtC2
            // 
            this.txtC2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2.Location = new System.Drawing.Point(365, 195);
            this.txtC2.Multiline = true;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(100, 31);
            this.txtC2.TabIndex = 24;
            // 
            // txtC1
            // 
            this.txtC1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.Location = new System.Drawing.Point(365, 133);
            this.txtC1.Multiline = true;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(100, 29);
            this.txtC1.TabIndex = 23;
            // 
            // lblX3Equals1
            // 
            this.lblX3Equals1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX3Equals1.Location = new System.Drawing.Point(491, 133);
            this.lblX3Equals1.Multiline = true;
            this.lblX3Equals1.Name = "lblX3Equals1";
            this.lblX3Equals1.ReadOnly = true;
            this.lblX3Equals1.Size = new System.Drawing.Size(55, 28);
            this.lblX3Equals1.TabIndex = 26;
            this.lblX3Equals1.Text = "x₃ =";
            this.lblX3Equals1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblX3Equals1.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // lblX3Equals2
            // 
            this.lblX3Equals2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX3Equals2.Location = new System.Drawing.Point(491, 193);
            this.lblX3Equals2.Multiline = true;
            this.lblX3Equals2.Name = "lblX3Equals2";
            this.lblX3Equals2.ReadOnly = true;
            this.lblX3Equals2.Size = new System.Drawing.Size(55, 28);
            this.lblX3Equals2.TabIndex = 27;
            this.lblX3Equals2.Text = "x₃ =";
            this.lblX3Equals2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX3Equals3
            // 
            this.lblX3Equals3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX3Equals3.Location = new System.Drawing.Point(491, 254);
            this.lblX3Equals3.Multiline = true;
            this.lblX3Equals3.Name = "lblX3Equals3";
            this.lblX3Equals3.ReadOnly = true;
            this.lblX3Equals3.Size = new System.Drawing.Size(55, 28);
            this.lblX3Equals3.TabIndex = 28;
            this.lblX3Equals3.Text = "x₃ =";
            this.lblX3Equals3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1247, 689);
            this.Controls.Add(this.lblX3Equals3);
            this.Controls.Add(this.lblX3Equals2);
            this.Controls.Add(this.lblX3Equals1);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.lblX2Plus3);
            this.Controls.Add(this.lblX1Plus3);
            this.Controls.Add(this.txtD3);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.rbThreeVariables);
            this.Controls.Add(this.rbTwoVariables);
            this.Controls.Add(this.lblX2Plus2);
            this.Controls.Add(this.lblX2Plus1);
            this.Controls.Add(this.lblX1Plus2);
            this.Controls.Add(this.lblX1Plus1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.cmbEliminate);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtD1);
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

        // Add these missing event handlers to match the main code
        private void txtB2_TextChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }

        #endregion

        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.ComboBox cmbEliminate;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox lblX1Plus1;
        private System.Windows.Forms.TextBox lblX1Plus2;
        private System.Windows.Forms.TextBox lblX2Plus1;
        private System.Windows.Forms.TextBox lblX2Plus2;
        private System.Windows.Forms.RadioButton rbTwoVariables;
        private System.Windows.Forms.RadioButton rbThreeVariables;
        private System.Windows.Forms.TextBox lblX2Plus3;
        private System.Windows.Forms.TextBox lblX1Plus3;
        private System.Windows.Forms.TextBox txtD3;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox lblX3Equals1;
        private System.Windows.Forms.TextBox lblX3Equals2;
        private System.Windows.Forms.TextBox lblX3Equals3;
    }
}