using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GAIN.Workout
{
    class NewWorkoutViewModel : ViewModelBase
    {
        private ObservableCollection<UserWorkout> userWorkouts = new ObservableCollection<UserWorkout>();
        public ObservableCollection<UserWorkout> UserWorkouts
        {
            get { return userWorkouts; }
            set
            {
                userWorkouts = value;
                OnPropertyChange("UserWorkouts");
            }
        }
        private ObservableCollection<MajorMuscleGroup> majorMuscleGroups = new ObservableCollection<MajorMuscleGroup>();
        public ObservableCollection<MajorMuscleGroup> MajorMuscleGroups
        {
            get { return majorMuscleGroups; }
            set
            {
                majorMuscleGroups = value;
                OnPropertyChange("MajorMuscleGroups");
            }
        }
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
        public NewWorkoutViewModel()
        {
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Strength 1",
                    Details = "Bench Press, 2 Super Sets (Legs)",
                }
            );
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Strength 2",
                    Details = "Bench Press, 3 Super Sets (Upper-body)",
                }
            );
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Ultimate Abs",
                    Details = "Crunches, Ab Wheel Rollout",
                }
            );

            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Quadriceps",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Hamstrings",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Calves",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Chest",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Back",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Shoulders",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Triceps",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Biceps",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Forearms",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Trapezius",
                }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Abs",
                }
            );
        }
    }
}
