using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskPlanSim
{
    public partial class MainForm : Form
    {
        private Simulaator sim;
        private string algoInputString;
        private Bitmap chart;

        public MainForm()
        {
            InitializeComponent();
            sim = new Simulaator();
            algoInputString = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void LoadAlgoInput()
        {
            // Check if custom input is selected & copy input from the textbox
            if (customAlgo.Checked && (customAlgoTextbox.Text.Length != 0))
            {
                algoInputString = customAlgoTextbox.Text;
            }
            else
            {
                // Find the selected radio button (yes there are many better ways to do this)
                algoInputString = sampleAlgo1.Checked ? sampleAlgo1.Text :
                    (sampleAlgo2.Checked ? sampleAlgo2.Text :
                    (sampleAlgo3.Checked ? sampleAlgo3.Text : ""));
            }
        }

        private void StartAlgorithm(string algorithm)
        {
            Clear();
            LoadAlgoInput();

            if (String.IsNullOrEmpty(algoInputString)) return; // No input was given at all, exit.

            // Display messagebox on error (wrong string format)
            try { sim.LoadFromString(algoInputString); }
            catch (FormatException)
            {
                MessageBox.Show("Vale sisend!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chosenAlgoLabel.Text = algorithm;

            // Algorithm switcher based on the given parameter
            switch (algorithm)
            {
                case "FCFS":
                    sim.FCFS();
                    break;
                case "SSTF":
                    sim.SSTF();
                    break;
                case "SCAN":
                    sim.SCAN();
                    break;
                case "LOOK":
                    sim.LOOK();
                    break;
                default:
                    return;
            }

            pathLabel.Text = sim.Path.ToString();

            DrawSimulation();
        }

        private void DrawSimulation()
        {
            int boxWidth = 20;
            int boxHeight = 20;
            int pointSize = 8;
            chart = new Bitmap(simChart.Width, simChart.Height);

            using (Graphics gr = Graphics.FromImage(chart))
            using (Brush blackBrush = new SolidBrush(Color.Black))
            using (Font font = new Font("Consolas", 10))
            {
                gr.Clear(SystemColors.Control);
                gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                for (int i = 0, j = 0, xPos = 0; i < 50; i++, xPos += boxWidth, j++)
                {
                    // Draw top numbers and boxes
                    string number = i + "";
                    SizeF stringSize = gr.MeasureString(number, font);
                    PointF stringLocation = new PointF(xPos + (boxWidth / 2) - (stringSize.Width / 2),
                                                       (boxHeight / 2) - (stringSize.Height / 2) + 1);
                    gr.DrawString(number, font, blackBrush, stringLocation);

                    Rectangle rect = new Rectangle(xPos, boxHeight, boxWidth, boxHeight);
                    using (Pen selPen = new Pen(Color.Black))
                    {
                        gr.DrawRectangle(selPen, rect);
                    }

                    if (j >= sim.Sectors.Count) continue;

                    // Draw "x" under sector number
                    stringSize = gr.MeasureString("x", font);
                    stringLocation = new PointF(boxWidth * sim.Sectors[j] + (boxWidth / 2) - (stringSize.Width / 2),
                                                       boxHeight + (boxHeight / 2) - (stringSize.Height / 2));
                    gr.DrawString("x", font, blackBrush, stringLocation);
                }

                for (int i = 1, yPos = 3*boxHeight; i < sim.Result.Count; i++)
                {
                    // Previous point
                    Point prev = new Point(boxWidth * sim.Result[i - 1] + (boxWidth / 2), yPos + (boxHeight / 2));
                    gr.FillEllipse(blackBrush, prev.X - 4, prev.Y - 4, pointSize, pointSize);
                    
                    // Current point
                    yPos += boxHeight + 2;
                    Point now = new Point(boxWidth * sim.Result[i] + (boxWidth / 2), yPos + (boxHeight / 2));
                    gr.FillEllipse(blackBrush, now.X - 4, now.Y - 4, pointSize, pointSize);

                    // Connect the points
                    gr.DrawLine(Pens.Black, prev, now);
                }
            }

            simChart.Image = chart;
        }

        private void Clear()
        {
            sim.Clear();
            chosenAlgoLabel.Text = "---";
            pathLabel.Text = "0";
            simChart.Image = null;
            GC.Collect();
        }

        private void FCFSButton_Click(object sender, EventArgs e) { StartAlgorithm("FCFS"); }
        private void SSTFButton_Click(object sender, EventArgs e) { StartAlgorithm("SSTF"); }
        private void SCANButton_Click(object sender, EventArgs e) { StartAlgorithm("SCAN"); }
        private void LOOKButton_Click(object sender, EventArgs e) { StartAlgorithm("LOOK"); }
        private void ClearButton_Click(object sender, EventArgs e) { Clear(); }

        // Switch to the "custom algorithm" option automatically when selecting its input textbox
        private void customAlgoTextbox_TextChanged(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void customAlgoTextbox_Click(object sender, EventArgs e) { customAlgo.Checked = true; }
        private void customAlgoTextbox_Enter(object sender, EventArgs e) { customAlgo.Checked = true; }
    }
}
