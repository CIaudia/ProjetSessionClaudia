using Gestionnaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProjetSession
{
    public class PersonneViewModel: Personne
    {
        private Personne _personne;
        public Personne Personne()
        {
            _personne.Nom = "";
            _personne.Prenom = "";
           
            
            return _personne;
        }
        private ObservableCollection<Personne> _personnes;

        public ObservableCollection<Personne> Personnes
        {
            get
            {
                return _personnes;
            }
            set
            {
                _personnes = value;
               // NotifyPropertyChanged("Personnes");
            }
        }
        
        public PersonneViewModel()
        {
         
        }

       // public event PropertyChangedEventHandler PropertyChanged;
    }

  
}
