
namespace Gestion_Absences_Stagiaire
{
    partial class Supprimer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSupp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Num_STG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomArab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomArab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupp
            // 
            this.dgvSupp.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvSupp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupp.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupp.ColumnHeadersHeight = 52;
            this.dgvSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_STG,
            this.Nom,
            this.Prenom,
            this.CIN,
            this.NomArab,
            this.PrenomArab,
            this.Genre,
            this.DateNaissance,
            this.Adresse,
            this.Telephone,
            this.Email,
            this.Column1,
            this.Groupe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupp.EnableHeadersVisualStyles = false;
            this.dgvSupp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvSupp.Location = new System.Drawing.Point(354, 110);
            this.dgvSupp.Name = "dgvSupp";
            this.dgvSupp.RowHeadersVisible = false;
            this.dgvSupp.RowHeadersWidth = 51;
            this.dgvSupp.RowTemplate.Height = 24;
            this.dgvSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupp.Size = new System.Drawing.Size(1568, 847);
            this.dgvSupp.TabIndex = 59;
            this.dgvSupp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgvSupp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvSupp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSupp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSupp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSupp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSupp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvSupp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvSupp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSupp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSupp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSupp.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvSupp.ThemeStyle.ReadOnly = false;
            this.dgvSupp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvSupp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSupp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSupp.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSupp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvSupp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Num_STG
            // 
            this.Num_STG.FillWeight = 99.75903F;
            this.Num_STG.HeaderText = "Num Stagiaire";
            this.Num_STG.MinimumWidth = 6;
            this.Num_STG.Name = "Num_STG";
            // 
            // Nom
            // 
            this.Nom.FillWeight = 100.5022F;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.FillWeight = 99.73749F;
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            // 
            // CIN
            // 
            this.CIN.FillWeight = 99.75939F;
            this.CIN.HeaderText = "CIN";
            this.CIN.MinimumWidth = 6;
            this.CIN.Name = "CIN";
            // 
            // NomArab
            // 
            this.NomArab.FillWeight = 100.5025F;
            this.NomArab.HeaderText = "Nom Arab";
            this.NomArab.MinimumWidth = 6;
            this.NomArab.Name = "NomArab";
            // 
            // PrenomArab
            // 
            this.PrenomArab.FillWeight = 99.73779F;
            this.PrenomArab.HeaderText = "Prenom Arab";
            this.PrenomArab.MinimumWidth = 6;
            this.PrenomArab.Name = "PrenomArab";
            // 
            // Genre
            // 
            this.Genre.FillWeight = 99.75967F;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // DateNaissance
            // 
            this.DateNaissance.FillWeight = 100.5028F;
            this.DateNaissance.HeaderText = "Date Naissance";
            this.DateNaissance.MinimumWidth = 6;
            this.DateNaissance.Name = "DateNaissance";
            // 
            // Adresse
            // 
            this.Adresse.FillWeight = 99.73804F;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            // 
            // Telephone
            // 
            this.Telephone.FillWeight = 99.75988F;
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            // 
            // Email
            // 
            this.Email.FillWeight = 100.503F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stagaire En Formation";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Groupe
            // 
            this.Groupe.FillWeight = 99.73822F;
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.MinimumWidth = 6;
            this.Groupe.Name = "Groupe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(173, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 10);
            this.panel3.TabIndex = 14;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BorderRadius = 10;
            this.btnSupprimer.CheckedState.Parent = this.btnSupprimer;
            this.btnSupprimer.CustomImages.Parent = this.btnSupprimer;
            this.btnSupprimer.FillColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnSupprimer.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.HoverState.Parent = this.btnSupprimer;
            this.btnSupprimer.Location = new System.Drawing.Point(32, 513);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ShadowDecoration.Parent = this.btnSupprimer;
            this.btnSupprimer.Size = new System.Drawing.Size(273, 45);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnAbout.Location = new System.Drawing.Point(32, 891);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(273, 45);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(55, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 10);
            this.panel2.TabIndex = 13;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.BorderColor = System.Drawing.Color.Black;
            this.txtNom.BorderRadius = 15;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.Parent = this.txtNom;
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedState.Parent = this.txtNom;
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.HoverState.Parent = this.txtNom;
            this.txtNom.Location = new System.Drawing.Point(815, 27);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "Cin";
            this.txtNom.SelectedText = "";
            this.txtNom.ShadowDecoration.Parent = this.txtNom;
            this.txtNom.Size = new System.Drawing.Size(546, 47);
            this.txtNom.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 973);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Gestion_Absences_Stagiaire.Properties.Resources.Sans_titre;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 973);
            this.Controls.Add(this.dgvSupp);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Supprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_STG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomArab;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomArab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnSupprimer;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbout;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private System.Windows.Forms.Panel panel1;
    }
}