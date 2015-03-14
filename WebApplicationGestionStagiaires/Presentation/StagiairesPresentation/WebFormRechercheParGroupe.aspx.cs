﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationGestionStagiaires.Operations.GroupesOperations;
using WebApplicationGestionStagiaires.Operations.StagiairesOperations;

namespace PrototypeGestionStagiaires.Presentation.StagiairesPresentation
{
    public partial class WebFormRechercheParGroupe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                GridView1.DataSource = StagiairesOperations.Afficher();
                GridView1.DataBind();
                DropDownListGroupe.DataSource = GroupesOperations.Afficher();
                
                DropDownListGroupe.DataBind();
                DropDownListGroupe.Items.Insert(0,new ListItem("", "-1"));
                
            }
        }

        protected void btRecherche_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = StagiairesOperations.Recherche(int.Parse(DropDownListGroupe.SelectedValue),txtNom.Text);
            GridView1.DataBind();
        }
    }
}