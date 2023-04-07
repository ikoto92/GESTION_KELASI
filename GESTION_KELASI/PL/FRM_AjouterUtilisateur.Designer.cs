namespace GESTION_KELASI.PL
{
    partial class FRM_AjouterUtilisateur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NomPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_MotdePasse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_MotdePasse2 = new System.Windows.Forms.TextBox();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Annuller = new System.Windows.Forms.Button();
            this.Cmbb_Fonction = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LbtErreur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 30);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Close.Location = new System.Drawing.Point(390, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(26, 23);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 470);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 3);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Créer un utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom et Prénom";
            // 
            // Txt_NomPrenom
            // 
            this.Txt_NomPrenom.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomPrenom.Location = new System.Drawing.Point(52, 137);
            this.Txt_NomPrenom.Multiline = true;
            this.Txt_NomPrenom.Name = "Txt_NomPrenom";
            this.Txt_NomPrenom.Size = new System.Drawing.Size(319, 25);
            this.Txt_NomPrenom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fonction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom de l\'utilisateur";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Login.Location = new System.Drawing.Point(52, 245);
            this.Txt_Login.Multiline = true;
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(319, 25);
            this.Txt_Login.TabIndex = 4;
          
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mot de passe";
            // 
            // Txt_MotdePasse
            // 
            this.Txt_MotdePasse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MotdePasse.Location = new System.Drawing.Point(52, 299);
            this.Txt_MotdePasse.Multiline = true;
            this.Txt_MotdePasse.Name = "Txt_MotdePasse";
            this.Txt_MotdePasse.Size = new System.Drawing.Size(319, 25);
            this.Txt_MotdePasse.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Répete le mot de passe";
            // 
            // Txt_MotdePasse2
            // 
            this.Txt_MotdePasse2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MotdePasse2.Location = new System.Drawing.Point(52, 355);
            this.Txt_MotdePasse2.Multiline = true;
            this.Txt_MotdePasse2.Name = "Txt_MotdePasse2";
            this.Txt_MotdePasse2.Size = new System.Drawing.Size(319, 25);
            this.Txt_MotdePasse2.TabIndex = 4;
            this.Txt_MotdePasse2.TextChanged += new System.EventHandler(this.Txt_MotdePasse2_TextChanged);
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Enregistrer.FlatAppearance.BorderSize = 0;
            this.Btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enregistrer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Enregistrer.Location = new System.Drawing.Point(52, 414);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(148, 32);
            this.Btn_Enregistrer.TabIndex = 5;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = false;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Btn_Annuller
            // 
            this.Btn_Annuller.BackColor = System.Drawing.Color.Red;
            this.Btn_Annuller.FlatAppearance.BorderSize = 0;
            this.Btn_Annuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Annuller.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annuller.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Annuller.Location = new System.Drawing.Point(225, 414);
            this.Btn_Annuller.Name = "Btn_Annuller";
            this.Btn_Annuller.Size = new System.Drawing.Size(146, 32);
            this.Btn_Annuller.TabIndex = 6;
            this.Btn_Annuller.Text = "Annuller";
            this.Btn_Annuller.UseVisualStyleBackColor = false;
            // 
            // Cmbb_Fonction
            // 
            this.Cmbb_Fonction.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbb_Fonction.FormattingEnabled = true;
            this.Cmbb_Fonction.Items.AddRange(new object[] {
            "",
            "Directeur",
            "Caissier"});
            this.Cmbb_Fonction.Location = new System.Drawing.Point(52, 191);
            this.Cmbb_Fonction.Name = "Cmbb_Fonction";
            this.Cmbb_Fonction.Size = new System.Drawing.Size(319, 26);
            this.Cmbb_Fonction.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LbtErreur
            // 
            this.LbtErreur.AutoSize = true;
            this.LbtErreur.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbtErreur.ForeColor = System.Drawing.Color.Red;
            this.LbtErreur.Location = new System.Drawing.Point(55, 386);
            this.LbtErreur.Name = "LbtErreur";
            this.LbtErreur.Size = new System.Drawing.Size(39, 16);
            this.LbtErreur.TabIndex = 8;
            this.LbtErreur.Text = "label7";
            // 
            // FRM_AjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(419, 473);
            this.Controls.Add(this.LbtErreur);
            this.Controls.Add(this.Cmbb_Fonction);
            this.Controls.Add(this.Btn_Annuller);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Txt_MotdePasse2);
            this.Controls.Add(this.Txt_MotdePasse);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Txt_NomPrenom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AjouterUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjouterUtilisateur";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NomPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_MotdePasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_MotdePasse2;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Annuller;
        private System.Windows.Forms.ComboBox Cmbb_Fonction;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LbtErreur;
    }
}