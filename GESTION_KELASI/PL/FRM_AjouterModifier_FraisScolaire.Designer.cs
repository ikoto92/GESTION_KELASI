﻿namespace GESTION_KELASI.PL
{
    partial class FRM_AjouterModifier_FraisScolaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
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
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(771, 4);
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
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREER UNE NOUVELLE FRAIS D\'INSCRIPTION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 132);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.Btn_Supprimer);
            this.panel3.Controls.Add(this.Btn_Modifier);
            this.panel3.Controls.Add(this.Btn_Enregistrer);
            this.panel3.Location = new System.Drawing.Point(10, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 54);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frais d\'inscription :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.FlatAppearance.BorderSize = 0;
            this.Btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enregistrer.Image = global::GESTION_KELASI.Properties.Resources.saveall_1204;
            this.Btn_Enregistrer.Location = new System.Drawing.Point(12, 9);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(37, 38);
            this.Btn_Enregistrer.TabIndex = 6;
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.FlatAppearance.BorderSize = 0;
            this.Btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modifier.Image = global::GESTION_KELASI.Properties.Resources.power_reset_1847;
            this.Btn_Modifier.Location = new System.Drawing.Point(59, 9);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(37, 38);
            this.Btn_Modifier.TabIndex = 6;
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.FlatAppearance.BorderSize = 0;
            this.Btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Supprimer.Image = global::GESTION_KELASI.Properties.Resources.recyclebinfilled_recycling_full_garbage_1993;
            this.Btn_Supprimer.Location = new System.Drawing.Point(115, 10);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(37, 38);
            this.Btn_Supprimer.TabIndex = 6;
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // FRM_AjouterModifier_FraisScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AjouterModifier_FraisScolaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_AjouterModifier_FraisScolaire";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Supprimer;
    }
}