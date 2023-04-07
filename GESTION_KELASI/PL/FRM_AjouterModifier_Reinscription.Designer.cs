namespace GESTION_KELASI.PL
{
    partial class FRM_AjouterModifier_Reinscription
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
            this.Btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_afficher = new System.Windows.Forms.Label();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxTID_FraisReinscrption = new System.Windows.Forms.TextBox();
            this.TxtID_Reinscription = new System.Windows.Forms.TextBox();
            this.Txt_IDEtudiant = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RB_Nouveau = new System.Windows.Forms.RadioButton();
            this.RB_Ancien = new System.Windows.Forms.RadioButton();
            this.TxtNomEleve = new System.Windows.Forms.TextBox();
            this.TxtPrenomEleve = new System.Windows.Forms.TextBox();
            this.P_Photo = new System.Windows.Forms.PictureBox();
            this.TxtLieuNaissance = new System.Windows.Forms.TextBox();
            this.CbbSexe = new System.Windows.Forms.ComboBox();
            this.TxtNationalite = new System.Windows.Forms.TextBox();
            this.DtmNaissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtFraisnscription = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Cmb_AnneeScolaire = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Cmb_Classe = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.Btn_Annuller = new System.Windows.Forms.Button();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Photo)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 30);
            this.panel1.TabIndex = 0;
            // 
            // Btn_close
            // 
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_close.Location = new System.Drawing.Point(723, 3);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(24, 23);
            this.Btn_close.TabIndex = 1;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 3);
            this.panel2.TabIndex = 0;
            // 
            // Lbl_afficher
            // 
            this.Lbl_afficher.AutoSize = true;
            this.Lbl_afficher.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_afficher.Location = new System.Drawing.Point(233, 44);
            this.Lbl_afficher.Name = "Lbl_afficher";
            this.Lbl_afficher.Size = new System.Drawing.Size(298, 27);
            this.Lbl_afficher.TabIndex = 2;
            this.Lbl_afficher.Text = "FICHER DE LA REINSCRIPTION";
            // 
            // Btn_Select
            // 
            this.Btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.Btn_Select.FlatAppearance.BorderSize = 0;
            this.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Select.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Select.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Select.Location = new System.Drawing.Point(19, 77);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(113, 28);
            this.Btn_Select.TabIndex = 5;
            this.Btn_Select.Text = "Select....";
            this.Btn_Select.UseVisualStyleBackColor = false;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxTID_FraisReinscrption);
            this.groupBox3.Controls.Add(this.TxtID_Reinscription);
            this.groupBox3.Controls.Add(this.Txt_IDEtudiant);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.TxtNomEleve);
            this.groupBox3.Controls.Add(this.TxtPrenomEleve);
            this.groupBox3.Controls.Add(this.P_Photo);
            this.groupBox3.Controls.Add(this.TxtLieuNaissance);
            this.groupBox3.Controls.Add(this.CbbSexe);
            this.groupBox3.Controls.Add(this.TxtNationalite);
            this.groupBox3.Controls.Add(this.DtmNaissance);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 304);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information personnel de l\'Elève";
            // 
            // TxTID_FraisReinscrption
            // 
            this.TxTID_FraisReinscrption.Enabled = false;
            this.TxTID_FraisReinscrption.Location = new System.Drawing.Point(454, 119);
            this.TxTID_FraisReinscrption.Name = "TxTID_FraisReinscrption";
            this.TxTID_FraisReinscrption.Size = new System.Drawing.Size(100, 23);
            this.TxTID_FraisReinscrption.TabIndex = 23;
            // 
            // TxtID_Reinscription
            // 
            this.TxtID_Reinscription.Enabled = false;
            this.TxtID_Reinscription.Location = new System.Drawing.Point(337, 118);
            this.TxtID_Reinscription.Name = "TxtID_Reinscription";
            this.TxtID_Reinscription.Size = new System.Drawing.Size(100, 23);
            this.TxtID_Reinscription.TabIndex = 23;
            // 
            // Txt_IDEtudiant
            // 
            this.Txt_IDEtudiant.Enabled = false;
            this.Txt_IDEtudiant.Location = new System.Drawing.Point(206, 120);
            this.Txt_IDEtudiant.Name = "Txt_IDEtudiant";
            this.Txt_IDEtudiant.Size = new System.Drawing.Size(100, 23);
            this.Txt_IDEtudiant.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RB_Nouveau);
            this.groupBox5.Controls.Add(this.RB_Ancien);
            this.groupBox5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(526, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 92);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Profil de L\'Eleve";
            // 
            // RB_Nouveau
            // 
            this.RB_Nouveau.AutoSize = true;
            this.RB_Nouveau.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Nouveau.Location = new System.Drawing.Point(38, 50);
            this.RB_Nouveau.Name = "RB_Nouveau";
            this.RB_Nouveau.Size = new System.Drawing.Size(76, 22);
            this.RB_Nouveau.TabIndex = 0;
            this.RB_Nouveau.TabStop = true;
            this.RB_Nouveau.Text = "Nouveau";
            this.RB_Nouveau.UseVisualStyleBackColor = true;
            this.RB_Nouveau.CheckedChanged += new System.EventHandler(this.RB_Nouveau_CheckedChanged);
            // 
            // RB_Ancien
            // 
            this.RB_Ancien.AutoSize = true;
            this.RB_Ancien.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Ancien.Location = new System.Drawing.Point(38, 22);
            this.RB_Ancien.Name = "RB_Ancien";
            this.RB_Ancien.Size = new System.Drawing.Size(89, 22);
            this.RB_Ancien.TabIndex = 0;
            this.RB_Ancien.TabStop = true;
            this.RB_Ancien.Text = "Ancien(ne)";
            this.RB_Ancien.UseVisualStyleBackColor = true;
            this.RB_Ancien.CheckedChanged += new System.EventHandler(this.RB_Ancien_CheckedChanged);
            // 
            // TxtNomEleve
            // 
            this.TxtNomEleve.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomEleve.Location = new System.Drawing.Point(120, 197);
            this.TxtNomEleve.Multiline = true;
            this.TxtNomEleve.Name = "TxtNomEleve";
            this.TxtNomEleve.Size = new System.Drawing.Size(264, 20);
            this.TxtNomEleve.TabIndex = 10;
            // 
            // TxtPrenomEleve
            // 
            this.TxtPrenomEleve.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenomEleve.Location = new System.Drawing.Point(467, 199);
            this.TxtPrenomEleve.Multiline = true;
            this.TxtPrenomEleve.Name = "TxtPrenomEleve";
            this.TxtPrenomEleve.Size = new System.Drawing.Size(251, 20);
            this.TxtPrenomEleve.TabIndex = 9;
            // 
            // P_Photo
            // 
            this.P_Photo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.P_Photo.Location = new System.Drawing.Point(12, 29);
            this.P_Photo.Name = "P_Photo";
            this.P_Photo.Size = new System.Drawing.Size(124, 110);
            this.P_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Photo.TabIndex = 19;
            this.P_Photo.TabStop = false;
            // 
            // TxtLieuNaissance
            // 
            this.TxtLieuNaissance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLieuNaissance.Location = new System.Drawing.Point(467, 229);
            this.TxtLieuNaissance.Multiline = true;
            this.TxtLieuNaissance.Name = "TxtLieuNaissance";
            this.TxtLieuNaissance.Size = new System.Drawing.Size(251, 20);
            this.TxtLieuNaissance.TabIndex = 8;
            // 
            // CbbSexe
            // 
            this.CbbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbSexe.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbSexe.FormattingEnabled = true;
            this.CbbSexe.Items.AddRange(new object[] {
            "",
            "Masculin",
            "Feminin"});
            this.CbbSexe.Location = new System.Drawing.Point(119, 260);
            this.CbbSexe.Name = "CbbSexe";
            this.CbbSexe.Size = new System.Drawing.Size(265, 24);
            this.CbbSexe.TabIndex = 18;
            // 
            // TxtNationalite
            // 
            this.TxtNationalite.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNationalite.Location = new System.Drawing.Point(467, 262);
            this.TxtNationalite.Multiline = true;
            this.TxtNationalite.Name = "TxtNationalite";
            this.TxtNationalite.Size = new System.Drawing.Size(251, 20);
            this.TxtNationalite.TabIndex = 7;
            // 
            // DtmNaissance
            // 
            this.DtmNaissance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmNaissance.Location = new System.Drawing.Point(120, 227);
            this.DtmNaissance.Name = "DtmNaissance";
            this.DtmNaissance.Size = new System.Drawing.Size(227, 20);
            this.DtmNaissance.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lieu de naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nationalité :";
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.Location = new System.Drawing.Point(535, 88);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(37, 18);
            this.Lbl_Time.TabIndex = 7;
            this.Lbl_Time.Text = "Time";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TxtFraisnscription);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.Cmb_AnneeScolaire);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.Cmb_Classe);
            this.groupBox6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(18, 413);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(725, 63);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // TxtFraisnscription
            // 
            this.TxtFraisnscription.Location = new System.Drawing.Point(603, 26);
            this.TxtFraisnscription.Multiline = true;
            this.TxtFraisnscription.Name = "TxtFraisnscription";
            this.TxtFraisnscription.Size = new System.Drawing.Size(102, 20);
            this.TxtFraisnscription.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(495, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Frais réinscription :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label19.Location = new System.Drawing.Point(221, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Année Scolaire :";
            // 
            // Cmb_AnneeScolaire
            // 
            this.Cmb_AnneeScolaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AnneeScolaire.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_AnneeScolaire.FormattingEnabled = true;
            this.Cmb_AnneeScolaire.Location = new System.Drawing.Point(310, 23);
            this.Cmb_AnneeScolaire.Name = "Cmb_AnneeScolaire";
            this.Cmb_AnneeScolaire.Size = new System.Drawing.Size(153, 24);
            this.Cmb_AnneeScolaire.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.Location = new System.Drawing.Point(6, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Classe :";
            // 
            // Cmb_Classe
            // 
            this.Cmb_Classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Classe.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Classe.FormattingEnabled = true;
            this.Cmb_Classe.Location = new System.Drawing.Point(55, 21);
            this.Cmb_Classe.Name = "Cmb_Classe";
            this.Cmb_Classe.Size = new System.Drawing.Size(160, 24);
            this.Cmb_Classe.TabIndex = 0;
            this.Cmb_Classe.SelectionChangeCommitted += new System.EventHandler(this.Cmb_Classe_SelectionChangeCommitted);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btn_Valider);
            this.panel4.Controls.Add(this.Btn_Annuller);
            this.panel4.Controls.Add(this.Btn_Enregistrer);
            this.panel4.Location = new System.Drawing.Point(18, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(725, 73);
            this.panel4.TabIndex = 9;
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.BackColor = System.Drawing.Color.Green;
            this.Btn_Valider.FlatAppearance.BorderSize = 0;
            this.Btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Valider.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Valider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Valider.Location = new System.Drawing.Point(19, 22);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(266, 31);
            this.Btn_Valider.TabIndex = 7;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = false;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // Btn_Annuller
            // 
            this.Btn_Annuller.BackColor = System.Drawing.Color.Red;
            this.Btn_Annuller.FlatAppearance.BorderSize = 0;
            this.Btn_Annuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Annuller.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annuller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Annuller.Location = new System.Drawing.Point(439, 22);
            this.Btn_Annuller.Name = "Btn_Annuller";
            this.Btn_Annuller.Size = new System.Drawing.Size(266, 31);
            this.Btn_Annuller.TabIndex = 5;
            this.Btn_Annuller.Text = "Annuller";
            this.Btn_Annuller.UseVisualStyleBackColor = false;
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Enregistrer.FlatAppearance.BorderSize = 0;
            this.Btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enregistrer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enregistrer.Location = new System.Drawing.Point(7, 22);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(266, 31);
            this.Btn_Enregistrer.TabIndex = 6;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = false;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_AjouterModifier_Reinscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(755, 565);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Lbl_afficher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AjouterModifier_Reinscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjouterModifier_Reinscription";
            this.Load += new System.EventHandler(this.FRM_AjouterModifier_Reinscription_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Photo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.RadioButton RB_Nouveau;
        public System.Windows.Forms.RadioButton RB_Ancien;
        public System.Windows.Forms.TextBox TxtNomEleve;
        public System.Windows.Forms.TextBox TxtPrenomEleve;
        public System.Windows.Forms.PictureBox P_Photo;
        public System.Windows.Forms.TextBox TxtLieuNaissance;
        public System.Windows.Forms.ComboBox CbbSexe;
        public System.Windows.Forms.TextBox TxtNationalite;
        public System.Windows.Forms.DateTimePicker DtmNaissance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox TxtFraisnscription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox Cmb_AnneeScolaire;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox Cmb_Classe;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button Btn_Valider;
        public System.Windows.Forms.Button Btn_Annuller;
        public System.Windows.Forms.Button Btn_Enregistrer;
        public System.Windows.Forms.Button Btn_Select;
        public System.Windows.Forms.Label Lbl_afficher;
        public System.Windows.Forms.TextBox Txt_IDEtudiant;
        private System.Windows.Forms.TextBox TxTID_FraisReinscrption;
        private System.Windows.Forms.TextBox TxtID_Reinscription;
        private System.Windows.Forms.Timer timer1;
    }
}