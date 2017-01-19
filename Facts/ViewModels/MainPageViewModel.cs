using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facts.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        string title;
        string mt;
        string welc;
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
        }

        public DateTime Date
        {
            get { return date;}
            set
            {
                date = value;
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
