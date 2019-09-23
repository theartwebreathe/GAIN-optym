using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace GAIN.Workout
{
    class BuildCustomWorkoutViewModel : ViewModelBase
    {
        public DelegateCommand GetSelectedItemsCommand { get; private set; }
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

        private ObservableCollection<Exercise> selectedExercises = new ObservableCollection<Exercise>();
        public ObservableCollection<Exercise> SelectedExercises
        {
            get { return selectedExercises; }
            set
            {
                selectedExercises = value;
                OnPropertyChange("SelectedExercises");
            }
        }

        public BuildCustomWorkoutViewModel()
        {
            GetSelectedItemsCommand = new DelegateCommand(GetSelectedItems);
        }

        private void GetSelectedItems()
        {
            foreach (var muscleGroup in selectedMuscleGroups) {
                foreach (var exercise in muscleGroup.Exercises) { 
                    if (exercise.IsChecked) {
                        selectedExercises.Add(exercise);
                    }
                }
            }
        }
    }
}
