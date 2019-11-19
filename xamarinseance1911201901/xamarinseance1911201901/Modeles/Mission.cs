using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace xamarinseance1911201901.Modeles
{
    class Mission
    {
        #region Attribut

        public static ArrayList CollClasseMission = new ArrayList();

        private string _nom;
        private string _description;
        private int _nbHeurePrevus;
        private Dictionary<DateTime, int> _releveHoraire;
        private Intervenant _executant;

        #endregion
        #region Constructeur
        public Mission(string nom, string description, int nbHeurePrevus, Intervenant executant)
        {
            Nom = nom;
            Description = description;
            NbHeurePrevus = nbHeurePrevus;

            Mission.CollClasseMission.Add(this);
            this.ReleveHoraire = new Dictionary<DateTime, int>();
            this.Executant = executant;
        }
        #endregion
        #region Getter setter



        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public int NbHeurePrevus { get => _nbHeurePrevus; set => _nbHeurePrevus = value; }
        public Dictionary<DateTime, int> ReleveHoraire { get => _releveHoraire; set => _releveHoraire = value; }
        public Intervenant Executant { get => _executant; set => _executant = value; }
        #endregion

        #region Methode

        public void AjoutReleve(DateTime jour, int nbHeures)
        {
            this.ReleveHoraire.Add(jour, nbHeures);
        }

        public int nbHeuresEffectuées()
        {
            int resultat = 0;

            foreach (KeyValuePair<DateTime, int> pair in this.ReleveHoraire)
            {
                resultat += pair.Value;
            }

            return resultat;
        }

        #endregion
    }
}
