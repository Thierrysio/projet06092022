using System;
using System.Collections.Generic;
using System.Text;

namespace projet06092022.Modeles
{
    class Etudiant
    {
        #region Attributs

        public static List<Etudiant> CollClasse = new List<Etudiant>();
        private string _nom;
        private string _prenom;
        #endregion

        #region Constructeurs

        public Etudiant(string nom, string prenom)
        {
            Etudiant.CollClasse.Add(this);
            Nom = nom;
            Prenom = prenom;
        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
