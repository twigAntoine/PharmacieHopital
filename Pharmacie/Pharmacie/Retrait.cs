﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Retrait
    {
        private Int32 id, quantiteMedicament;
        private DateTime dateRetrait;
        private Medecin leMedecin;
        private Medicament leMedicament;
        private Utilisateur lUtilisateur;

        public Retrait(Int32 id, Int32 quantiteMedicament, DateTime dateRetrait, Medecin leMedecin, Medicament leMedicament, Utilisateur lUtilisateur)
        {
            this.id = id;
            this.quantiteMedicament = quantiteMedicament;
            this.dateRetrait = dateRetrait;
            this.leMedecin = leMedecin;
            this.leMedicament = leMedicament;
            this.lUtilisateur = lUtilisateur;
        }

        public override string ToString()
        {
            return "Retrait n° " + id + " Medicament : " + leMedicament.ToString() + " quantité : " + quantiteMedicament+" date retrait : "+ dateRetrait + " Medecin :" + leMedecin.ToString() + " Pharmacien : " + lUtilisateur.ToString();
        }
    }
}
