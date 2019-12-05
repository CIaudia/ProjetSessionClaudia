using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSession
{
   public class ObservableObject: INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(value));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
