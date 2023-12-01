using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SEMANA11.ViewModel
{
    public class OperacionesViewModel : ViewModelBase
    {

        int Title;
        public int Title
        {
            get { return Title; }
            set
            {
                if (Title != value)
                {
                    Title = value;
                    OnPropertyChanged();
                }
            }
        }

        
    }
}