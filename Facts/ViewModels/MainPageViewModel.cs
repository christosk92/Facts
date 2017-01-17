using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facts.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        string title;
        public MainPageViewModel()
        {
            Titel = "Facts!";
        }
        public string Titel
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
    }
}
