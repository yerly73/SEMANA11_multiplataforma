using SEMANA11.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEMANA11.ViewModel
{
    public class TaskViewModel : ViewModelBase
    string title;
    public string Title
    {
        get
        {
            return title;}
        set
        {
            string title = null;
            if ( title != value
            {
                title = value;
                OnPropertyChanged();
            }
        }
    }
    public List<string> MuchosTask { get; set; }

    ObservableCollection<TaskModel> task;
    public ObservableCollection<TaskModel> Tasks
    {
        get { return Task; }
    }
}