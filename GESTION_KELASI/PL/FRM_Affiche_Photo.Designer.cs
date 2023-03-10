namespace GESTION_KELASI.PL
{
    partial class FRM_Affiche_Photo
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
            this.PT_AffichePhoto = new System.Windows.Forms.PictureBox();
            this.LB_AffichePhoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PT_AffichePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_Fermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 30);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.FlatAppearance.BorderSize = 0;
            this.Btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fermer.Image = global::GESTION_KELASI.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Btn_Fermer.Location = new System.Drawing.Point(342, 3);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(24, 23);
            this.Btn_Fermer.TabIndex = 2;
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 5);
            this.panel2.TabIndex = 0;
            // 
            // PT_AffichePhoto
            // 
            this.PT_AffichePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PT_AffichePhoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PT_AffichePhoto.Location = new System.Drawing.Point(8, 76);
            this.PT_AffichePhoto.Name = "PT_AffichePhoto";
            this.PT_AffichePhoto.Size = new System.Drawing.Size(354, 296);
            this.PT_AffichePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PT_AffichePhoto.TabIndex = 1;
            this.PT_AffichePhoto.TabStop = false;
            // 
            // LB_AffichePhoto
            // 
            this.LB_AffichePhoto.AutoSize = true;
            this.LB_AffichePhoto.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AffichePhoto.Location = new System.Drawing.Point(99, 44);
            this.LB_AffichePhoto.Name = "LB_AffichePhoto";
            this.LB_AffichePhoto.Size = new System.Drawing.Size(36, 27);
            this.LB_AffichePhoto.TabIndex = 2;
            this.LB_AffichePhoto.Text = "Lb";
            // 
            // FRM_Affiche_Photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 384);
            this.Controls.Add(this.LB_AffichePhoto);
            this.Controls.Add(this.PT_AffichePhoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Affiche_Photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_Affiche_Photo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PT_AffichePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Fermer;
        public System.Windows.Forms.PictureBox PT_AffichePhoto;
        public System.Windows.Forms.Label LB_AffichePhoto;
    }
}