﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGestionStagiaires.Operations.StagiairesOperations
{
    public class Stagiaire
    {
       

        public Stagiaire(int id, string prenom, string nom , int id_groupe,DateTime dateCréation)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.IdGroupe = id_groupe;
            this.DateCréation = dateCréation;
        }

        public Stagiaire()
        {
            
        }

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int IdGroupe { get; set; }

        public DateTime DateCréation { get; set; }

        public DateTime DateModification { get; set; }

        public String DateModificationString
        {
            get
            {
                if (this.DateModification == new DateTime())
                    return "-";
                else
                    return this.DateModification.ToString();
            }

        }
    }
}