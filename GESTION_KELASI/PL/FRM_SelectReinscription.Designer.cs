namespace GESTION_KELASI.PL
{
    partial class FRM_SelectReinscription
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_close = new System.Windows.Forms.Button();
            this.DTGV_SELECTReinscription = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_AnneeScolaire = new System.Windows.Forms.ComboBox();
            this.Cmb_Classe = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Afficher = new System.Windows.Forms.Button();
            this.TxtRecherche = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Btn_Photo = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_SELECTReinscription)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 2;
            // 
            // Btn_close
            // 
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_close.Location = new System.Drawing.Point(773, 2);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(24, 23);
            this.Btn_close.TabIndex = 1;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // DTGV_SELECTReinscription
            // 
            this.DTGV_SELECTReinscription.AllowUserToAddRows = false;
            this.DTGV_SELECTReinscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DTGV_SELECTReinscription.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DTGV_SELECTReinscription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGV_SELECTReinscription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGV_SELECTReinscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTGV_SELECTReinscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column7});
            this.DTGV_SELECTReinscription.EnableHeadersVisualStyles = false;
            this.DTGV_SELECTReinscription.Location = new System.Drawing.Point(5, 216);
            this.DTGV_SELECTReinscription.Name = "DTGV_SELECTReinscription";
            this.DTGV_SELECTReinscription.RowHeadersVisible = false;
            this.DTGV_SELECTReinscription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DTGV_SELECTReinscription.Size = new System.Drawing.Size(791, 226);
            this.DTGV_SELECTReinscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Année scolaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Classe :";
            // 
            // Cmb_AnneeScolaire
            // 
            this.Cmb_AnneeScolaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AnneeScolaire.FormattingEnabled = true;
            this.Cmb_AnneeScolaire.Location = new System.Drawing.Point(412, 78);
            this.Cmb_AnneeScolaire.Name = "Cmb_AnneeScolaire";
            this.Cmb_AnneeScolaire.Size = new System.Drawing.Size(231, 21);
            this.Cmb_AnneeScolaire.TabIndex = 23;
            // 
            // Cmb_Classe
            // 
            this.Cmb_Classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Classe.FormattingEnabled = true;
            this.Cmb_Classe.Location = new System.Drawing.Point(67, 80);
            this.Cmb_Classe.Name = "Cmb_Classe";
            this.Cmb_Classe.Size = new System.Drawing.Size(231, 21);
            this.Cmb_Classe.TabIndex = 24;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(800, 2);
            this.flowLayoutPanel3.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 2);
            this.panel3.TabIndex = 27;
            // 
            // Btn_Afficher
            // 
            this.Btn_Afficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Afficher.FlatAppearance.BorderSize = 0;
            this.Btn_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Afficher.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Afficher.ForeColor = System.Drawing.Color.White;
            this.Btn_Afficher.Location = new System.Drawing.Point(671, 77);
            this.Btn_Afficher.Name = "Btn_Afficher";
            this.Btn_Afficher.Size = new System.Drawing.Size(117, 22);
            this.Btn_Afficher.TabIndex = 29;
            this.Btn_Afficher.Text = "Afficher";
            this.Btn_Afficher.UseVisualStyleBackColor = false;
            this.Btn_Afficher.Click += new System.EventHandler(this.Btn_Afficher_Click);
            // 
            // TxtRecherche
            // 
            this.TxtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRecherche.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecherche.ForeColor = System.Drawing.Color.Black;
            this.TxtRecherche.Location = new System.Drawing.Point(207, 155);
            this.TxtRecherche.Multiline = true;
            this.TxtRecherche.Name = "TxtRecherche";
            this.TxtRecherche.Size = new System.Drawing.Size(376, 30);
            this.TxtRecherche.TabIndex = 30;
            this.TxtRecherche.Text = "RECHERCHE";
            this.TxtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);
            this.TxtRecherche.Enter += new System.EventHandler(this.TxtRecherche_Enter);
            this.TxtRecherche.Leave += new System.EventHandler(this.TxtRecherche_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(207, 187);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 2);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.Btn_Select);
            this.panel4.Controls.Add(this.Btn_Photo);
            this.panel4.Location = new System.Drawing.Point(5, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 54);
            this.panel4.TabIndex = 31;
            // 
            // Btn_Select
            // 
            this.Btn_Select.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Select.FlatAppearance.BorderSize = 0;
            this.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Select.Image = global::GESTION_KELASI.Properties.Resources.check;
            this.Btn_Select.Location = new System.Drawing.Point(71, 7);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(37, 38);
            this.Btn_Select.TabIndex = 10;
            this.Btn_Select.UseVisualStyleBackColor = false;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Btn_Photo
            // 
            this.Btn_Photo.FlatAppearance.BorderSize = 0;
            this.Btn_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Photo.Image = global::GESTION_KELASI.Properties.Resources.Imagenes_Alternativa_25573;
            this.Btn_Photo.Location = new System.Drawing.Point(18, 11);
            this.Btn_Photo.Name = "Btn_Photo";
            this.Btn_Photo.Size = new System.Drawing.Size(33, 32);
            this.Btn_Photo.TabIndex = 8;
            this.Btn_Photo.UseVisualStyleBackColor = true;
            this.Btn_Photo.Click += new System.EventHandler(this.Btn_Photo_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SELECT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID_Etudiant";
            this.Column2.Name = "Column2";
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            this.Column3.Width = 57;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prénom";
            this.Column4.Name = "Column4";
            this.Column4.Width = 74;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date de naissance";
            this.Column5.Name = "Column5";
            this.Column5.Width = 137;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lieu de naissance";
            this.Column6.Name = "Column6";
            this.Column6.Width = 135;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Sexe";
            this.Column16.Name = "Column16";
            this.Column16.Width = 59;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Nationalité";
            this.Column17.Name = "Column17";
            this.Column17.Width = 95;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Adresse";
            this.Column18.Name = "Column18";
            this.Column18.Width = 77;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ID_Classe";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            this.Column11.Width = 87;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Classe";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            this.Column12.Width = 68;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ID_Annee";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            this.Column13.Width = 86;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Année Accadémique";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            this.Column14.Width = 147;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Profil";
            this.Column7.Name = "Column7";
            this.Column7.Width = 61;
            // 
            // FRM_SelectReinscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TxtRecherche);
            this.Controls.Add(this.Btn_Afficher);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_AnneeScolaire);
            this.Controls.Add(this.Cmb_Classe);
            this.Controls.Add(this.DTGV_SELECTReinscription);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SelectReinscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_SelectReinscription";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_SELECTReinscription)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DTGV_SELECTReinscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_AnneeScolaire;
        private System.Windows.Forms.ComboBox Cmb_Classe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Afficher;
        private System.Windows.Forms.TextBox TxtRecherche;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_Photo;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}