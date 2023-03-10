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


namespace GESTION_KELASI.PL
{
    public partial class FRM_AjouterModifier_Classe : Form
    {

        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security = true ");
        
        SqlDataAdapter singh = new SqlDataAdapter();

        SqlDataReader dr;

        
        public FRM_AjouterModifier_Classe()
        {
            InitializeComponent();

            GenerateID();
            GeneratID();
            GeneraterID();
            GeneraID();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void TxtClasse_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void GenerateID()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(CodeFraisI) FROM FraisInscription";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    TxtID_In.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    TxtID_In.Text = string.Format("0-{0:0000}", intval);
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

       
        private void GeneratID()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(CodeFraisRe) FROM fraisReinscription";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    Txt_re.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    Txt_re.Text = string.Format("0-{0:0000}", intval);
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
        /// ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void GeneraterID()
        {

            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(CodeScol) FROM FraisScolaire";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    Txt_sc.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    Txt_sc.Text = string.Format("0-{0:0000}", intval);
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
        /// ///////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void GeneraID()
        {
            try
            {
                com.Open(); //Ouvrir la connexion
                string ajout = "SELECT Max(codeclasse) FROM classe";
                SqlCommand cmd = new SqlCommand(ajout, com);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    Txt_classe.Text = "0-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;

                    Txt_classe.Text = string.Format("0-{0:0000}", intval);
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
        /// //////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
             
            if (Cmb_Classe.Text == "")
            {
                MessageBox.Show("Vous aviez oubliez de selectionné le champs classe !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(Txt_FraisInscription.Text == "")
            {
                MessageBox.Show("Vous aviez oubliez le chmps Frais Inscription !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Txt_FraisReinscription.Text == "")
            {
                MessageBox.Show("Vous aviez oubliez le champs Frais réinscription !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Txt_FraisScolaire.Text == "")
            {
                MessageBox.Show("Vous aviez oubliez le champs Frais Scolaire !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                com.Open();

                singh.SelectCommand = new SqlCommand("SELECT classe FROM classe WHERE classe = @classe", com);
                singh.SelectCommand.Parameters.AddWithValue("@classe", Cmb_Classe.Text);
                
                string Cl = (string)singh.SelectCommand.ExecuteScalar();

                com.Close();

               if (Cl != null && Cl.Equals(Cmb_Classe.Text))
                {
                    MessageBox.Show("Cette classe est déjà enregistrée dans la base de données !");
                    ClearParent();
                }
                else
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Voulez-vous sauvegarder ?", "Sauvegarder !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            com.Open();
                            ////////////////////////////////////////////////
                            // Insert data into FraisInscription table
                            singh.InsertCommand = new SqlCommand("INSERT INTO FraisInscription (CodeFraisI, fraisInscription) VALUES (@CodeFraisI, @fraisInscription)", com);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeFraisI", TxtID_In.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@fraisInscription", Txt_FraisInscription.Text);
                            singh.InsertCommand.ExecuteNonQuery();
                            singh.InsertCommand.Parameters.Clear();

                            // Insert data into FraisReinscription table
                            singh.InsertCommand = new SqlCommand("INSERT INTO FraisReinscription (CodeFraisRe, fraisReinscription) VALUES (@CodeFraisRe, @fraisReinscription)", com);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeFraisRe", Txt_re.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@fraisReinscription", Txt_FraisReinscription.Text);
                            singh.InsertCommand.ExecuteNonQuery();

                            // Insert data into FraisScolaire table
                            singh.InsertCommand = new SqlCommand("INSERT INTO FraisScolaire (CodeScol, fraisScolaire, fraisTotal) VALUES (@CodeScol, @fraisScolaire, @fraisTotal)", com);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeScol", Txt_sc.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@fraisScolaire", Txt_FraisScolaire.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@fraisTotal", Txt_totalPayer.Text);
                            singh.InsertCommand.ExecuteNonQuery();

                            // Insert data into classe table
                            singh.InsertCommand = new SqlCommand("INSERT INTO classe (codeclasse, classe, CodeFraisI, CodeFraisRe, CodeScol) VALUES (@codeclasse, @classe, @CodeFraisI, @CodeFraisRe, @CodeScol)", com);
                            singh.InsertCommand.Parameters.AddWithValue("@codeclasse", Txt_classe.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@classe", Cmb_Classe.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeFraisI", TxtID_In.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeFraisRe", Txt_re.Text);
                            singh.InsertCommand.Parameters.AddWithValue("@CodeScol", Txt_sc.Text);
                            singh.InsertCommand.ExecuteNonQuery();

                            com.Close();

                            ClearParent();
                            MessageBox.Show("Les données ont bien été enregistrées avec succès !");
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Votre operation est annuller", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearParent();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }                             
        }

        private void Txt_FraisScolaire_TextChanged(object sender, EventArgs e)
        {
            Txt_FraisScolaire.BackColor = Color.White;

            if (Txt_FraisScolaire.Text != "")
            {
                int prix = int.Parse(Txt_FraisScolaire.Text);
                Txt_totalPayer.Text = (prix * 9).ToString();
            }
            else
            {
                Txt_totalPayer.Text = "";
            }
        }

        void ClearParent()
        { 
            Cmb_Classe.SelectedIndex = -1;
            Txt_FraisInscription.Text = "";
            Txt_FraisReinscription.Text = "";
            Txt_FraisScolaire.Text = "";
            Txt_totalPayer.Text = "";
        }

        private void ActualiserDatagrid()
        {
            // Réexécuter la requête de base de données qui remplit le DataGridView
            singh.SelectCommand = new SqlCommand("SELECT C.codeclasse, C.classe, I.CodeFraisI, I.fraisInscription, R.CodeFraisRe, R.fraisReinscription, S.CodeScol, S.fraisScolaire, S.fraisTotal FROM classe C, FraisInscription I, FraisReinscription R, FraisScolaire S WHERE I.CodeFraisI = C.CodeFraisI and R.CodeFraisRe = C.CodeFraisRe and S.CodeScol = C.CodeScol", com);

            try
            {
                com.Open();
                singh.SelectCommand.ExecuteNonQuery();
                dr = singh.SelectCommand.ExecuteReader();
                DtgClasse.Rows.Clear();

                while (dr.Read())
                {
                    DtgClasse.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
            com.Close();
        }

        private void Btn_Afficher_Click_1(object sender, EventArgs e)
        {
            singh.SelectCommand = new SqlCommand("SELECT C.codeclasse, C.classe, I.CodeFraisI, I.fraisInscription, R.CodeFraisRe, R.fraisReinscription, S.CodeScol, S.fraisScolaire, S.fraisTotal FROM classe C, FraisInscription I, FraisReinscription R, FraisScolaire S WHERE I.CodeFraisI = C.CodeFraisI and R.CodeFraisRe = C.CodeFraisRe and S.CodeScol = C.CodeScol", com);
            
            try
            {
                com.Open();
                singh.SelectCommand.ExecuteNonQuery();
                dr = singh.SelectCommand.ExecuteReader();   
                DtgClasse.Rows.Clear();

                while (dr.Read())
                {
                    DtgClasse.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));
                }               
            }
             catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
             com.Close();    
        }

        public string SelectVerif()
        {
            int NombreligneSelect = 0;

            for(int i=0; i < DtgClasse.Rows.Count; i++)
            {
                if ((bool)DtgClasse.Rows[i].Cells[0].Value == true)
                {
                    NombreligneSelect++;
                }
            }
            if(NombreligneSelect == 0)
            {
                return "Selectionné une seule ligne que vous voulez affiché, modifier ou supprimer";
            }
            if (NombreligneSelect > 1)
            {
                return "Selectionné une seule ligne pour modifier";
            }
            return null;
        }

        //public string IDselect;
        private void Btn_ModifierC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez-vous Modifier ?", "Modification !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    com.Open();

                    // Update data in FraisInscription table
                    singh.UpdateCommand = new SqlCommand("UPDATE FraisInscription SET fraisInscription = @fraisInscription WHERE CodeFraisI=@CodeFraisI", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeFraisI", TxtID_In.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@fraisInscription", Txt_FraisInscription.Text);
                    singh.UpdateCommand.ExecuteNonQuery();

                    // Update data in FraisReinscription table
                    singh.UpdateCommand = new SqlCommand("UPDATE FraisReinscription SET fraisReinscription = @fraisReinscription WHERE CodeFraisRe=@CodeFraisRe", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeFraisRe", Txt_re.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@fraisReinscription", Txt_FraisReinscription.Text);
                    singh.UpdateCommand.ExecuteNonQuery();

                    // Update data in FraisScolaire table
                    singh.UpdateCommand = new SqlCommand("UPDATE FraisScolaire SET fraisScolaire = @fraisScolaire, fraisTotal=@fraisTotal WHERE CodeScol=@CodeScol", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeScol", Txt_sc.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@fraisScolaire", Txt_FraisScolaire.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@fraisTotal", Txt_totalPayer.Text);
                    singh.UpdateCommand.ExecuteNonQuery();

                    // Update data in classe table
                    singh.UpdateCommand = new SqlCommand("UPDATE classe SET classe=@classe, CodeFraisI=@CodeFraisI, CodeFraisRe=@CodeFraisRe, CodeScol=@CodeScol WHERE codeclasse=@codeclasse", com);
                    singh.UpdateCommand.Parameters.AddWithValue("@codeclasse", Txt_classe.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@classe", Cmb_Classe.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeFraisI", TxtID_In.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeFraisRe", Txt_re.Text);
                    singh.UpdateCommand.Parameters.AddWithValue("@CodeScol", Txt_sc.Text);
                    singh.UpdateCommand.ExecuteNonQuery();
                    
                    com.Close();
                    ClearParent();
                    ActualiserDatagrid();
                    Btn_Valider.Enabled = true;
                    Btn_Supprimer.Enabled = true;
                    MessageBox.Show("Votre sauvegarder a été effectué avec succès");
                }
                else if (result == DialogResult.No)
                {
                   ClearParent();
                   MessageBox.Show("Votre operation est annuller", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }           
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_FraisInscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void Txt_FraisReinscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void Txt_FraisScolaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void DtgClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {

            if (SelectVerif() == null)
            {
                for (int i = 0; i < DtgClasse.Rows.Count; i++)
                {
                    if ((bool)DtgClasse.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        //IDselect = (string)DtgClasse.Rows[i].Cells[1].Value;
                        Txt_classe.Text = DtgClasse.Rows[i].Cells[1].Value.ToString();
                        Cmb_Classe.Text = DtgClasse.Rows[i].Cells[2].Value.ToString();
                        TxtID_In.Text = DtgClasse.Rows[i].Cells[3].Value.ToString();
                        Txt_FraisInscription.Text = DtgClasse.Rows[i].Cells[4].Value.ToString();
                        Txt_re.Text = DtgClasse.Rows[i].Cells[5].Value.ToString();
                        Txt_FraisReinscription.Text = DtgClasse.Rows[i].Cells[6].Value.ToString();
                        Txt_sc.Text = DtgClasse.Rows[i].Cells[7].Value.ToString();
                        Txt_FraisScolaire.Text = DtgClasse.Rows[i].Cells[8].Value.ToString();
                        Txt_totalPayer.Text = DtgClasse.Rows[i].Cells[9].Value.ToString();
                        
                        Btn_Valider.Enabled = false;
                        Btn_Supprimer.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (SelectVerif() == "Selectionner")
            {
                MessageBox.Show(SelectVerif(), "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    //verification de combien de ligne selectionner
                    foreach (DataGridViewRow item in DtgClasse.Rows)
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString()))// si la ligne est cocher
                        {
                            com.Open();

                            singh.DeleteCommand = new SqlCommand("DELETE FROM classe WHERE codeclasse = @codeclasse", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@codeclasse", item.Cells[1].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            singh.DeleteCommand = new SqlCommand("DELETE FROM FraisInscription WHERE CodeFraisI = @CodeFraisI", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@CodeFraisI", item.Cells[3].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            singh.DeleteCommand = new SqlCommand("DELETE FROM FraisReinscription WHERE CodeFraisRe = @CodeFraisRe", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@CodeFraisRe", item.Cells[5].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            singh.DeleteCommand = new SqlCommand("DELETE FROM FraisScolaire WHERE CodeScol = @CodeScol", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@CodeScol", item.Cells[7].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            com.Close();
                        }
                    }
                    //actualiser le datagrid view
                    //Actualisedatagrid();
                    ActualiserDatagrid();

                    MessageBox.Show("Les données son supprimer avec succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supprimer est annuler", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Cmb_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Classe.BackColor = Color.White;
        }

        private void Txt_FraisInscription_TextChanged(object sender, EventArgs e)
        {
            Txt_FraisInscription.BackColor = Color.White;
        }

        private void Txt_FraisReinscription_TextChanged(object sender, EventArgs e)
        {
            Txt_FraisReinscription.BackColor = Color.White;
        }
    }
}
