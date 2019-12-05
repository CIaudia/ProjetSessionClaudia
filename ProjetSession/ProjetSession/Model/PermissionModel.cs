using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public  class PermissionModel: INotifyPropertyChanged
    {
        private int _plageDebut;
        private int _plageFin;

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = Id;
                OnPropertyChanged(Id.ToString());
            }
        }

     
        public int Id_personne
        {
            get
            {
                return Id_personne;
            }
            set
            {
                Id_personne = Id_personne;
                OnPropertyChanged(Id_personne.ToString());
            }
        }
        public int Id_local
        {
            get
            {
                return Id_local;
            }
            set
            {
                Id_local = Id_local;
                OnPropertyChanged(Id_local.ToString());
            }
        }
        public string Personne
        {
            get
            {
                return Personne;
            }
            set
            {
                Personne = Personne;
                OnPropertyChanged(Personne);
            }
        }

        public string NumeroLocal
        {
            get
            {
                return NumeroLocal;
            }
            set
            {
                NumeroLocal = NumeroLocal;
                OnPropertyChanged(NumeroLocal);
            }
        }

        public string PlageDebut
        {
            get
            {
                return _plageDebut.ToString();
            }
            set
            {
                _plageDebut = int.Parse(value);
                OnPropertyChanged(_plageDebut.ToString());
            }
        }

        public string PlageFin
        {
            get
            {
                return _plageFin.ToString();
            }
            set
            {
                _plageFin = int.Parse(value);
                OnPropertyChanged(_plageFin.ToString());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public bool inRange(DateTime time)
        {
            int currentTime = int.Parse(time.Hour.ToString() + time.Minute.ToString());

            return currentTime >= _plageDebut && currentTime <= _plageFin;
        }

        public bool inRange(string time)
        {

            int currentTime = int.Parse(time);

            return currentTime >= _plageDebut && currentTime <= _plageFin;
        }

    }
}
