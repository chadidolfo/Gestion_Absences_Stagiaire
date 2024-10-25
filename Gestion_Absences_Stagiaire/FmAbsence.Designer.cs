
namespace Gestion_Absences_Stagiaire
{
    partial class FmAbsence
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
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAfficher = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGroupe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAfficher);
            this.panel1.Controls.Add(this.btnGroupe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 969);
            this.panel1.TabIndex = 1;
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
            this.btnAbout.Location = new System.Drawing.Point(33, 895);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(273, 45);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(175, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 10);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(57, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 10);
            this.panel2.TabIndex = 15;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BorderRadius = 10;
            this.btnAfficher.CheckedState.Parent = this.btnAfficher;
            this.btnAfficher.CustomImages.Parent = this.btnAfficher;
            this.btnAfficher.FillColor = System.Drawing.Color.DarkGray;
            this.btnAfficher.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnAfficher.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.ForeColor = System.Drawing.Color.Black;
            this.btnAfficher.HoverState.Parent = this.btnAfficher;
            this.btnAfficher.Location = new System.Drawing.Point(33, 681);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.ShadowDecoration.Parent = this.btnAfficher;
            this.btnAfficher.Size = new System.Drawing.Size(273, 45);
            this.btnAfficher.TabIndex = 14;
            this.btnAfficher.Text = "Afficher Absences";
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnGroupe
            // 
            this.btnGroupe.BorderRadius = 10;
            this.btnGroupe.CheckedState.Parent = this.btnGroupe;
            this.btnGroupe.CustomImages.Parent = this.btnGroupe;
            this.btnGroupe.FillColor = System.Drawing.Color.DarkGray;
            this.btnGroupe.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnGroupe.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupe.ForeColor = System.Drawing.Color.Black;
            this.btnGroupe.HoverState.Parent = this.btnGroupe;
            this.btnGroupe.Location = new System.Drawing.Point(33, 570);
            this.btnGroupe.Name = "btnGroupe";
            this.btnGroupe.ShadowDecoration.Parent = this.btnGroupe;
            this.btnGroupe.Size = new System.Drawing.Size(273, 45);
            this.btnGroupe.TabIndex = 12;
            this.btnGroupe.Text = "Abcence Par Groupe";
            this.btnGroupe.Click += new System.EventHandler(this.btnGroupe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Gestion_Absences_Stagiaire.Properties.Resources.Sans_titre;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 969);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FmAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAbsence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAfficher;
        private Guna.UI2.WinForms.Guna2GradientButton btnGroupe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbout;
    }
}