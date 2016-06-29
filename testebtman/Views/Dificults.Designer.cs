namespace ProjetoEDA2015
{
    partial class Dificults
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
            this.btnIniciante = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnNinja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciante
            // 
            this.btnIniciante.Location = new System.Drawing.Point(12, 43);
            this.btnIniciante.Name = "btnIniciante";
            this.btnIniciante.Size = new System.Drawing.Size(109, 44);
            this.btnIniciante.TabIndex = 0;
            this.btnIniciante.Text = "Iniciante";
            this.btnIniciante.UseVisualStyleBackColor = true;
            this.btnIniciante.Click += new System.EventHandler(this.btnIniciante_Click);
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(139, 43);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(109, 44);
            this.btnInter.TabIndex = 1;
            this.btnInter.Text = "Intermediário";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // btnNinja
            // 
            this.btnNinja.Location = new System.Drawing.Point(264, 43);
            this.btnNinja.Name = "btnNinja";
            this.btnNinja.Size = new System.Drawing.Size(109, 44);
            this.btnNinja.TabIndex = 2;
            this.btnNinja.Text = "Ninja";
            this.btnNinja.UseVisualStyleBackColor = true;
            this.btnNinja.Click += new System.EventHandler(this.btnNinja_Click);
            // 
            // Dificults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(390, 109);
            this.ControlBox = false;
            this.Controls.Add(this.btnNinja);
            this.Controls.Add(this.btnInter);
            this.Controls.Add(this.btnIniciante);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dificults";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciante;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btnNinja;
    }
}