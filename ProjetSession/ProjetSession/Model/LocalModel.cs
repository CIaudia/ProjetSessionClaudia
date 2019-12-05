using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    class LocalModel : INotifyPropertyChanged
    {
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

        public string Numero
        {
            get
            {
                return Numero;
            }
            set
            {
                Numero = Numero;
                OnPropertyChanged(Numero);
            }
        }

      

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = Description;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }    
        }


        public override string ToString()
        {
            return Numero + " : " + Description;
        }
    }
}
