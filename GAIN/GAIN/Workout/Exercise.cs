using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Workout
{
    class Exercise : ViewModelBase
    {
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChange("Description");
            }
        }
        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChange("IsChecked");
            }
        }
        private int currentReps;
        public int CurrentReps
        {
            get { return currentReps; }
            set
            {
                currentReps = value;
                OnPropertyChange("CurrentReps");
            }
        }
        private int previousReps;
        public int PreviousReps
        {
            get { return previousReps; }
            set
            {
                previousReps = value;
                OnPropertyChange("PreviousReps");
            }
        }
        private int currentWeight;
        public int CurrentWeight
        {
            get { return currentWeight; }
            set
            {
                currentWeight = value;
                OnPropertyChange("CurrentWeight");
            }
        }
        private int previousWeight;
        public int PreviousWeight
        {
            get { return previousWeight; }
            set
            {
                previousWeight = value;
                OnPropertyChange("PreviousWeight");
            }
        }
        private int percentChange;
        public int PercentChange
        {
            get { return percentChange; }
            set
            {
                percentChange = value;
                OnPropertyChange("PercentChange");
            }
        }

    }
}
