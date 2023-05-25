
namespace Practica_Hilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlesHilos = new System.Windows.Forms.Panel();
            this.star = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.auto2 = new System.Windows.Forms.PictureBox();
            this.auto3 = new System.Windows.Forms.PictureBox();
            this.auto4 = new System.Windows.Forms.PictureBox();
            this.auto5 = new System.Windows.Forms.PictureBox();
            this.controlesHilos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto5)).BeginInit();
            this.SuspendLayout();
            // 
            // controlesHilos
            // 
            this.controlesHilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.controlesHilos.Controls.Add(this.exit);
            this.controlesHilos.Controls.Add(this.reset);
            this.controlesHilos.Controls.Add(this.pause);
            this.controlesHilos.Controls.Add(this.star);
            this.controlesHilos.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlesHilos.Location = new System.Drawing.Point(0, 0);
            this.controlesHilos.Name = "controlesHilos";
            this.controlesHilos.Size = new System.Drawing.Size(905, 100);
            this.controlesHilos.TabIndex = 0;
            // 
            // star
            // 
            this.star.BackColor = System.Drawing.Color.Indigo;
            this.star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star.ForeColor = System.Drawing.SystemColors.Control;
            this.star.Location = new System.Drawing.Point(90, 26);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(102, 45);
            this.star.TabIndex = 0;
            this.star.Text = "START";
            this.star.UseVisualStyleBackColor = false;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Indigo;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.SystemColors.Control;
            this.pause.Location = new System.Drawing.Point(283, 26);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(102, 45);
            this.pause.TabIndex = 1;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Indigo;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.Control;
            this.reset.Location = new System.Drawing.Point(477, 26);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(102, 45);
            this.reset.TabIndex = 2;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(681, 26);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 45);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.auto1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 92);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.auto2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 92);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.auto3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 92);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.auto5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 92);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.auto4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 376);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 92);
            this.panel5.TabIndex = 4;
            // 
            // auto1
            // 
            this.auto1.Location = new System.Drawing.Point(0, 19);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(100, 50);
            this.auto1.TabIndex = 0;
            this.auto1.TabStop = false;
            // 
            // auto2
            // 
            this.auto2.Location = new System.Drawing.Point(0, 20);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(100, 50);
            this.auto2.TabIndex = 1;
            this.auto2.TabStop = false;
            // 
            // auto3
            // 
            this.auto3.Location = new System.Drawing.Point(0, 23);
            this.auto3.Name = "auto3";
            this.auto3.Size = new System.Drawing.Size(100, 50);
            this.auto3.TabIndex = 2;
            this.auto3.TabStop = false;
            // 
            // auto4
            // 
            this.auto4.Location = new System.Drawing.Point(0, 23);
            this.auto4.Name = "auto4";
            this.auto4.Size = new System.Drawing.Size(100, 50);
            this.auto4.TabIndex = 3;
            this.auto4.TabStop = false;
            // 
            // auto5
            // 
            this.auto5.Location = new System.Drawing.Point(0, 30);
            this.auto5.Name = "auto5";
            this.auto5.Size = new System.Drawing.Size(100, 50);
            this.auto5.TabIndex = 4;
            this.auto5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(905, 559);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlesHilos);
            this.Name = "Form1";
            this.Text = "Candy Rush";
            this.controlesHilos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlesHilos;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.PictureBox auto2;
        private System.Windows.Forms.PictureBox auto3;
        private System.Windows.Forms.PictureBox auto5;
        private System.Windows.Forms.PictureBox auto4;
    }
}

