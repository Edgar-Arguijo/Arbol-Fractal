
namespace FractalGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDesactivar = new System.Windows.Forms.RadioButton();
            this.OpcionesAvanzadas = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblAnimDelay = new System.Windows.Forms.Label();
            this.txtAnimDelay = new System.Windows.Forms.TextBox();
            this.lblSplitDepth = new System.Windows.Forms.Label();
            this.TrackSplitDepth = new System.Windows.Forms.TrackBar();
            this.lblAngleDelta = new System.Windows.Forms.Label();
            this.TrackAngleDelta = new System.Windows.Forms.TrackBar();
            this.lblShrinkRatio = new System.Windows.Forms.Label();
            this.TrackShrinkRatio = new System.Windows.Forms.TrackBar();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BackColor = System.Drawing.Color.White;
            this.DrawCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawCanvas.Location = new System.Drawing.Point(22, 29);
            this.DrawCanvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(712, 391);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            this.DrawCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCanvas_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbDesactivar);
            this.groupBox1.Controls.Add(this.OpcionesAvanzadas);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.lblAnimDelay);
            this.groupBox1.Controls.Add(this.txtAnimDelay);
            this.groupBox1.Controls.Add(this.lblSplitDepth);
            this.groupBox1.Controls.Add(this.TrackSplitDepth);
            this.groupBox1.Controls.Add(this.lblAngleDelta);
            this.groupBox1.Controls.Add(this.TrackAngleDelta);
            this.groupBox1.Controls.Add(this.lblShrinkRatio);
            this.groupBox1.Controls.Add(this.TrackShrinkRatio);
            this.groupBox1.Controls.Add(this.BtnDraw);
            this.groupBox1.Controls.Add(this.DrawCanvas);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 583);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbol Fractal";
            // 
            // rdbDesactivar
            // 
            this.rdbDesactivar.AutoSize = true;
            this.rdbDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDesactivar.Enabled = false;
            this.rdbDesactivar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbDesactivar.ForeColor = System.Drawing.Color.White;
            this.rdbDesactivar.Location = new System.Drawing.Point(451, 498);
            this.rdbDesactivar.Name = "rdbDesactivar";
            this.rdbDesactivar.Size = new System.Drawing.Size(221, 23);
            this.rdbDesactivar.TabIndex = 22;
            this.rdbDesactivar.TabStop = true;
            this.rdbDesactivar.Text = "Desactivar Opciones Avanzadas";
            this.rdbDesactivar.UseVisualStyleBackColor = true;
            this.rdbDesactivar.CheckedChanged += new System.EventHandler(this.rdbDesactivar_CheckedChanged);
            // 
            // OpcionesAvanzadas
            // 
            this.OpcionesAvanzadas.AutoSize = true;
            this.OpcionesAvanzadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpcionesAvanzadas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpcionesAvanzadas.ForeColor = System.Drawing.Color.White;
            this.OpcionesAvanzadas.Location = new System.Drawing.Point(451, 522);
            this.OpcionesAvanzadas.Name = "OpcionesAvanzadas";
            this.OpcionesAvanzadas.Size = new System.Drawing.Size(201, 23);
            this.OpcionesAvanzadas.TabIndex = 21;
            this.OpcionesAvanzadas.TabStop = true;
            this.OpcionesAvanzadas.Text = "Activar Opciones Avanzadas";
            this.OpcionesAvanzadas.UseVisualStyleBackColor = true;
            this.OpcionesAvanzadas.CheckedChanged += new System.EventHandler(this.OpcionesAvanzadas_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(35, 509);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 30);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "Dejar de Dibujar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblAnimDelay
            // 
            this.lblAnimDelay.AutoSize = true;
            this.lblAnimDelay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnimDelay.ForeColor = System.Drawing.Color.White;
            this.lblAnimDelay.Location = new System.Drawing.Point(580, 423);
            this.lblAnimDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimDelay.Name = "lblAnimDelay";
            this.lblAnimDelay.Size = new System.Drawing.Size(154, 19);
            this.lblAnimDelay.TabIndex = 19;
            this.lblAnimDelay.Text = "Retraso de animación";
            // 
            // txtAnimDelay
            // 
            this.txtAnimDelay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAnimDelay.Location = new System.Drawing.Point(592, 446);
            this.txtAnimDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnimDelay.Name = "txtAnimDelay";
            this.txtAnimDelay.Size = new System.Drawing.Size(130, 26);
            this.txtAnimDelay.TabIndex = 18;
            this.txtAnimDelay.Text = "50";
            // 
            // lblSplitDepth
            // 
            this.lblSplitDepth.AutoSize = true;
            this.lblSplitDepth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSplitDepth.ForeColor = System.Drawing.Color.White;
            this.lblSplitDepth.Location = new System.Drawing.Point(383, 428);
            this.lblSplitDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplitDepth.Name = "lblSplitDepth";
            this.lblSplitDepth.Size = new System.Drawing.Size(145, 19);
            this.lblSplitDepth.TabIndex = 17;
            this.lblSplitDepth.Text = "Profundidad dividida";
            // 
            // TrackSplitDepth
            // 
            this.TrackSplitDepth.Enabled = false;
            this.TrackSplitDepth.Location = new System.Drawing.Point(397, 446);
            this.TrackSplitDepth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackSplitDepth.Maximum = 20;
            this.TrackSplitDepth.Minimum = 3;
            this.TrackSplitDepth.Name = "TrackSplitDepth";
            this.TrackSplitDepth.Size = new System.Drawing.Size(121, 45);
            this.TrackSplitDepth.TabIndex = 16;
            this.TrackSplitDepth.Value = 7;
            // 
            // lblAngleDelta
            // 
            this.lblAngleDelta.AutoSize = true;
            this.lblAngleDelta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAngleDelta.ForeColor = System.Drawing.Color.White;
            this.lblAngleDelta.Location = new System.Drawing.Point(223, 426);
            this.lblAngleDelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngleDelta.Name = "lblAngleDelta";
            this.lblAngleDelta.Size = new System.Drawing.Size(118, 19);
            this.lblAngleDelta.TabIndex = 15;
            this.lblAngleDelta.Text = "Delta del ángulo";
            // 
            // TrackAngleDelta
            // 
            this.TrackAngleDelta.Enabled = false;
            this.TrackAngleDelta.Location = new System.Drawing.Point(228, 446);
            this.TrackAngleDelta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackAngleDelta.Maximum = 85;
            this.TrackAngleDelta.Minimum = 10;
            this.TrackAngleDelta.Name = "TrackAngleDelta";
            this.TrackAngleDelta.Size = new System.Drawing.Size(121, 45);
            this.TrackAngleDelta.TabIndex = 14;
            this.TrackAngleDelta.TickFrequency = 5;
            this.TrackAngleDelta.Value = 45;
            // 
            // lblShrinkRatio
            // 
            this.lblShrinkRatio.AutoSize = true;
            this.lblShrinkRatio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShrinkRatio.ForeColor = System.Drawing.Color.White;
            this.lblShrinkRatio.Location = new System.Drawing.Point(35, 428);
            this.lblShrinkRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShrinkRatio.Name = "lblShrinkRatio";
            this.lblShrinkRatio.Size = new System.Drawing.Size(146, 19);
            this.lblShrinkRatio.TabIndex = 13;
            this.lblShrinkRatio.Text = "Ratio de contracción";
            // 
            // TrackShrinkRatio
            // 
            this.TrackShrinkRatio.Enabled = false;
            this.TrackShrinkRatio.Location = new System.Drawing.Point(50, 446);
            this.TrackShrinkRatio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackShrinkRatio.Name = "TrackShrinkRatio";
            this.TrackShrinkRatio.Size = new System.Drawing.Size(121, 45);
            this.TrackShrinkRatio.TabIndex = 12;
            this.TrackShrinkRatio.Value = 8;
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.Location = new System.Drawing.Point(210, 509);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(189, 30);
            this.BtnDraw.TabIndex = 11;
            this.BtnDraw.Text = "Dibujar Arbol Fractal";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(688, 556);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Autores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(808, 622);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arbol Fractal";
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblAnimDelay;
        private System.Windows.Forms.TextBox txtAnimDelay;
        private System.Windows.Forms.Label lblSplitDepth;
        private System.Windows.Forms.TrackBar TrackSplitDepth;
        private System.Windows.Forms.Label lblAngleDelta;
        private System.Windows.Forms.TrackBar TrackAngleDelta;
        private System.Windows.Forms.Label lblShrinkRatio;
        private System.Windows.Forms.TrackBar TrackShrinkRatio;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.RadioButton OpcionesAvanzadas;
        private System.Windows.Forms.RadioButton rdbDesactivar;
        private System.Windows.Forms.Label label1;
    }
}
