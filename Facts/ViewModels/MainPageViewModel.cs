using Caliburn.Micro;
using Facts.Views;
using FactsAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;
using Windows.UI.Popups;

namespace Facts.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        string title;
        string mt;
        string welc;
        string factDay;
        DateTime date;

    
        public MainPageViewModel()
        {
            Titel = "Facts!";
            System.Globalization.DateTimeFormatInfo mfi = new
System.Globalization.DateTimeFormatInfo();
            DateTime dateValue = DateTime.Today;
            Date = dateValue;
          
             Month = dateValue
        .ToString("MMM", CultureInfo.CurrentCulture);
            Welcome =  dateValue.DayOfWeek.ToString() + ", " + mfi.GetMonthName(dateValue.Month).ToString() + " " + dateValue.Year;
            
            GetDayFact();
            Debug.WriteLine(DayFact);
        }

        private DelegateCommand _refreshDay;

        public DelegateCommand RefreshDay
            =>
                _refreshDay ??
                (_refreshDay =
                    new DelegateCommand(() => { GetDayFact(); }, () => true));

     
        public async void GetDayFact()
        {
            DayFact = await GetFacts.GetDateFact(Date.Month.ToString(), Date.Day.ToString());
            factDay = DayFact;
            Debug.WriteLine(factDay);
        }
        public DateTime Date
        {
            get { return date;}
            set
            {
                date = value;
            }
        }

        public string DayFact
        {
            get { return factDay; }
            set
            {
                factDay = value;
            }
        }

        public string Titel
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
        public string Month
        {
            get { return mt; }
            set
            {
                mt = value;
            }
        }
        public string Welcome
        {
            get { return welc; }
            set
            {
                welc = value;
            }
        }
    }

}
