using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace xamarinseance1911201901.Modeles
{
    class Projet
    {
        #region Atttribut

        public static ArrayList CollClassProjet = new ArrayList();

        private string _nom;
        private DateTime _debut;
        private DateTime _fin;
        private int _prixFactureMO;
        private ArrayList _lesMissions;

        #endregion

        #region Constructeurs

        public Projet(string nom, DateTime debut, DateTime fin, int prixfactureMO)
        {
            this.Nom = nom;
            this.Debut = debut;
            this.Fin = fin;
            this.PrixfactureMO = prixfactureMO;
            Projet.CollClassProjet.Add(this);
            this.LesMissions = new ArrayList();
        }
        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime Debut { get => _debut; set => _debut = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }
        public int PrixfactureMO { get => _prixFactureMO; set => _prixFactureMO = value; }
        public ArrayList LesMissions { get => _lesMissions; set => _lesMissions = value; }
        #endregion

        #region Methodes

        private float cumulCoutMO()
        {
            float resultat = 0.00f;

            foreach (Mission uneMission in this.LesMissions)
            {
                resultat += uneMission.nbHeuresEffectuées() * uneMission.Executant.Tauxhoraire;
            }

            return resultat;
        }

        public float margeBruteCourante()
        {
            return this.PrixfactureMO - this.cumulCoutMO();
        }
        #endregion
    }
}
