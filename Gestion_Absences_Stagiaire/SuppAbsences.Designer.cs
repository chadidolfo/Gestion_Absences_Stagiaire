
namespace Gestion_Absences_Stagiaire
{
    partial class SuppAbsences
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seanceTableAdapter = new Gestion_Absences_Stagiaire.ISFODataSetTableAdapters.SeanceTableAdapter();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSFODataSet = new Gestion_Absences_Stagiaire.ISFODataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvSupp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpAbsence = new System.Windows.Forms.DateTimePicker();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbJour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSFODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seanceTableAdapter
            // 
            this.seanceTableAdapter.ClearBeforeFill = true;
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
            this.btnSupprimer.Location = new System.Drawing.Point(479, 121);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ShadowDecoration.Parent = this.btnSupprimer;
            this.btnSupprimer.Size = new System.Drawing.Size(237, 45);
            this.btnSupprimer.TabIndex = 35;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataMember = "Seance";
            this.seanceBindingSource.DataSource = this.iSFODataSet;
            // 
            // iSFODataSet
            // 
            this.iSFODataSet.DataSetName = "ISFODataSet";
            this.iSFODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(184, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 10);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(66, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 10);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Gestion_Absences_Stagiaire.Properties.Resources.Sans_titre;
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(59, 915);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(237, 45);
            this.guna2GradientButton1.TabIndex = 33;
            this.guna2GradientButton1.Text = "About";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // dgvSupp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvSupp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupp.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupp.ColumnHeadersHeight = 27;
            this.dgvSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupp.EnableHeadersVisualStyles = false;
            this.dgvSupp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvSupp.Location = new System.Drawing.Point(347, 232);
            this.dgvSupp.Name = "dgvSupp";
            this.dgvSupp.RowHeadersVisible = false;
            this.dgvSupp.RowHeadersWidth = 51;
            this.dgvSupp.RowTemplate.Height = 24;
            this.dgvSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupp.Size = new System.Drawing.Size(1569, 714);
            this.dgvSupp.TabIndex = 36;
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
            this.dgvSupp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSupp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSupp.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvSupp.ThemeStyle.ReadOnly = false;
            this.dgvSupp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvSupp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSupp.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSupp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvSupp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Numero Stagiaire";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prénom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Séance";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jour";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
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
            this.txtNom.Location = new System.Drawing.Point(202, 76);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "Nom";
            this.txtNom.SelectedText = "";
            this.txtNom.ShadowDecoration.Parent = this.txtNom;
            this.txtNom.Size = new System.Drawing.Size(344, 50);
            this.txtNom.TabIndex = 37;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.dtpAbsence);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox2.Location = new System.Drawing.Point(18, 58);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(195, 123);
            this.guna2GroupBox2.TabIndex = 42;
            this.guna2GroupBox2.Text = "Date Absences";
            // 
            // dtpAbsence
            // 
            this.dtpAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbsence.Location = new System.Drawing.Point(17, 63);
            this.dtpAbsence.Name = "dtpAbsence";
            this.dtpAbsence.Size = new System.Drawing.Size(148, 27);
            this.dtpAbsence.TabIndex = 28;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderRadius = 20;
            this.guna2GroupBox5.Controls.Add(this.cmbJour);
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox5.Location = new System.Drawing.Point(229, 58);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.ShadowDecoration.Parent = this.guna2GroupBox5;
            this.guna2GroupBox5.Size = new System.Drawing.Size(225, 123);
            this.guna2GroupBox5.TabIndex = 43;
            this.guna2GroupBox5.Text = "Jour";
            // 
            // cmbJour
            // 
            this.cmbJour.BackColor = System.Drawing.Color.Transparent;
            this.cmbJour.BorderColor = System.Drawing.Color.Black;
            this.cmbJour.BorderRadius = 15;
            this.cmbJour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJour.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbJour.FocusedColor = System.Drawing.Color.Empty;
            this.cmbJour.FocusedState.Parent = this.cmbJour;
            this.cmbJour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbJour.FormattingEnabled = true;
            this.cmbJour.HoverState.Parent = this.cmbJour;
            this.cmbJour.ItemHeight = 30;
            this.cmbJour.ItemsAppearance.Parent = this.cmbJour;
            this.cmbJour.Location = new System.Drawing.Point(20, 54);
            this.cmbJour.Name = "cmbJour";
            this.cmbJour.ShadowDecoration.Parent = this.cmbJour;
            this.cmbJour.Size = new System.Drawing.Size(183, 36);
            this.cmbJour.TabIndex = 24;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 10;
            this.guna2GroupBox4.Controls.Add(this.txtNumero);
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox4.Controls.Add(this.btnSupprimer);
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox5);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox4.Location = new System.Drawing.Point(1123, 12);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(744, 200);
            this.guna2GroupBox4.TabIndex = 44;
            this.guna2GroupBox4.Text = "Supprimer";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderRadius = 15;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.Parent = this.txtNumero;
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.FocusedState.Parent = this.txtNumero;
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.HoverState.Parent = this.txtNumero;
            this.txtNumero.Location = new System.Drawing.Point(479, 59);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = " Numero Stagiaire";
            this.txtNumero.SelectedText = "";
            this.txtNumero.ShadowDecoration.Parent = this.txtNumero;
            this.txtNumero.Size = new System.Drawing.Size(241, 48);
            this.txtNumero.TabIndex = 40;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.txtNom);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.Location = new System.Drawing.Point(347, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(734, 200);
            this.guna2GroupBox1.TabIndex = 45;
            this.guna2GroupBox1.Text = "Supprimer";
            // 
            // SuppAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 973);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.dgvSupp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GradientButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SuppAbsences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppAbsences";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuppAbsences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSFODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ISFODataSetTableAdapters.SeanceTableAdapter seanceTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton btnSupprimer;
        private System.Windows.Forms.BindingSource seanceBindingSource;
        private ISFODataSet iSFODataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSupp;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DateTimePicker dtpAbsence;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJour;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
    }
}