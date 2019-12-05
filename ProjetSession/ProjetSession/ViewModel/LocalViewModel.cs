using Gestionnaire;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSession
{
    class LocalViewModel: INotifyPropertyChanged
    {

        private LocalModel _local;


        public LocalModel Local()
        {
            return _local;
        }
        private ObservableCollection<LocalModel> _locals;

        public ObservableCollection<LocalModel> local
        {
            get
            {
                return _locals;
            }
            set
            {
                _locals = value;
                NotifyPropertyChanged("Local");
            }
        }


        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public LocalViewModel()
        {

        }



        public event PropertyChangedEventHandler PropertyChanged;


    }
}
