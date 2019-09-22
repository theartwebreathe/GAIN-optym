using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Dashboard
{
    sealed class DashboardViewModel : ViewModelBase
    {
        private string something;
        public string Something
        {
            get { return something; }
            set
            {
                something = value;
                OnPropertyChange("Something");
            }
        }

        public DashboardViewModel()
        {

        }
    }
}
