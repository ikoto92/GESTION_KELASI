using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
//using System.Data.SqlClient;


namespace GESTION_KELASI.PL
{
    public partial class FRM_AjouterModifier_Inscription : Form
    {
        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public FRM_AjouterModifier_Inscription()
        {
            InitializeComponent();
            CombClasse();
            //GetPrixInscription();
            GenerateAutoID();
            GeneratID();
            GeneratIDInscription();
            GeneratIDParcSc();
            timer1.Start();
            //GetIDClasse();
            GeneratIDDossier();
            SetTabOrder();
        }

       
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GeneratIDParcSc()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(codeInfScol) FROM Parcourscolaires";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    Txt_IDParScolaire.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    Txt_IDParScolaire.Text = string.Format("0-{0:0000}", intval);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                com.Close(); //Fermer la connexion
            }
        }

        /// <summary>
        /// /Générateur de code automatique de la table étudiant
        /// </summary>
        private void GenerateAutoID()
        {
            try
            {
                string currentYear = DateTime.Now.Year.ToString();
                string query = "SELECT MAX(codeEt) FROM etudiant WHERE codeEt LIKE '%" + currentYear + "%'";
                SqlCommand cmd = new SqlCommand(query, com);
                com.Open();
                string maxID = cmd.ExecuteScalar().ToString();

                if (string.IsNullOrEmpty(maxID))
                {
                    Txt_IDEtudiant.Text = currentYear + "-0001";
                }
                else
                {
                    int lastID = int.Parse(maxID.Substring(5));
                    Txt_IDEtudiant.Text = currentYear + "-" + (lastID + 1).ToString("0000");
                }
                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void GeneratID()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(codeTuteur) FROM tuteur";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    Txt_IDTuteur.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    Txt_IDTuteur.Text = string.Format("0-{0:0000}", intval);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                com.Close(); //Fermer la connexion
            }
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void GeneratIDInscription()
        {
            try
            {
                string currentYear = DateTime.Now.Year.ToString();
                string query = "SELECT MAX(IDincription) FROM inscrire WHERE IDincription LIKE '%" + currentYear + "%'";
                SqlCommand cmd = new SqlCommand(query, com);
                com.Open();
                string maxID = cmd.ExecuteScalar().ToString();

                if (string.IsNullOrEmpty(maxID))
                {
                    Txt_IDInscription.Text = currentYear + "-0001";
                }
                else
                {
                    int lastID = int.Parse(maxID.Substring(5));
                    Txt_IDInscription.Text = currentYear + "-" + (lastID + 1).ToString("0000");
                }
                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ///////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void GeneratIDDossier()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(codeDo) FROM Dossier";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    TxtID_Dossier.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    TxtID_Dossier.Text = string.Format("0-{0:0000}", intval);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                com.Close(); //Fermer la connexw  ion
            }
        }
        /// 
        ///////////////////
        ///

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{2}-\d{3}-\d{3}-\d{1}$");
        }

        private void TxtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        /// <summary>
        /// //combox classe auto complete avec prix de cha classe.
        /// </summary>
        private void CombClasse()
        {

            string sqlquery = "SELECT * FROM [dbo].[classe]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, com);
            com.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Cmb_Classe.ValueMember = "codeclasse";
            Cmb_Classe.DisplayMember = "classe";
            Cmb_Classe.DataSource = dt;
            TxtFraisnscription.Enabled = false;

            com.Close();
        }


        BindingSource bsAnneAcademique = new BindingSource();
        private void CombAnneeScolaire()
        {
            com.Open();

            SqlCommand cmd = com.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT codeAn, anne FROM anneAcademique";
            //Ajout de la sélection des colonnes codeAn et anne
            cmd.Connection = com;
            SqlDataReader reader = cmd.ExecuteReader();
            bsAnneAcademique.DataSource = reader;
            Cmb_AnneeScolaire.DataSource = bsAnneAcademique;
            //ajout de la source de donnée et les valeur et affichage pour le combobox
            Cmb_AnneeScolaire.DisplayMember = "anne";
            Cmb_AnneeScolaire.ValueMember = "codeAn";
            com.Close();
        }


        private void Btn_Photo_Click(object sender, EventArgs e)
        {
            //Afficher la photo(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"

            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";//Pour afficher seulement les images 
            if (OP.ShowDialog() == DialogResult.OK)
            {
                P_Photo.Image = Image.FromFile(OP.FileName);
            }
        }
        /// <summary>
        /// ///  AUTO COMPLETE DE LA TABLE FRAIS INSCRIPTION 
        /// </summary>
        private void GetPrixInscription()
        {

            string sqlquery = "SELECT * FROM [dbo].[FraisInscription] where CodeFraisI=@CodeFraisI";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, com);
            com.Open();
            sqlcomm.Parameters.AddWithValue("@CodeFraisI", Cmb_Classe.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TxtIdFraisInscrip.Text = dr["CodeFraisI"].ToString();
                TxtFraisnscription.Text = dr["fraisInscription"].ToString();
            }
            com.Close();
        }
        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if (TxtNomEleve.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs nom de l'élève !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomEleve.Focus();
                return;
            }
            else if (TxtPrenomEleve.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs prénom de l'élève !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrenomEleve.Focus();
                return;
            }
            else if (DtmNaissance.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs date de naissance !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtmNaissance.Focus(); // redirige le focus vers le champ nom
                return;
            }
            else if (TxtLieuNaissance.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs lieu de naissance !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLieuNaissance.Focus();
                return;
            }
            else if (CbbSexe.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir sélectionnée le champs sexe!", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbbSexe.Focus();
                return;
            }
            else if (TxtNationalite.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs nationalité !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNationalite.Focus();
                return;
            }
            else if (TxtDernierDipl.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir dernier diplôme !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDernierDipl.Focus();
                return;
            }
            else if (TxtAnnee.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs l'année de l'optention !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAnnee.Focus();
                return;
            }
            else if (TxtDernierNivScol.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs Dernier niveau scolaire !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDernierNivScol.Focus();
                return;
            }
            else if (TxtDernierEstScolaire.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs dernier établissement scolaire !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDernierEstScolaire.Focus();
                return;
            }
            else if (TxtNomPere.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs nom et prénom du pères !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomPere.Focus();
                return;
            }
            else if (TxtNomMere.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs nom et prénom de la mère !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomMere.Focus();
                return;
            }
            else if (TxtAdressParent.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs adresse parent", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAdressParent.Focus();
                return;
            }
            else if (TxtTuteur.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs tuteur !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTuteur.Focus();
                return;
            }
            else if (TxtTelephone.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs numéro de téléphone !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelephone.Focus();
                return;
            }
            else if (TxtLienParente.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir le champs lien parenté !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLienParente.Focus();
                return;
            }
            else if (Cmb_Classe.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir de selectionnée le champs classe !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_Classe.Focus();
                return;
            }
            else if (Cmb_AnneeScolaire.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir de sélectionnée champs l'année accadémique !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_AnneeScolaire.Focus();
                return;
            }
            else
            {
                // se connecter à la base de données
                SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
                //SqlDataAdapter singh = new SqlDataAdapter();
                //SqlDataReader dr;

                com.Open();

                // Récupérer les informations de l'élève et de la classe
                //string codeEtudiant = Txt_IDEtudiant.Text;
                string nomEtudiant = TxtNomEleve.Text;
                string prenomEtudiant = TxtPrenomEleve.Text;
                string codeClasse = Cmb_Classe.SelectedValue.ToString();
                string anneeAcademique = Cmb_AnneeScolaire.SelectedValue.ToString();

                // Vérifier si l'étudiant est déjà inscrit dans la classe et l'année académique
                string query = "SELECT * FROM inscrire i " +
                               "INNER JOIN etudiant e ON i.codeEt = e.codeEt " +
                               "WHERE e.NmEt = @NomEtudiant AND e.PrnmEt = @PrenomEtudiant " +
                               "AND i.codeclasse = @CodeClasse AND i.codeAn = @AnneeAcademique";
                
                SqlCommand cmd = new SqlCommand(query, com);
                cmd.Parameters.AddWithValue("@NomEtudiant", nomEtudiant);
                cmd.Parameters.AddWithValue("@PrenomEtudiant", prenomEtudiant);
                cmd.Parameters.AddWithValue("@CodeClasse", codeClasse);
                cmd.Parameters.AddWithValue("@AnneeAcademique", anneeAcademique);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Cet étudiant est déjà inscrit dans cette classe pour cette année académique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    //com.Close();
                    return;
                }
                
                com.Close();
                reader.Close();
              

                string bulletin = _isCheckedBulletin ? "Oui" : "Non";
                string diplome = _isCheckedDiplome ? "Oui" : "Non";
                string photo = _isCheckedPhoto ? "Oui" : "Non";
                //convertir l'image en format byte
                //Ajouter un système IO

                //convertir l'image en format byte
                MemoryStream MR = new MemoryStream();
                P_Photo.Image.Save(MR, P_Photo.Image.RawFormat);
                byte[] ByteImage = MR.ToArray();

                com.Open();


                // Vérifier si le RadioButton a été sélectionné
                if (!RB_Ancien.Checked && !RB_Nouveau.Checked)
                {
                    MessageBox.Show("Veuillez sélectionner un profil.");
                    return;
                }

                // Insert data into Parcourscolaires table
                singh.InsertCommand = new SqlCommand("INSERT INTO Parcourscolaires (codeInfScol, DipEntre, AnEt, DerNivEt, DerEstScol, Profil) VALUES (@codeInfScol, @DipEntre, @AnEt, @DerNivEt, @DerEstScol, @Profil)", com);
                singh.InsertCommand.Parameters.AddWithValue("@codeInfScol", Txt_IDParScolaire.Text);
                singh.InsertCommand.Parameters.AddWithValue("@DipEntre", TxtDernierDipl.Text);
                singh.InsertCommand.Parameters.AddWithValue("@AnEt", TxtAnnee.Text);
                singh.InsertCommand.Parameters.AddWithValue("@DerNivEt", TxtDernierNivScol.Text);
                singh.InsertCommand.Parameters.AddWithValue("@DerEstScol", TxtDernierEstScolaire.Text);
                singh.InsertCommand.Parameters.AddWithValue("@Profil", Profil);
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();


                // Insert data into Dossier table
                singh.InsertCommand = new SqlCommand("INSERT INTO Dossier (codeDo, Bulletin, Diplome, Photo) VALUES (@codeDo, @Bulletin, @Diplome, @Photo)", com);
                singh.InsertCommand.Parameters.AddWithValue("@codeDo", TxtID_Dossier.Text);
                singh.InsertCommand.Parameters.AddWithValue("@Bulletin", bulletin);
                singh.InsertCommand.Parameters.AddWithValue("@Diplome", diplome);
                singh.InsertCommand.Parameters.AddWithValue("@Photo", photo);
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();

                // Insert data into tuteur table
                singh.InsertCommand = new SqlCommand("INSERT INTO tuteur (codeTuteur, NmPRPere, NmPrMere, AdreParent, Tuteur, NumTuteur, lieuParent) VALUES (@codeTuteur, @NmPRPere, @NmPrMere, @AdreParent, @Tuteur, @NumTuteur, @lieuParent)", com);
                singh.InsertCommand.Parameters.AddWithValue("@codeTuteur", Txt_IDTuteur.Text);
                singh.InsertCommand.Parameters.AddWithValue("@NmPRPere", TxtNomPere.Text);
                singh.InsertCommand.Parameters.AddWithValue("@NmPrMere", TxtNomMere.Text);
                singh.InsertCommand.Parameters.AddWithValue("@AdreParent", TxtAdressParent.Text);
                singh.InsertCommand.Parameters.AddWithValue("@Tuteur", TxtTuteur.Text);
                singh.InsertCommand.Parameters.AddWithValue("@NumTuteur", TxtTelephone.Text);
                singh.InsertCommand.Parameters.AddWithValue("@lieuParent", TxtLienParente.Text);
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();


                // Insert data into etudiant table
                singh.InsertCommand = new SqlCommand("INSERT INTO etudiant (codeEt, NmEt, PrnmEt, DtNais, LieuNais, sexe, Nationalite, adresEt, photo, codeInfScol, codeDo, codeTuteur) VALUES (@codeEt, @NmEt, @PrnmEt, @DtNais, @LieuNais, @sexe, @Nationalite, @adresEt, @photo, @codeInfScol, @codeDo, @codeTuteur)", com);
                singh.InsertCommand.Parameters.AddWithValue("@codeEt", Txt_IDEtudiant.Text);
                singh.InsertCommand.Parameters.AddWithValue("@NmEt", TxtNomEleve.Text);
                singh.InsertCommand.Parameters.AddWithValue("@PrnmEt", TxtPrenomEleve.Text);
                singh.InsertCommand.Parameters.AddWithValue("@DtNais", DtmNaissance.Text);
                singh.InsertCommand.Parameters.AddWithValue("@LieuNais", TxtLieuNaissance.Text);
                singh.InsertCommand.Parameters.AddWithValue("@sexe", CbbSexe.Text);
                singh.InsertCommand.Parameters.AddWithValue("@Nationalite", TxtNationalite.Text);
                singh.InsertCommand.Parameters.AddWithValue("@adresEt", TxtAdressParent.Text);
                singh.InsertCommand.Parameters.AddWithValue("@photo", ByteImage);
                singh.InsertCommand.Parameters.AddWithValue("@codeInfScol", Txt_IDParScolaire.Text);
                singh.InsertCommand.Parameters.AddWithValue("@codeDo", TxtID_Dossier.Text);
                singh.InsertCommand.Parameters.AddWithValue("@codeTuteur", Txt_IDTuteur.Text);
                // Verify that the age of the student is greater than 4 years
                TimeSpan age = DateTime.Now - Convert.ToDateTime(DtmNaissance.Text);
                if (age.TotalDays < 365 * 4)
                {
                    MessageBox.Show("L'âge de l'élève doit être supérieur à 4 ans pour l'inscription");
                    return;
                }
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();

                // Insert data into inscrire table
                singh.InsertCommand = new SqlCommand("INSERT INTO inscrire (IDincription, dtInscription, codeEt, codeAn, CodeFraisI, codeclasse) VALUES (@IDincription, @dtInscription, @CodeEt, @codeAn, @CodeFraisI, @codeclasse)", com);
                singh.InsertCommand.Parameters.AddWithValue("@IDincription", Txt_IDInscription.Text);
                singh.InsertCommand.Parameters.AddWithValue("@dtInscription", Lbl_Time.Text);
                singh.InsertCommand.Parameters.AddWithValue("@CodeEt", Txt_IDEtudiant.Text);
                singh.InsertCommand.Parameters.AddWithValue("@codeAn", Convert.ToInt32(Cmb_AnneeScolaire.SelectedValue));
                singh.InsertCommand.Parameters.AddWithValue("@CodeFraisI", TxtIdFraisInscrip.Text);
                singh.InsertCommand.Parameters.AddWithValue("@codeclasse", Convert.ToString(Cmb_Classe.SelectedValue));
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();

               
                int rowsAffected = cmd.ExecuteNonQuery();
                com.Close();
              
                if (rowsAffected > 0)
                {
                    MessageBox.Show("L'inscription a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    com.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'inscription.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    com.Open();
                }
            }
        }
        private void SetTabOrder()
        {
            this.TabIndex = 0;

            // Définir l'ordre des focus pour chaque contrôle sur le formulaire
            TxtNomEleve.TabIndex = 1;
            TxtPrenomEleve.TabIndex = 2;
            DtmNaissance.TabIndex = 3;
            TxtLieuNaissance.TabIndex = 4;
            CbbSexe.TabIndex = 5;
            TxtNationalite.TabIndex = 6;
            TxtDernierDipl.TabIndex = 7;
            TxtAnnee.TabIndex = 8;
            TxtDernierNivScol.TabIndex = 9;
            TxtDernierEstScolaire.TabIndex = 10;
            TxtNomPere.TabIndex = 11;
            TxtNomMere.TabIndex = 12;
            TxtAdressParent.TabIndex = 13;
            TxtTuteur.TabIndex = 14;
            TxtTelephone.TabIndex = 15;
            TxtLienParente.TabIndex = 16;
            Cmb_Classe.TabIndex = 17;
            Cmb_AnneeScolaire.TabIndex = 18;
        } 

        private void TxtNomEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrenomEleve_TextChanged(object sender, EventArgs e)
        {
            //TxtPrenomEleve.BackColor = Color.White;
        }

        private void DtmNaissance_ValueChanged(object sender, EventArgs e)
        {
            //DtmNaissance.BackColor = Color.White;
        }

        private void TxtLieuNaissance_TextChanged(object sender, EventArgs e)
        {
            //TxtLieuNaissance.BackColor = Color.White;
        }

        private void CbbSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CbbSexe.BackColor = Color.White;
        }

        private void TxtNationalite_TextChanged(object sender, EventArgs e)
        {
            //TxtNationalite.BackColor = Color.White;
        }

        private void TxtDernierDipl_TextChanged(object sender, EventArgs e)
        {
            //TxtDernierDipl.BackColor = Color.White;
        }

        private void TxtAnnee_TextChanged(object sender, EventArgs e)
        {
            //TxtAnnee.BackColor = Color.White;
        }

        private void TxtDernierNivScol_TextChanged(object sender, EventArgs e)
        {
            //TxtDernierNivScol.BackColor = Color.White;
        }

        private void TxtDernierEstScolaire_TextChanged(object sender, EventArgs e)
        {
            //TxtDernierEstScolaire.BackColor = Color.White;
        }

        private void TxtNomPere_TextChanged(object sender, EventArgs e)
        {
           // TxtNomPere.BackColor = Color.White;
        }

        private void TxtNomMere_TextChanged(object sender, EventArgs e)
        {
           // TxtNomMere.BackColor = Color.White;
        }

        private void TxtAdressParent_TextChanged(object sender, EventArgs e)
        {
            //TxtAdressParent.BackColor = Color.White;
        }

        private void TxtTuteur_TextChanged(object sender, EventArgs e)
        {
            //TxtTuteur.BackColor = Color.White;
        }

        private void TxtTelephone_TextChanged(object sender, EventArgs e)
        {
            //TxtTelephone.BackColor = Color.White;
        }

        private void TxtLienParente_TextChanged(object sender, EventArgs e)
        {
            //TxtLienParente.BackColor = Color.White;
        }

        private void Cmb_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cmb_Classe.BackColor = Color.White;

        }

        private void Cmb_AnneeScolaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cmb_AnneeScolaire.BackColor = Color.White;
        }

        private void FRM_AjouterModifier_Inscription_Load(object sender, EventArgs e)
        {
            //CombClasse();
            CombAnneeScolaire();
        }

        private void Btn_Annuller_Click(object sender, EventArgs e)
        {
            // Remettre tous les champs de formulaire à leur valeur par défaut
            TxtNomEleve.Text = "";
            TxtPrenomEleve.Text = "";
            DtmNaissance.Value = DateTime.Now;
            TxtLieuNaissance.Text = "";
            CbbSexe.SelectedIndex = -1;
            TxtNationalite.Text = "";
            TxtDernierDipl.Text = "";
            TxtAnnee.Text = "";
            TxtDernierNivScol.Text = "";
            TxtDernierEstScolaire.Text = "";
            TxtNomPere.Text = "";
            TxtNomMere.Text = "";
            TxtAdressParent.Text = "";
            TxtTuteur.Text = "";
            TxtTelephone.Text = "";
            TxtLienParente.Text = "";
            Cmb_Classe.SelectedIndex = -1;
            Cmb_AnneeScolaire.SelectedIndex = -1;
        }
        /// <summary>
        /// /////////
        /// </summary>
        /// 

        string Profil;

        /// <summary>
        /// ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void Cmb_Classe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPrixInscription();
           
        }

        private void RB_Ancien_CheckedChanged(object sender, EventArgs e)
        {
            Profil = "Ancien";
        }

        private void RB_Nouveau_CheckedChanged(object sender, EventArgs e)
        {
            Profil = "Nouveau"; 
        }

        private const bool CHECKED_VALUE = true;
        private const bool UNCHECKED_VALUE = false;
        private bool _isCheckedBulletin = false;
        private bool _isCheckedDiplome = false;
        private bool _isCheckedPhoto = false;

        private void Cb_Bulletin_CheckedChanged(object sender, EventArgs e)
        {
            _isCheckedBulletin = Cb_Bulletin.Checked;
        }

        private void Cb_Diplome_CheckedChanged(object sender, EventArgs e)
        {
            _isCheckedDiplome = Cb_Diplome.Checked;
        }

        private void Cb_Photo_CheckedChanged(object sender, EventArgs e)
        {
            _isCheckedPhoto = Cb_Photo.Checked;
        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.Now;
            this.Lbl_Time.Text = dateTime.ToString();
        }

        private void Clear()
        {
            // Remettre tous les champs de formulaire à leur valeur par défaut
            TxtNomEleve.Text = "";
            TxtPrenomEleve.Text = "";
            DtmNaissance.Value = DateTime.Now;
            TxtLieuNaissance.Text = "";
            CbbSexe.SelectedIndex = -1;
            TxtNationalite.Text = "";
            TxtDernierDipl.Text = "";
            TxtAnnee.Text = "";
            TxtDernierNivScol.Text = "";
            TxtDernierEstScolaire.Text = "";
            TxtNomPere.Text = "";
            TxtNomMere.Text = "";
            TxtAdressParent.Text = "";
            TxtTuteur.Text = "";
            TxtTelephone.Text = "";
            TxtLienParente.Text = "";
            Cmb_Classe.SelectedIndex = -1;
            Cmb_AnneeScolaire.SelectedIndex = -1;
        }

        private void TxtTelephone_Leave(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(TxtTelephone.Text))
            {
                MessageBox.Show("Le numéro de téléphone n'est pas valide. Veuillez entrer un numéro de téléphone valide sous la forme XX-XXX-XXX-X");
                TxtTelephone.Focus();
            }
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment Modifier les informations de l'élève ?", "Modification !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    com.Open();

                    string bulletin = _isCheckedBulletin ? "Oui" : "Non";
                    string diplome = _isCheckedDiplome ? "Oui" : "Non";
                    string photo = _isCheckedPhoto ? "Oui" : "Non";
                    //convertir l'image en format byte
                    //Ajouter un système IO

                    //convertir l'image en format byte
                    MemoryStream MR = new MemoryStream();
                    P_Photo.Image.Save(MR, P_Photo.Image.RawFormat);
                    byte[] ByteImage = MR.ToArray();               

                    // // Update data in Parcourscolaires table
                    singh.UpdateCommand = new SqlCommand("UPDATE Parcourscolaires SET  DipEntre = @DipEntre, AnEt=@AnEt, DerNivEt=@DerNivEt, DerEstScol=@DerEstScol, Profil=@Profil WHERE codeInfScol=@codeInfScol)", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeInfScol", Txt_IDParScolaire.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@DipEntre", TxtDernierDipl.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@AnEt", TxtAnnee.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@DerNivEt", TxtDernierNivScol.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@DerEstScol", TxtDernierEstScolaire.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@Profil", Profil);
                    singh.UpdateCommand.ExecuteNonQuery();
                    //singh.UpdateCommand.Parameters.Clear();

                    // Update data in Dossier table
                    singh.UpdateCommand = new SqlCommand("UPDATE Dossier SET Bulletin = @Bulletin, Diplome = @Diplome, Photo = @Photo WHERE codeDo=@codeDo)", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeDo", TxtID_Dossier.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@Bulletin", bulletin);
                    singh.UpdateCommand.Parameters.AddWithValue("@Diplome", diplome);
                    singh.UpdateCommand.Parameters.AddWithValue("@Photo", photo);
                    singh.UpdateCommand.ExecuteNonQuery();
                    //singh.UpdateCommand.Parameters.Clear();

                    // Update data in tuteur table
                    singh.UpdateCommand = new SqlCommand("UPDATE tuteur SET NmPRPere=@NmPRPere, NmPrMere=@NmPrMere, AdreParent=@AdreParent, Tuteur=@Tuteur, NumTuteur=@NumTuteur, lieuParent=@lieuParent WHERE codeTuteur=@codeTuteur)", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeTuteur", Txt_IDTuteur.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@NmPRPere", TxtNomPere.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@NmPrMere", TxtNomMere.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@AdreParent", TxtAdressParent.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@Tuteur", TxtTuteur.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@NumTuteur", TxtTelephone.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@lieuParent", TxtLienParente.Text);
                    singh.UpdateCommand.ExecuteNonQuery();
                    //singh.UpdateCommand.Parameters.Clear();

                    // Update data in etudiant table
                    singh.UpdateCommand = new SqlCommand("UPDATE etudiant SET NmEt=@NmEt, PrnmEt=@PrnmEt, DtNais=@DtNais, LieuNais=@LieuNais, sexe=@sexe, Nationalite=@Nationalite, adresEt=@adresEt, photo=@photo, codeInfScol=@codeInfScol, codeDo=@codeDo, codeTuteur=@codeTuteur WHERE codeEt=@codeEt)", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeEt", Txt_IDEtudiant.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@NmEt", TxtNomEleve.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@PrnmEt", TxtPrenomEleve.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@DtNais", DtmNaissance.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@LieuNais", TxtLieuNaissance.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@sexe", CbbSexe.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@Nationalite", TxtNationalite.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@adresEt", TxtAdressParent.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@photo", ByteImage);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeInfScol", Txt_IDParScolaire.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeDo", TxtID_Dossier.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeTuteur", Txt_IDTuteur.Text);
                    // Verify that the age of the student is greater than 4 years
                    TimeSpan age = DateTime.Now - Convert.ToDateTime(DtmNaissance.Text);
                    if (age.TotalDays < 365 * 4)
                    {
                        MessageBox.Show("L'âge de l'élève doit être supérieur à 4 ans pour l'inscription");
                        return;
                    }
                    singh.UpdateCommand.ExecuteNonQuery();
                    //singh.UpdateCommand.Parameters.Clear();

               
                    // // Update data in inscrire table
                    singh.UpdateCommand = new SqlCommand("UPDATE inscrire SET dtInscription=@dtInscription, codeEt=@CodeEt, codeAn=@codeAn, CodeFraisI=@CodeFraisI, codeclasse=@codeclasse WHERE IDincription=@IDincription)", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@IDincription", Txt_IDInscription.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@dtInscription", Lbl_Time.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeEt", Txt_IDEtudiant.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeAn", Convert.ToInt32(Cmb_AnneeScolaire.SelectedValue));
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeFraisI", TxtIdFraisInscrip.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeclasse", Convert.ToString(Cmb_Classe.SelectedValue));
                    singh.UpdateCommand.ExecuteNonQuery();
                    // singh.UpdateCommand.Parameters.Clear();
                    com.Close();

                    MessageBox.Show("Votre mise à jour a été effectué avec succès");
                    Close();   
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Votre operation est annuller", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                com.Close();
            }
        }
    }
}
