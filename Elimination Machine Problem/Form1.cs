using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elimination_Machine_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupComboBox(); // Ensure ComboBox is properly initialized
            ConnectEventHandlers();
        }

        private void SetupComboBox()
        {
            // Clear any existing items and add our options
            cmbEliminate.Items.Clear();
            cmbEliminate.Items.Add("Eliminate x₁");
            cmbEliminate.Items.Add("Eliminate x₂");
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

                double a2 = double.Parse(txtA2.Text);
                double b2 = double.Parse(txtB2.Text);
                double c2 = double.Parse(txtC2.Text);

                // Unicode subscripts
                string x1s = "x₁"; // x₁
                string x2s = "x₂"; // x₂

                rtbSteps.Clear();
                rtbSteps.AppendText("Step 1: Write the system of equations\n");
                rtbSteps.AppendText(FormatEquation(a1, b1, c1, x1s, x2s) + "\n");
                rtbSteps.AppendText(FormatEquation(a2, b2, c2, x1s, x2s) + "\n\n");

                string choice = cmbEliminate.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(choice))
                {
                    lblResult.Text = "Please select which variable to eliminate.";
                    return;
                }

                double factor1, factor2;
                double A1, B1, C1, A2, B2, C2;

                if (choice == "Eliminate x₁")
                {
                    // Find LCM of coefficients to eliminate x₁
                    if (a1 == 0 || a2 == 0)
                    {
                        lblResult.Text = "Cannot eliminate x₁: one coefficient is zero.";
                        return;
                    }

                    factor1 = Math.Abs(a2);
                    factor2 = Math.Abs(a1);

                    // Make sure we eliminate properly by using opposite signs
                    if ((a1 > 0 && a2 > 0) || (a1 < 0 && a2 < 0))
                    {
                        factor2 = -factor2;
                    }

                    A1 = a1 * factor1; B1 = b1 * factor1; C1 = c1 * factor1;
                    A2 = a2 * factor2; B2 = b2 * factor2; C2 = c2 * factor2;

                    rtbSteps.AppendText($"Step 2: Multiply first equation by {factor1} and second by {factor2}\n");
                    rtbSteps.AppendText(FormatEquation(A1, B1, C1, x1s, x2s) + "\n");
                    rtbSteps.AppendText(FormatEquation(A2, B2, C2, x1s, x2s) + "\n\n");

                    // Add equations to eliminate x₁
                    double coeffX2 = B1 + B2;
                    double constant = C1 + C2;

                    rtbSteps.AppendText("Step 3: Add equations to eliminate " + x1s + "\n");
                    if (coeffX2 == 1)
                        rtbSteps.AppendText($"{x2s} = {constant}\n\n");
                    else if (coeffX2 == -1)
                        rtbSteps.AppendText($"-{x2s} = {constant}\n\n");
                    else
                        rtbSteps.AppendText($"{coeffX2}{x2s} = {constant}\n\n");

                    if (coeffX2 == 0)
                    {
                        if (constant == 0)
                            lblResult.Text = "Infinite solutions (dependent system).";
                        else
                            lblResult.Text = "No solution (inconsistent system).";
                        return;
                    }

                    double x2 = constant / coeffX2;
                    rtbSteps.AppendText($"Step 4: Solve for {x2s}\n");
                    rtbSteps.AppendText($"{x2s} = {constant} ÷ {coeffX2} = {x2:F3}\n\n");

                    // Substitute back to find x₁
                    double x1 = (c1 - b1 * x2) / a1;
                    rtbSteps.AppendText($"Step 5: Substitute {x2s} = {x2:F3} into first equation\n");
                    rtbSteps.AppendText(FormatEquation(a1, b1, c1, x1s, x2s) + "\n");
                    rtbSteps.AppendText($"{a1}{x1s} + {b1}({x2:F3}) = {c1}\n");
                    rtbSteps.AppendText($"{a1}{x1s} = {c1} - {b1 * x2:F3}\n");
                    rtbSteps.AppendText($"{x1s} = {(c1 - b1 * x2):F3} ÷ {a1} = {x1:F3}\n\n");

                    lblResult.Text = $"Solution: {x1s} = {x1:F3}, {x2s} = {x2:F3}";
                }
                else if (choice == "Eliminate x₂")
                {
                    // Find LCM of coefficients to eliminate x₂
                    if (b1 == 0 || b2 == 0)
                    {
                        lblResult.Text = "Cannot eliminate x₂: one coefficient is zero.";
                        return;
                    }

                    factor1 = Math.Abs(b2);
                    factor2 = Math.Abs(b1);

                    // Make sure we eliminate properly by using opposite signs
                    if ((b1 > 0 && b2 > 0) || (b1 < 0 && b2 < 0))
                    {
                        factor2 = -factor2;
                    }

                    A1 = a1 * factor1; B1 = b1 * factor1; C1 = c1 * factor1;
                    A2 = a2 * factor2; B2 = b2 * factor2; C2 = c2 * factor2;

                    rtbSteps.AppendText($"Step 2: Multiply first equation by {factor1} and second by {factor2}\n");
                    rtbSteps.AppendText(FormatEquation(A1, B1, C1, x1s, x2s) + "\n");
                    rtbSteps.AppendText(FormatEquation(A2, B2, C2, x1s, x2s) + "\n\n");

                    // Add equations to eliminate x₂
                    double coeffX1 = A1 + A2;
                    double constant = C1 + C2;

                    rtbSteps.AppendText("Step 3: Add equations to eliminate " + x2s + "\n");
                    if (coeffX1 == 1)
                        rtbSteps.AppendText($"{x1s} = {constant}\n\n");
                    else if (coeffX1 == -1)
                        rtbSteps.AppendText($"-{x1s} = {constant}\n\n");
                    else
                        rtbSteps.AppendText($"{coeffX1}{x1s} = {constant}\n\n");

                    if (coeffX1 == 0)
                    {
                        if (constant == 0)
                            lblResult.Text = "Infinite solutions (dependent system).";
                        else
                            lblResult.Text = "No solution (inconsistent system).";
                        return;
                    }

                    double x1 = constant / coeffX1;
                    rtbSteps.AppendText($"Step 4: Solve for {x1s}\n");
                    rtbSteps.AppendText($"{x1s} = {constant} ÷ {coeffX1} = {x1:F3}\n\n");

                    // Substitute back to find x₂
                    double x2 = (c1 - a1 * x1) / b1;
                    rtbSteps.AppendText($"Step 5: Substitute {x1s} = {x1:F3} into first equation\n");
                    rtbSteps.AppendText(FormatEquation(a1, b1, c1, x1s, x2s) + "\n");
                    rtbSteps.AppendText($"{a1}({x1:F3}) + {b1}{x2s} = {c1}\n");
                    rtbSteps.AppendText($"{b1}{x2s} = {c1} - {a1 * x1:F3}\n");
                    rtbSteps.AppendText($"{x2s} = {(c1 - a1 * x1):F3} ÷ {b1} = {x2:F3}\n\n");

                    lblResult.Text = $"Solution: {x1s} = {x1:F3}, {x2s} = {x2:F3}";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Invalid input. Please enter numeric values.";
            }
            catch (DivideByZeroException)
            {
                lblResult.Text = "Division by zero error. Check your coefficients.";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtA1.Clear();
            txtB1.Clear();
            txtC1.Clear();
            txtA2.Clear();
            txtB2.Clear();
            txtC2.Clear();

            // Clear steps, result, and selection
            rtbSteps.Clear();
            lblResult.Text = "";
            cmbEliminate.SelectedIndex = -1;
        }

        /// <summary>
        /// Formats an equation as a readable string like: 2x₁ + 3x₂ = 7
        /// </summary>
        private string FormatEquation(double a, double b, double c, string x1s, string x2s)
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
                if (eq.Length > 0) // There's already a term
                {
                    if (b > 0) eq += " + ";
                    else eq += " - ";

                    double absB = Math.Abs(b);
                    if (absB == 1) eq += x2s;
                    else eq += $"{absB}{x2s}";
                }
                else // This is the first term
                {
                    if (b == 1) eq += x2s;
                    else if (b == -1) eq += $"-{x2s}";
                    else eq += $"{b}{x2s}";
                }
            }

            // If both a and b are 0
            if (a == 0 && b == 0) eq = "0";

            // Add RHS
            eq += $" = {c}";
            return eq;
        }
    }
}