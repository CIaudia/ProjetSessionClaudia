using ProjetSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
  

    public class Personne : ObservableObject
    {
       

            public Personne()
        {

        }
         /// <summary>
        /// Initialize a new instance of the Personne
        /// </summary>

        public Personne(int id, string codeCarte, string nom, string prenom)
        {
            Id = id;
            CodeCarte = codeCarte;
            Nom = nom;
            Prenom = prenom;
        }
        /// <summary>
        /// Get or Set Information of Personne
        /// </summary>
        public int Id
        {
            get {
                return Id;
            }
            set {
                Id = value;
                OnPropertyChanged(Id.ToString()); }
        }

        public string CodeCarte
        {
            get
            {
                return CodeCarte;
            }
            set
            {
                CodeCarte = CodeCarte;
                OnPropertyChanged(CodeCarte);
            }
        }

        public string Nom
        {
          get
            {
                if (string.IsNullOrEmpty(Nom))
                    return "Unknown";

                return Nom;
            }
          set
            {
                Nom = value;
                OnPropertyChanged("Nom");
            }
        }
        public string Prenom
        {
            get
            {
                if (string.IsNullOrEmpty(Prenom))
                    return "Unknown";

                return Prenom;
            }
            set
            {
                Prenom = value;
                OnPropertyChanged("Prenom");
            }
        }

     
        public override string ToString()
        {
            return Nom + ", " + Prenom;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
