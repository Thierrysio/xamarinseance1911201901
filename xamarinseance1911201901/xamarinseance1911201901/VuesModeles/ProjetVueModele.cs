using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using xamarinseance1911201901.Modeles;

namespace xamarinseance1911201901.VuesModeles
{
    class ProjetVueModele : INotifyPropertyChanged
    {
        #region Attributs
        private Projet _leProjet;

        #endregion
        #region Constructeurs
        public ProjetVueModele()
        {
            LeProjet = (Projet)Projet.CollClassProjet[0];
        }
        #endregion
        #region Getters/Setters
        public Projet LeProjet
        {
            get
            {
                return _leProjet;
            }
            set
            {
                _leProjet = value;
                OnPropertyChanged(nameof(LeProjet));

            }
        }
        #endregion
        #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
