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
    public class PermissionViewModel : INotifyPropertyChanged
    {

        private PermissionModel _permission;


        public PermissionModel Permission => _permission;
       
        private ObservableCollection<PermissionModel> _permissions;

        public ObservableCollection<PermissionModel> Permissions
        {
            get
            {
                return _permissions;
            }
            set
            {
                _permissions = value;
                NotifyPropertyChanged("Permission");
            }
        }

    


        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public PermissionViewModel()
        {

        }




        public event PropertyChangedEventHandler PropertyChanged;
    
    
    }
}
