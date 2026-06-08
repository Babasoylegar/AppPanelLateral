namespace AppPainelLateral
{
    partial class frmmenuprincipal
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
            this.btnaluno = new System.Windows.Forms.Button();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.btnprofessor = new System.Windows.Forms.Button();
            this.btnnota = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.panelconteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panelprincipal.SuspendLayout();
            this.panelconteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaluno
            // 
            this.btnaluno.BackColor = System.Drawing.Color.Firebrick;
            this.btnaluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaluno.Location = new System.Drawing.Point(3, 110);
            this.btnaluno.Name = "btnaluno";
            this.btnaluno.Size = new System.Drawing.Size(144, 47);
            this.btnaluno.TabIndex = 0;
            this.btnaluno.Text = "Aluno";
            this.btnaluno.UseVisualStyleBackColor = false;
            this.btnaluno.Click += new System.EventHandler(this.btnaluno_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.LightCoral;
            this.panelprincipal.Controls.Add(this.btnsair);
            this.panelprincipal.Controls.Add(this.btnnota);
            this.panelprincipal.Controls.Add(this.btnprofessor);
            this.panelprincipal.Controls.Add(this.pictureBox1);
            this.panelprincipal.Controls.Add(this.btnaluno);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelprincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelprincipal.Location = new System.Drawing.Point(0, 0);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(150, 561);
            this.panelprincipal.TabIndex = 1;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprincipal_Paint);
            // 
            // btnprofessor
            // 
            this.btnprofessor.BackColor = System.Drawing.Color.Firebrick;
            this.btnprofessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprofessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofessor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnprofessor.Location = new System.Drawing.Point(3, 180);
            this.btnprofessor.Name = "btnprofessor";
            this.btnprofessor.Size = new System.Drawing.Size(144, 47);
            this.btnprofessor.TabIndex = 2;
            this.btnprofessor.Text = "Professor";
            this.btnprofessor.UseVisualStyleBackColor = false;
            this.btnprofessor.Click += new System.EventHandler(this.btnprofessor_Click);
            // 
            // btnnota
            // 
            this.btnnota.BackColor = System.Drawing.Color.Firebrick;
            this.btnnota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnota.Location = new System.Drawing.Point(3, 250);
            this.btnnota.Name = "btnnota";
            this.btnnota.Size = new System.Drawing.Size(144, 47);
            this.btnnota.TabIndex = 2;
            this.btnnota.Text = "Nota";
            this.btnnota.UseVisualStyleBackColor = false;
            this.btnnota.Click += new System.EventHandler(this.btnnota_Click_1);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Firebrick;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsair.Location = new System.Drawing.Point(3, 320);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(144, 47);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // panelconteudo
            // 
            this.panelconteudo.Controls.Add(this.lbltitulo);
            this.panelconteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconteudo.Location = new System.Drawing.Point(150, 0);
            this.panelconteudo.Name = "panelconteudo";
            this.panelconteudo.Size = new System.Drawing.Size(834, 561);
            this.panelconteudo.TabIndex = 2;
            this.panelconteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPainelLateral.Properties.Resources.carroiconprincipal;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(322, 74);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(150, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Menu Principal";
            // 
            // frmmenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelconteudo);
            this.Controls.Add(this.panelprincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelprincipal.ResumeLayout(false);
            this.panelconteudo.ResumeLayout(false);
            this.panelconteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaluno;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnnota;
        private System.Windows.Forms.Button btnprofessor;
        private System.Windows.Forms.Panel panelconteudo;
        private System.Windows.Forms.Label lbltitulo;
    }
}

