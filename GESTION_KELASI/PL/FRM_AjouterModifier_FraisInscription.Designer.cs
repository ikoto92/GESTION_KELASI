namespace GESTION_KELASI.PL
{
    partial class FRM_AjouterModifier_FraisInscription
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FraisInscription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_Fermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "CREATION FRAIS DES D\'INSCRIPTION";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.Btn_Supprimer);
            this.panel3.Controls.Add(this.Btn_Modifier);
            this.panel3.Controls.Add(this.Btn_Valider);
            this.panel3.Location = new System.Drawing.Point(11, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 54);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frais d\'inscription :";
            // 
            // Txt_FraisInscription
            // 
            this.Txt_FraisInscription.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FraisInscription.Location = new System.Drawing.Point(145, 201);
            this.Txt_FraisInscription.Multiline = true;
            this.Txt_FraisInscription.Name = "Txt_FraisInscription";
            this.Txt_FraisInscription.Size = new System.Drawing.Size(239, 24);
            this.Txt_FraisInscription.TabIndex = 7;
            this.Txt_FraisInscription.TextChanged += new System.EventHandler(this.Txt_FraisInscription_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 132);
            this.dataGridView1.TabIndex = 6;
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.FlatAppearance.BorderSize = 0;
            this.Btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Supprimer.Image = global::GESTION_KELASI.Properties.Resources.recyclebinfilled_recycling_full_garbage_1993;
            this.Btn_Supprimer.Location = new System.Drawing.Point(111, 7);
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
            this.Btn_Modifier.Location = new System.Drawing.Point(59, 7);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(37, 38);
            this.Btn_Modifier.TabIndex = 6;
            this.Btn_Modifier.UseVisualStyleBackColor = true;
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
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(767, 4);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(28, 23);
            this.Btn_Fermer.TabIndex = 1;
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // FRM_AjouterModifier_FraisInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_FraisInscription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AjouterModifier_FraisInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjouterModifier_FraisInscription";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FraisInscription;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}