using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Workout
{
    class UserWorkout : ViewModelBase
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
        ObservableCollection<Exercise> exercises = new ObservableCollection<Exercise>();
        public ObservableCollection<Exercise> Exercises
        {
            get { return exercises; }
            set
            {
                exercises = value;
                OnPropertyChange("Exercises");
            }
        }
        private int sets;
        public int Sets
        {
            get { return sets; }
            set
            {
                sets = value;
                OnPropertyChange("Sets");
            }
        }

    }
}
