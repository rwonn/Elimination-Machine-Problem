using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elimination_Machine_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupComboBox();
            ConnectEventHandlers();
            SetupRadioButtons();
            UpdateUIForVariableCount(); // Initialize UI state
        }

        private void SetupRadioButtons()
        {
            rbTwoVariables.Checked = true; // Default to 2 variables
            rbTwoVariables.CheckedChanged += RadioButtons_CheckedChanged;
            rbThreeVariables.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIForVariableCount();
        }

        private void UpdateUIForVariableCount()
        {
            bool isThreeVariables = rbThreeVariables.Checked;

            // Show/hide controls for 3rd variable
            txtC1.Visible = isThreeVariables;
            txtC2.Visible = isThreeVariables;
            txtA3.Visible = isThreeVariables;
            txtB3.Visible = isThreeVariables;
            txtC3.Visible = isThreeVariables;
            txtD3.Visible = isThreeVariables;

            // Update labels visibility (you'll need to add these labels)
            // lblC1.Visible = isThreeVariables;
            // lblC2.Visible = isThreeVariables;
            // lblEquation3.Visible = isThreeVariables;

            // Update ComboBox options
            SetupComboBox();

            // Clear previous results
            rtbSteps.Clear();
            lblResult.Text = "";
        }

        private void SetupComboBox()
        {
            cmbEliminate.Items.Clear();

            if (rbTwoVariables.Checked)
            {
                cmbEliminate.Items.Add("Eliminate x₁");
                cmbEliminate.Items.Add("Eliminate x₂");
            }
            else
            {
                cmbEliminate.Items.Add("Eliminate x₁");
                cmbEliminate.Items.Add("Eliminate x₂");
                cmbEliminate.Items.Add("Eliminate x₃");
            }

            cmbEliminate.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConnectEventHandlers()
        {
            btnSolve.Click += btnSolve_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs
                double a1 = double.Parse(txtA1.Text);
                double b1 = double.Parse(txtB1.Text);
                double c1 = double.Parse(txtC1.Text);
                double d1 = double.Parse(txtD1.Text);

                double a2 = double.Parse(txtA2.Text);
                double b2 = double.Parse(txtB2.Text);
                double c2 = double.Parse(txtC2.Text);
                double d2 = double.Parse(txtD2.Text);

                double a3 = double.Parse(txtA3.Text);
                double b3 = double.Parse(txtB3.Text);
                double c3 = double.Parse(txtC3.Text);
                double d3 = double.Parse(txtD3.Text);

                string x1s = "x₁", x2s = "x₂", x3s = "x₃";

                rtbSteps.Clear();
                rtbSteps.AppendText("Step 1: Write the system of equations\n");
                rtbSteps.AppendText(FormatEquation(a1, b1, c1, d1, x1s, x2s, x3s) + "\n");
                rtbSteps.AppendText(FormatEquation(a2, b2, c2, d2, x1s, x2s, x3s) + "\n");
                rtbSteps.AppendText(FormatEquation(a3, b3, c3, d3, x1s, x2s, x3s) + "\n\n");

                // === Step 2: Eliminate x₁ from Eq2 ===
                double f21 = Math.Abs(a1);
                double f22 = Math.Abs(a2);
                if ((a1 > 0 && a2 > 0) || (a1 < 0 && a2 < 0)) f22 = -f22;

                double A1 = a1 * f21, B1 = b1 * f21, C1 = c1 * f21, D1 = d1 * f21;
                double A2 = a2 * f22, B2 = b2 * f22, C2 = c2 * f22, D2 = d2 * f22;

                double newB2 = B1 + B2, newC2 = C1 + C2, newD2 = D1 + D2;

                rtbSteps.AppendText("Step 2: Eliminate " + x1s + " from Eq2\n");
                rtbSteps.AppendText($"{newB2}{x2s} + {newC2}{x3s} = {newD2}\n\n");

                // === Step 3: Eliminate x₁ from Eq3 ===
                double f31 = Math.Abs(a1);
                double f32 = Math.Abs(a3);
                if ((a1 > 0 && a3 > 0) || (a1 < 0 && a3 < 0)) f32 = -f32;

                double A1b = a1 * f31, B1b = b1 * f31, C1b = c1 * f31, D1b = d1 * f31;
                double A3 = a3 * f32, B3 = b3 * f32, C3 = c3 * f32, D3 = d3 * f32;

                double newB3 = B1b + B3, newC3 = C1b + C3, newD3 = D1b + D3;

                rtbSteps.AppendText("Step 3: Eliminate " + x1s + " from Eq3\n");
                rtbSteps.AppendText($"{newB3}{x2s} + {newC3}{x3s} = {newD3}\n\n");

                // === Step 4: Eliminate x₂ between new Eq2 & Eq3 ===
                double f41 = Math.Abs(newB2);
                double f42 = Math.Abs(newB3);
                if ((newB2 > 0 && newB3 > 0) || (newB2 < 0 && newB3 < 0)) f42 = -f42;

                double NB2 = newB2 * f41, NC2 = newC2 * f41, ND2 = newD2 * f41;
                double NB3 = newB3 * f42, NC3 = newC3 * f42, ND3 = newD3 * f42;

                double finalC = NC2 + NC3;
                double finalD = ND2 + ND3;

                rtbSteps.AppendText("Step 4: Eliminate " + x2s + "\n");
                rtbSteps.AppendText($"{finalC}{x3s} = {finalD}\n\n");

                // === Step 5: Solve for x₃ directly ===
                if (finalC == 0)
                {
                    if (finalD == 0) lblResult.Text = "Infinite solutions (dependent system).";
                    else lblResult.Text = "No solution (inconsistent system).";
                    return;
                }

                double x3 = finalD / finalC;
                rtbSteps.AppendText("Step 5: Solve for " + x3s + "\n");
                rtbSteps.AppendText($"{x3s} = {finalD} ÷ {finalC} = {x3:F3}\n\n");

                // === Step 6: Plug x₃ into new Eq2 (still elimination style) ===
                double coeffX2 = newB2;
                double constX2 = newD2 - newC2 * x3;
                double x2 = constX2 / coeffX2;

                rtbSteps.AppendText("Step 6: Solve for " + x2s + "\n");
                rtbSteps.AppendText($"{x2s} = {constX2} ÷ {coeffX2} = {x2:F3}\n\n");

                // === Step 7: Plug x₂ and x₃ into Eq1 ===
                double coeffX1 = a1;
                double constX1 = d1 - b1 * x2 - c1 * x3;
                double x1 = constX1 / coeffX1;

                rtbSteps.AppendText("Step 7: Solve for " + x1s + "\n");
                rtbSteps.AppendText($"{x1s} = {constX1} ÷ {coeffX1} = {x1:F3}\n\n");

                lblResult.Text = $"Solution: {x1s} = {x1:F3}, {x2s} = {x2:F3}, {x3s} = {x3:F3}";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
            }
        }

        private string FormatEquation(double a, double b, double c, double d, string x1s, string x2s, string x3s)
        {
            string eq = "";

            if (a != 0) eq += $"{a}{x1s}";
            if (b != 0) eq += (eq.Length > 0 ? " + " : "") + $"{b}{x2s}";
            if (c != 0) eq += (eq.Length > 0 ? " + " : "") + $"{c}{x3s}";
            if (eq.Length == 0) eq = "0";
            eq += $" = {d}";
            return eq;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtA1.Clear();
            txtB1.Clear();
            txtD1.Clear();
            txtA2.Clear();
            txtB2.Clear();
            txtD2.Clear();

            // Clear 3-variable specific textboxes
            txtC1.Clear();
            txtC2.Clear();
            txtA3.Clear();
            txtB3.Clear();
            txtC3.Clear();
            txtD3.Clear();

            // Clear steps, result, and selection
            rtbSteps.Clear();
            lblResult.Text = "";
            cmbEliminate.SelectedIndex = -1;
        }

        private double MyAbs(double num)
        {
            return num < 0 ? -num : num;
        }

        private string FormatEquation2Var(double a, double b, double d, string x1s, string x2s)
        {
            string eq = "";

            // x₁ term
            if (a != 0)
            {
                if (a == 1) eq += x1s;
                else if (a == -1) eq += $"-{x1s}";
                else eq += $"{a}{x1s}";
            }

            // x₂ term
            if (b != 0)
            {
                if (eq.Length > 0)
                {
                    if (b > 0) eq += " + ";
                    else eq += " - ";

                    double absB = MyAbs(b);
                    if (absB == 1) eq += x2s;
                    else eq += $"{absB}{x2s}";
                }
                else
                {
                    if (b == 1) eq += x2s;
                    else if (b == -1) eq += $"-{x2s}";
                    else eq += $"{b}{x2s}";
                }
            }

            if (a == 0 && b == 0) eq = "0";

            eq += $" = {d}";
            return eq;
        }

        
    }
}