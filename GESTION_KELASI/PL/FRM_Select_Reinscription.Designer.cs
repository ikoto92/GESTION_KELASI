namespace GESTION_KELASI.PL
{
    partial class FRM_Select_Reinscription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DTG_SelectReinscription = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_AnneeScolaire = new System.Windows.Forms.ComboBox();
            this.Cmb_Classe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Afficher = new System.Windows.Forms.Button();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_SelectReinscription)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.Btn_Fermer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 30);
            this.panel3.TabIndex = 1;
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(772, 3);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(24, 23);
            this.Btn_Fermer.TabIndex = 1;
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 2;
            // 
            // DTG_SelectReinscription
            // 
            this.DTG_SelectReinscription.AllowUserToAddRows = false;
            this.DTG_SelectReinscription.AllowUserToDeleteRows = false;
            this.DTG_SelectReinscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DTG_SelectReinscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_SelectReinscription.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DTG_SelectReinscription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_SelectReinscription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTG_SelectReinscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTG_SelectReinscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column17,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DTG_SelectReinscription.EnableHeadersVisualStyles = false;
            this.DTG_SelectReinscription.Location = new System.Drawing.Point(7, 170);
            this.DTG_SelectReinscription.Name = "DTG_SelectReinscription";
            this.DTG_SelectReinscription.RowHeadersVisible = false;
            this.DTG_SelectReinscription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DTG_SelectReinscription.Size = new System.Drawing.Size(786, 194);
            this.DTG_SelectReinscription.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 72.0224F;
            this.Column1.HeaderText = "SELECT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 105.2586F;
            this.Column2.HeaderText = "ID_Etudiant";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 94.56898F;
            this.Column3.HeaderText = "Nom Eleve";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 72;
            // 
            // Column17
            // 
            this.Column17.FillWeight = 140.1731F;
            this.Column17.HeaderText = "Prénom Eleve";
            this.Column17.Name = "Column17";
            this.Column17.Width = 109;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 161.3134F;
            this.Column4.HeaderText = "Date de naissance";
            this.Column4.Name = "Column4";
            this.Column4.Width = 132;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 128.9615F;
            this.Column5.HeaderText = "Lieu naissance";
            this.Column5.Name = "Column5";
            this.Column5.Width = 113;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 63.00502F;
            this.Column6.HeaderText = "Sexe";
            this.Column6.Name = "Column6";
            this.Column6.Width = 58;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 101.9014F;
            this.Column7.HeaderText = "Nationalité";
            this.Column7.Name = "Column7";
            this.Column7.Width = 94;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 78.80476F;
            this.Column8.HeaderText = "Adresse";
            this.Column8.Name = "Column8";
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID_Classe";
            this.Column9.Name = "Column9";
            this.Column9.Width = 83;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Classe";
            this.Column10.Name = "Column10";
            this.Column10.Width = 65;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ID_Annee";
            this.Column11.Name = "Column11";
            this.Column11.Width = 85;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Année Accademique";
            this.Column12.Name = "Column12";
            this.Column12.Width = 145;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 2);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Année scolaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Classe :";
            // 
            // Cmb_AnneeScolaire
            // 
            this.Cmb_AnneeScolaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AnneeScolaire.FormattingEnabled = true;
            this.Cmb_AnneeScolaire.Location = new System.Drawing.Point(497, 61);
            this.Cmb_AnneeScolaire.Name = "Cmb_AnneeScolaire";
            this.Cmb_AnneeScolaire.Size = new System.Drawing.Size(231, 21);
            this.Cmb_AnneeScolaire.TabIndex = 17;
            // 
            // Cmb_Classe
            // 
            this.Cmb_Classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Classe.FormattingEnabled = true;
            this.Cmb_Classe.Location = new System.Drawing.Point(130, 60);
            this.Cmb_Classe.Name = "Cmb_Classe";
            this.Cmb_Classe.Size = new System.Drawing.Size(231, 21);
            this.Cmb_Classe.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Afficher);
            this.groupBox1.Controls.Add(this.Btn_Select);
            this.groupBox1.Location = new System.Drawing.Point(697, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 64);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Afficher
            // 
            this.Btn_Afficher.FlatAppearance.BorderSize = 0;
            this.Btn_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Afficher.Image = global::GESTION_KELASI.Properties.Resources.eye_17943;
            this.Btn_Afficher.Location = new System.Drawing.Point(47, 18);
            this.Btn_Afficher.Name = "Btn_Afficher";
            this.Btn_Afficher.Size = new System.Drawing.Size(33, 32);
            this.Btn_Afficher.TabIndex = 12;
            this.Btn_Afficher.UseVisualStyleBackColor = true;
            this.Btn_Afficher.Click += new System.EventHandler(this.Btn_Afficher_Click);
            // 
            // Btn_Select
            // 
            this.Btn_Select.FlatAppearance.BorderSize = 0;
            this.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Select.Image = global::GESTION_KELASI.Properties.Resources.check;
            this.Btn_Select.Location = new System.Drawing.Point(6, 15);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(35, 37);
            this.Btn_Select.TabIndex = 11;
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 25);
            this.textBox1.TabIndex = 22;
            // 
            // FRM_Select_Reinscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_AnneeScolaire);
            this.Controls.Add(this.Cmb_Classe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DTG_SelectReinscription);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Select_Reinscription";
            this.Text = "FRM_Select_Reinscription";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_SelectReinscription)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView DTG_SelectReinscription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_AnneeScolaire;
        private System.Windows.Forms.ComboBox Cmb_Classe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Afficher;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}