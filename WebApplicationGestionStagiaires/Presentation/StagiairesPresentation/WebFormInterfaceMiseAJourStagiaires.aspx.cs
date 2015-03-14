using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationGestionStagiaires.Operations.StagiairesOperations;

namespace PrototypeGestionStagiaires.Presentation.StagiairesPresentation
{
    public partial class WebFormInterfaceMiseAJourStagiaires : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.Actualiser();
        }
        private void ChargerStagiaire(Stagiaire s)
        {
            if (s != null)
            {
                this.lblId.Text = s.Id.ToString();
                this.txtNom.Text = s.Nom;
                this.lblDateCréation.Text = s.DateCréation.ToString();
                this.lblDateModification.Text = s.DateModificationString;
            }
        }
        private void Actualiser()
        {
            GridView1.DataSource = StagiairesOperations.Afficher();
            GridView1.DataBind();
            this.ChargerStagiaire(StagiairesOperations.Debut());
        }

        protected void btNouveau_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            lblDateCréation.Text = DateTime.Now.ToShortTimeString();
            lblDateModification.Text = "";
        }

        protected void btEnregistrer_Click(object sender, EventArgs e)
        {
            Stagiaire g = new Stagiaire();
            g.Nom = txtNom.Text;
            StagiairesOperations.Enregistrer(g);
            this.Actualiser();
        }

        protected void btDebut_Click(object sender, EventArgs e)
        {
            Stagiaire g = StagiairesOperations.Debut();
            this.ChargerStagiaire(g);

        }



        protected void btPrecedent_Click(object sender, EventArgs e)
        {
            Stagiaire g = StagiairesOperations.Precedent(int.Parse(lblId.Text));
            this.ChargerStagiaire(g);
        }

        protected void btSuivant_Click(object sender, EventArgs e)
        {
            Stagiaire g = StagiairesOperations.Suivant(int.Parse(lblId.Text));
            this.ChargerStagiaire(g);
        }

        protected void btFin_Click(object sender, EventArgs e)
        {
            Stagiaire g = StagiairesOperations.Fin();
            this.ChargerStagiaire(g);
        }

        protected void btSupprimer_Click(object sender, EventArgs e)
        {
            StagiairesOperations.Supprimer(int.Parse(lblId.Text));
            this.Actualiser();
        }

        protected void btModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Stagiaire s = StagiairesOperations.getStagiaire(id);
            s.Nom = txtNom.Text;
            s.Prenom = txtPrenom.Text;
            s.IdGroupe = int.Parse(DropDownListGroupe.SelectedValue);
            StagiairesOperations.Modifier(s);
            this.Actualiser();
        }
    }
}