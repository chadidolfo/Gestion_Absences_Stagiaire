
namespace Gestion_Absences_Stagiaire
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbsences = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStagiaire = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnAbsences);
            this.panel1.Controls.Add(this.btnStagiaire);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 969);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(167, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 10);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(49, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 10);
            this.panel2.TabIndex = 11;
            // 
            // btnAbout
            // 
            this.btnAbout.BorderRadius = 10;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.CustomImages.Parent = this.btnAbout;
            this.btnAbout.FillColor = System.Drawing.Color.DarkGray;
            this.btnAbout.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnAbout.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Location = new System.Drawing.Point(27, 803);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(273, 45);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BorderRadius = 10;
            this.btnAbsences.CheckedState.Parent = this.btnAbsences;
            this.btnAbsences.CustomImages.Parent = this.btnAbsences;
            this.btnAbsences.FillColor = System.Drawing.Color.DarkGray;
            this.btnAbsences.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnAbsences.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.Color.Black;
            this.btnAbsences.HoverState.Parent = this.btnAbsences;
            this.btnAbsences.Location = new System.Drawing.Point(27, 697);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.ShadowDecoration.Parent = this.btnAbsences;
            this.btnAbsences.Size = new System.Drawing.Size(273, 45);
            this.btnAbsences.TabIndex = 9;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnStagiaire
            // 
            this.btnStagiaire.BorderRadius = 10;
            this.btnStagiaire.CheckedState.Parent = this.btnStagiaire;
            this.btnStagiaire.CustomImages.Parent = this.btnStagiaire;
            this.btnStagiaire.FillColor = System.Drawing.Color.DarkGray;
            this.btnStagiaire.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnStagiaire.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStagiaire.ForeColor = System.Drawing.Color.Black;
            this.btnStagiaire.HoverState.Parent = this.btnStagiaire;
            this.btnStagiaire.Location = new System.Drawing.Point(27, 592);
            this.btnStagiaire.Name = "btnStagiaire";
            this.btnStagiaire.ShadowDecoration.Parent = this.btnStagiaire;
            this.btnStagiaire.Size = new System.Drawing.Size(273, 45);
            this.btnStagiaire.TabIndex = 8;
            this.btnStagiaire.Text = "Stagiaires";
            this.btnStagiaire.Click += new System.EventHandler(this.btnStagiaire_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Gestion_Absences_Stagiaire.Properties.Resources.Sans_titre;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 969);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbout;
        public Guna.UI2.WinForms.Guna2GradientButton btnAbsences;
        public Guna.UI2.WinForms.Guna2GradientButton btnStagiaire;
    }
}