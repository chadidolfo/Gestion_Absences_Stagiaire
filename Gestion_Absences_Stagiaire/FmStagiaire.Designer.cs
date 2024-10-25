
namespace Gestion_Absences_Stagiaire
{
    partial class FmStagiaire
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
            this.btnInformation = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMiseJour = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.panel1.Controls.Add(this.btnInformation);
            this.panel1.Controls.Add(this.btnMiseJour);
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
            this.btnAbout.Location = new System.Drawing.Point(33, 781);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(273, 45);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BorderRadius = 10;
            this.btnInformation.CheckedState.Parent = this.btnInformation;
            this.btnInformation.CustomImages.Parent = this.btnInformation;
            this.btnInformation.FillColor = System.Drawing.Color.DarkGray;
            this.btnInformation.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnInformation.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.Black;
            this.btnInformation.HoverState.Parent = this.btnInformation;
            this.btnInformation.Location = new System.Drawing.Point(33, 675);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.ShadowDecoration.Parent = this.btnInformation;
            this.btnInformation.Size = new System.Drawing.Size(273, 45);
            this.btnInformation.TabIndex = 13;
            this.btnInformation.Text = "Information Stagiaire";
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnMiseJour
            // 
            this.btnMiseJour.BorderRadius = 10;
            this.btnMiseJour.CheckedState.Parent = this.btnMiseJour;
            this.btnMiseJour.CustomImages.Parent = this.btnMiseJour;
            this.btnMiseJour.FillColor = System.Drawing.Color.DarkGray;
            this.btnMiseJour.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnMiseJour.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiseJour.ForeColor = System.Drawing.Color.Black;
            this.btnMiseJour.HoverState.Parent = this.btnMiseJour;
            this.btnMiseJour.Location = new System.Drawing.Point(33, 570);
            this.btnMiseJour.Name = "btnMiseJour";
            this.btnMiseJour.ShadowDecoration.Parent = this.btnMiseJour;
            this.btnMiseJour.Size = new System.Drawing.Size(273, 45);
            this.btnMiseJour.TabIndex = 12;
            this.btnMiseJour.Text = "Mise a Jour";
            this.btnMiseJour.Click += new System.EventHandler(this.btnMiseJour_Click);
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
            // FmStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 969);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FmStagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmStagiaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Guna.UI2.WinForms.Guna2GradientButton btnInformation;
        private Guna.UI2.WinForms.Guna2GradientButton btnMiseJour;
    }
}