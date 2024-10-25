
namespace Gestion_Absences_Stagiaire
{
    partial class Pin
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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGroupe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(51, 35);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '*';
            this.guna2TextBox1.PlaceholderText = "Mot de Passe";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(359, 44);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.btnGroupe.Location = new System.Drawing.Point(89, 132);
            this.btnGroupe.Name = "btnGroupe";
            this.btnGroupe.ShadowDecoration.Parent = this.btnGroupe;
            this.btnGroupe.Size = new System.Drawing.Size(273, 45);
            this.btnGroupe.TabIndex = 13;
            this.btnGroupe.Text = "Valider";
            this.btnGroupe.Click += new System.EventHandler(this.btnGroupe_Click);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 229);
            this.Controls.Add(this.btnGroupe);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Pin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGroupe;
    }
}