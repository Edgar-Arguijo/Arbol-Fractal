using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalGenerator
{
    public partial class Form1 :Form
    {
        Graphics papel;

        int StartHeight = 100;
        FractalLine Trunk = null;
        bool Draw = false;

        double ShrinkRate;
        double AngleDelta;
        int SplitDepth;
        public Form1()
        {
            InitializeComponent();
            UpdateParameters();
            papel = DrawCanvas.CreateGraphics();
        }

        public void InvokeUI(Action a)
        {
            this.Invoke(a);
        }

        private void UpdateParameters()
        {
            AngleDelta = TrackAngleDelta.Value;
            ShrinkRate = (double)TrackShrinkRatio.Value / TrackShrinkRatio.Maximum;
            SplitDepth = TrackSplitDepth.Value;
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (Draw == false)
                return;

            Pen pen = new Pen(Color.Black, 2);
            Trunk.Draw(e.Graphics, pen);
        }

        private void AddBranch(FractalLine parent, int Depth)
        {
            if (Depth > SplitDepth || Draw == false)
                return;

            double Angle1 = parent.m_Angle - AngleDelta;
            double Angle2 = parent.m_Angle + AngleDelta;

            FractalLine line = new FractalLine(parent.m_End, (int)(parent.CalcLength() * ShrinkRate), Angle1, parent);
            FractalLine line2 = new FractalLine(parent.m_End, (int)(parent.CalcLength() * ShrinkRate), Angle2, parent);

            System.Threading.Thread.Sleep(Int32.Parse(txtAnimDelay.Text));

            Action a = () => DrawCanvas.Refresh();
            InvokeUI(a);

            if (Depth % 2 == 0)
            {
                AddBranch(line, Depth + 1);
                AddBranch(line2, Depth + 1);
            }
            else
            {
                AddBranch(line2, Depth + 1);
                AddBranch(line, Depth + 1);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Draw = false;
            papel.Clear(Color.White);
            txtAnimDelay.Enabled = true;
        }
        private void BtnDraw_Click_1(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            txtAnimDelay.Enabled = false;

            Draw = true;
            UpdateParameters();
            Task.Run(() =>
            {
                int MiddleCanvasX = DrawCanvas.Size.Width / 2;
                Trunk = new FractalLine(new Point(MiddleCanvasX, DrawCanvas.Size.Height), StartHeight, 90, null);

                AddBranch(Trunk, 0);
                DrawCanvas.Invalidate();
            });
        }
        private void OpcionesAvanzadas_CheckedChanged(object sender, EventArgs e)
        {
            TrackShrinkRatio.Enabled = true;
            TrackAngleDelta.Enabled = true;
            TrackSplitDepth.Enabled = true;
            rdbDesactivar.Enabled = true;
            Draw = false;
            papel.Clear(Color.White);
            txtAnimDelay.Enabled = true;
        }

        private void rdbDesactivar_CheckedChanged(object sender, EventArgs e)
        {
            TrackShrinkRatio.Enabled = false;
            TrackAngleDelta.Enabled = false;
            TrackSplitDepth.Enabled = false;
            Draw = false;
            papel.Clear(Color.White);
            rdbDesactivar.Enabled = false;
            txtAnimDelay.Enabled = true;

            TrackAngleDelta.Value=45;
            TrackShrinkRatio.Value = 8;
            TrackSplitDepth.Value= 7;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");
            MessageBox.Show("Arguijo Vazquez Edgar Eduardo - 192310252.", "Copyright Oficial ©: Autor 1");
            MessageBox.Show("Ortiz Godoy Antonio - 192310291.", "Copyright Oficial ©: Autor 2");
        }
    }
}



