using projet06092022.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace projet06092022.VueModeles
{
    class GestionEtudiantVueModele : BaseVueModele
    {


        #region Attributs

        private Etudiant _e1;

        #endregion

        #region Constructeurs

        public GestionEtudiantVueModele()
        {
            E1 = new Etudiant("Riri","DonaldDuck");
        }

        #endregion

        #region Getters/Setters
        public Etudiant E1
        {
            get
            {
                return _e1;
            }
            set
            {
               value.Nom.ToUpper();
                SetProperty(ref _e1, value);
            }
        }
        #endregion

        #region Methodes

        #endregion
    }
}
