namespace GESTION_KELASI.PL
{
    partial class FRM_MENU_Principal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_accueil = new System.Windows.Forms.ToolStripMenuItem();
            this.réferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_créerUneNouvelleAnnée = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_créerUneNouvelleClasse = new System.Windows.Forms.ToolStripMenuItem();
            this.etudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_inscription = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_réinscription = new System.Windows.Forms.ToolStripMenuItem();
            this.comptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payementDesFraisScolaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_créationDunNouveauUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PL_Afficher = new System.Windows.Forms.Panel();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PL_Afficher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_Fermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 30);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 558);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1288, 5);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(232)))));
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_accueil,
            this.réferenceToolStripMenuItem,
            this.etudeToolStripMenuItem,
            this.comptabilitéToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_accueil
            // 
            this.TSM_accueil.Name = "TSM_accueil";
            this.TSM_accueil.Size = new System.Drawing.Size(61, 22);
            this.TSM_accueil.Text = "Accueil";
            this.TSM_accueil.Click += new System.EventHandler(this.TSM_accueil_Click);
            // 
            // réferenceToolStripMenuItem
            // 
            this.réferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_créerUneNouvelleAnnée,
            this.TSM_créerUneNouvelleClasse});
            this.réferenceToolStripMenuItem.Name = "réferenceToolStripMenuItem";
            this.réferenceToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.réferenceToolStripMenuItem.Text = "Réference";
            // 
            // TSM_créerUneNouvelleAnnée
            // 
            this.TSM_créerUneNouvelleAnnée.Name = "TSM_créerUneNouvelleAnnée";
            this.TSM_créerUneNouvelleAnnée.Size = new System.Drawing.Size(224, 22);
            this.TSM_créerUneNouvelleAnnée.Text = "Créer une nouvelle année";
            this.TSM_créerUneNouvelleAnnée.Click += new System.EventHandler(this.TSM_créerUneNouvelleAnnée_Click);
            // 
            // TSM_créerUneNouvelleClasse
            // 
            this.TSM_créerUneNouvelleClasse.Name = "TSM_créerUneNouvelleClasse";
            this.TSM_créerUneNouvelleClasse.Size = new System.Drawing.Size(224, 22);
            this.TSM_créerUneNouvelleClasse.Text = "Créer une nouvelle classe";
            this.TSM_créerUneNouvelleClasse.Click += new System.EventHandler(this.TSM_créerUneNouvelleClasse_Click);
            // 
            // etudeToolStripMenuItem
            // 
            this.etudeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_inscription,
            this.TSM_réinscription});
            this.etudeToolStripMenuItem.Name = "etudeToolStripMenuItem";
            this.etudeToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.etudeToolStripMenuItem.Text = "Etude";
            // 
            // TSM_inscription
            // 
            this.TSM_inscription.Name = "TSM_inscription";
            this.TSM_inscription.Size = new System.Drawing.Size(153, 22);
            this.TSM_inscription.Text = "Inscription";
            this.TSM_inscription.Click += new System.EventHandler(this.TSM_inscription_Click);
            // 
            // TSM_réinscription
            // 
            this.TSM_réinscription.Name = "TSM_réinscription";
            this.TSM_réinscription.Size = new System.Drawing.Size(153, 22);
            this.TSM_réinscription.Text = "Réinscription";
            this.TSM_réinscription.Click += new System.EventHandler(this.TSM_réinscription_Click);
            // 
            // comptabilitéToolStripMenuItem
            // 
            this.comptabilitéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payementDesFraisScolaireToolStripMenuItem,
            this.financeToolStripMenuItem});
            this.comptabilitéToolStripMenuItem.Name = "comptabilitéToolStripMenuItem";
            this.comptabilitéToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.comptabilitéToolStripMenuItem.Text = "Comptabilité";
            // 
            // payementDesFraisScolaireToolStripMenuItem
            // 
            this.payementDesFraisScolaireToolStripMenuItem.Name = "payementDesFraisScolaireToolStripMenuItem";
            this.payementDesFraisScolaireToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.payementDesFraisScolaireToolStripMenuItem.Text = "Payement des frais scolaire";
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_créationDunNouveauUtilisateur,
            this.modifierLeMotDePasseToolStripMenuItem,
            this.supprimerLutilisateurToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // TSM_créationDunNouveauUtilisateur
            // 
            this.TSM_créationDunNouveauUtilisateur.Name = "TSM_créationDunNouveauUtilisateur";
            this.TSM_créationDunNouveauUtilisateur.Size = new System.Drawing.Size(270, 22);
            this.TSM_créationDunNouveauUtilisateur.Text = "Création d\'un nouveau utilisateur";
            this.TSM_créationDunNouveauUtilisateur.Click += new System.EventHandler(this.TSM_créationDunNouveauUtilisateur_Click);
            // 
            // modifierLeMotDePasseToolStripMenuItem
            // 
            this.modifierLeMotDePasseToolStripMenuItem.Name = "modifierLeMotDePasseToolStripMenuItem";
            this.modifierLeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.modifierLeMotDePasseToolStripMenuItem.Text = "Modifier le mot de passe";
            this.modifierLeMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.modifierLeMotDePasseToolStripMenuItem_Click);
            // 
            // supprimerLutilisateurToolStripMenuItem
            // 
            this.supprimerLutilisateurToolStripMenuItem.Name = "supprimerLutilisateurToolStripMenuItem";
            this.supprimerLutilisateurToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.supprimerLutilisateurToolStripMenuItem.Text = "Supprimer l\'utilisateur";
            // 
            // PL_Afficher
            // 
            this.PL_Afficher.Controls.Add(this.label2);
            this.PL_Afficher.Controls.Add(this.label1);
            this.PL_Afficher.Location = new System.Drawing.Point(9, 61);
            this.PL_Afficher.Name = "PL_Afficher";
            this.PL_Afficher.Size = new System.Drawing.Size(1270, 490);
            this.PL_Afficher.TabIndex = 3;
            this.PL_Afficher.Paint += new System.Windows.Forms.PaintEventHandler(this.PL_Afficher_Paint);
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(1254, 3);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(28, 23);
            this.Btn_Fermer.TabIndex = 0;
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(498, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "KELASI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(191, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENU DANS L\'APPLICATION";
            // 
            // FRM_MENU_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1288, 563);
            this.Controls.Add(this.PL_Afficher);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MENU_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_MENU_Principal";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PL_Afficher.ResumeLayout(false);
            this.PL_Afficher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem réferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM_créerUneNouvelleAnnée;
        private System.Windows.Forms.ToolStripMenuItem TSM_créerUneNouvelleClasse;
        private System.Windows.Forms.ToolStripMenuItem TSM_inscription;
        private System.Windows.Forms.ToolStripMenuItem TSM_réinscription;
        private System.Windows.Forms.ToolStripMenuItem payementDesFraisScolaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM_créationDunNouveauUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem modifierLeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLutilisateurToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Fermer;
        public System.Windows.Forms.Panel PL_Afficher;
        private System.Windows.Forms.ToolStripMenuItem TSM_accueil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}