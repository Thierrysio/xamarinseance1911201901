using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace xamarinseance1911201901.Modeles
{
    class Intervenant
    {
        #region Attribut
        public static ArrayList CollClassIntervenant = new ArrayList();

        private string _chaine;
        private int _tauxhoraire;
        #endregion
        #region Constructeur 
        public Intervenant(string lachaine, int txhoraire)
        {
            this._chaine = lachaine;
            this._tauxhoraire = txhoraire;
            Intervenant.CollClassIntervenant.Add(this);
        }
        #endregion
        #region GetSet
        public string Chaine { get => _chaine; set => _chaine = value; }
        public int Tauxhoraire { get => _tauxhoraire; set => _tauxhoraire = value; }
        #endregion

    }
}
