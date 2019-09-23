using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Workout
{
    class BuildCustomWorkoutViewModel : ViewModelBase
    {
        private ObservableCollection<MajorMuscleGroup> selectedMuscleGroups = new ObservableCollection<MajorMuscleGroup>();
        public ObservableCollection<MajorMuscleGroup> SelectedMuscleGroups
        {
            get { return selectedMuscleGroups; }
            set
            {
                selectedMuscleGroups = value;
                OnPropertyChange("SelectedMuscleGroups");
            }
        }
        public BuildCustomWorkoutViewModel()
        {
            
        }
    }
}
