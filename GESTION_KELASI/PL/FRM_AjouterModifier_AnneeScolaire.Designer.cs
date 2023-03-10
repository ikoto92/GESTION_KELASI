namespace GESTION_KELASI.PL
{
    partial class FRM_AjouterModifier_AnneeScolaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_CloseA = new System.Windows.Forms.Button();
            this.DGV_Annee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAnneeScolaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Afficher = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Annee)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.Btn_CloseA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 30);
            this.panel2.TabIndex = 0;
            // 
            // Btn_CloseA
            // 
            this.Btn_CloseA.FlatAppearance.BorderSize = 0;
            this.Btn_CloseA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CloseA.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_CloseA.Location = new System.Drawing.Point(404, 2);
            this.Btn_CloseA.Name = "Btn_CloseA";
            this.Btn_CloseA.Size = new System.Drawing.Size(22, 23);
            this.Btn_CloseA.TabIndex = 1;
            this.Btn_CloseA.UseVisualStyleBackColor = true;
            this.Btn_CloseA.Click += new System.EventHandler(this.Btn_CloseA_Click);
            // 
            // DGV_Annee
            // 
            this.DGV_Annee.AllowUserToAddRows = false;
            this.DGV_Annee.AllowUserToDeleteRows = false;
            this.DGV_Annee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Annee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Annee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Annee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Annee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Annee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Annee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGV_Annee.EnableHeadersVisualStyles = false;
            this.DGV_Annee.Location = new System.Drawing.Point(11, 228);
            this.DGV_Annee.Name = "DGV_Annee";
            this.DGV_Annee.RowHeadersVisible = false;
            this.DGV_Annee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Annee.Size = new System.Drawing.Size(407, 74);
            this.DGV_Annee.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Année";
            this.Column3.Name = "Column3";
            // 
            // TxtAnneeScolaire
            // 
            this.TxtAnneeScolaire.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnneeScolaire.Location = new System.Drawing.Point(121, 185);
            this.TxtAnneeScolaire.Multiline = true;
            this.TxtAnneeScolaire.Name = "TxtAnneeScolaire";
            this.TxtAnneeScolaire.Size = new System.Drawing.Size(275, 24);
            this.TxtAnneeScolaire.TabIndex = 2;
            this.TxtAnneeScolaire.TextChanged += new System.EventHandler(this.TxtAnneeScolaire_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nouvelle Année :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.Btn_Afficher);
            this.panel3.Controls.Add(this.Btn_Supprimer);
            this.panel3.Controls.Add(this.Btn_Modifier);
            this.panel3.Controls.Add(this.Btn_Valider);
            this.panel3.Location = new System.Drawing.Point(12, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 54);
            this.panel3.TabIndex = 4;
            // 
            // Btn_Afficher
            // 
            this.Btn_Afficher.FlatAppearance.BorderSize = 0;
            this.Btn_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Afficher.Image = global::GESTION_KELASI.Properties.Resources.eye_17943;
            this.Btn_Afficher.Location = new System.Drawing.Point(179, 7);
            this.Btn_Afficher.Name = "Btn_Afficher";
            this.Btn_Afficher.Size = new System.Drawing.Size(37, 38);
            this.Btn_Afficher.TabIndex = 7;
            this.Btn_Afficher.UseVisualStyleBackColor = true;
            this.Btn_Afficher.Click += new System.EventHandler(this.Btn_Afficher_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.FlatAppearance.BorderSize = 0;
            this.Btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Supprimer.Image = global::GESTION_KELASI.Properties.Resources.recyclebinfilled_recycling_full_garbage_1993;
            this.Btn_Supprimer.Location = new System.Drawing.Point(120, 7);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(37, 38);
            this.Btn_Supprimer.TabIndex = 7;
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.FlatAppearance.BorderSize = 0;
            this.Btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modifier.Image = global::GESTION_KELASI.Properties.Resources.power_reset_1847;
            this.Btn_Modifier.Location = new System.Drawing.Point(60, 7);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(37, 38);
            this.Btn_Modifier.TabIndex = 6;
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.FlatAppearance.BorderSize = 0;
            this.Btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Valider.Image = global::GESTION_KELASI.Properties.Resources.saveall_1204;
            this.Btn_Valider.Location = new System.Drawing.Point(5, 7);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(37, 38);
            this.Btn_Valider.TabIndex = 6;
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "CREATION D\'UNE NOUVELLE ANNEE SCOLAIRE";
            // 
            // FRM_AjouterModifier_AnneeScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(429, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAnneeScolaire);
            this.Controls.Add(this.DGV_Annee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AjouterModifier_AnneeScolaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjouterModifier_AnneeScolaire";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Annee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_CloseA;
        private System.Windows.Forms.TextBox TxtAnneeScolaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView DGV_Annee;
        private System.Windows.Forms.Button Btn_Afficher;
    }
}