namespace GESTION_KELASI.PL
{
    partial class FRM_ModiferUtilisateur
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
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_NouveauMotdePasse = new System.Windows.Forms.TextBox();
            this.Txt_RepeteNouveauMotdePasse = new System.Windows.Forms.TextBox();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Annuller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_AncienMotdePasse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_Fermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 30);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(340, 3);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(25, 23);
            this.Btn_Fermer.TabIndex = 1;
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 5);
            this.panel2.TabIndex = 0;
            // 
            // Txt_NouveauMotdePasse
            // 
            this.Txt_NouveauMotdePasse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NouveauMotdePasse.Location = new System.Drawing.Point(23, 160);
            this.Txt_NouveauMotdePasse.Multiline = true;
            this.Txt_NouveauMotdePasse.Name = "Txt_NouveauMotdePasse";
            this.Txt_NouveauMotdePasse.Size = new System.Drawing.Size(323, 25);
            this.Txt_NouveauMotdePasse.TabIndex = 1;
            // 
            // Txt_RepeteNouveauMotdePasse
            // 
            this.Txt_RepeteNouveauMotdePasse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RepeteNouveauMotdePasse.Location = new System.Drawing.Point(23, 218);
            this.Txt_RepeteNouveauMotdePasse.Multiline = true;
            this.Txt_RepeteNouveauMotdePasse.Name = "Txt_RepeteNouveauMotdePasse";
            this.Txt_RepeteNouveauMotdePasse.Size = new System.Drawing.Size(323, 25);
            this.Txt_RepeteNouveauMotdePasse.TabIndex = 1;
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Enregistrer.FlatAppearance.BorderSize = 0;
            this.Btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enregistrer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Enregistrer.Location = new System.Drawing.Point(23, 278);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(118, 27);
            this.Btn_Enregistrer.TabIndex = 2;
            this.Btn_Enregistrer.Text = "Valider";
            this.Btn_Enregistrer.UseVisualStyleBackColor = false;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Btn_Annuller
            // 
            this.Btn_Annuller.BackColor = System.Drawing.Color.Red;
            this.Btn_Annuller.FlatAppearance.BorderSize = 0;
            this.Btn_Annuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Annuller.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annuller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Annuller.Location = new System.Drawing.Point(228, 279);
            this.Btn_Annuller.Name = "Btn_Annuller";
            this.Btn_Annuller.Size = new System.Drawing.Size(118, 27);
            this.Btn_Annuller.TabIndex = 3;
            this.Btn_Annuller.Text = "Annuller";
            this.Btn_Annuller.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modifier le mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Répete le nouveau mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nouveau Mot de passe";
            // 
            // Txt_AncienMotdePasse
            // 
            this.Txt_AncienMotdePasse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AncienMotdePasse.Location = new System.Drawing.Point(23, 105);
            this.Txt_AncienMotdePasse.Multiline = true;
            this.Txt_AncienMotdePasse.Name = "Txt_AncienMotdePasse";
            this.Txt_AncienMotdePasse.Size = new System.Drawing.Size(323, 25);
            this.Txt_AncienMotdePasse.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ancien Mot de passe";
            // 
            // FRM_ModiferUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Annuller);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Txt_AncienMotdePasse);
            this.Controls.Add(this.Txt_RepeteNouveauMotdePasse);
            this.Controls.Add(this.Txt_NouveauMotdePasse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ModiferUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_ModiferUtilisateur";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.TextBox Txt_NouveauMotdePasse;
        private System.Windows.Forms.TextBox Txt_RepeteNouveauMotdePasse;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Annuller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_AncienMotdePasse;
        private System.Windows.Forms.Label label5;
    }
}