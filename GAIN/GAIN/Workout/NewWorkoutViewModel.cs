using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace GAIN.Workout
{
    class NewWorkoutViewModel : ViewModelBase
    {
        public DelegateCommand<object> GetSelectedItemsCommand { get; private set; }
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
        private UserWorkout selectedUserWorkout = new UserWorkout();
        public UserWorkout SelectedUserWorkout
        {
            get { return selectedUserWorkout; }
            set
            {
                selectedUserWorkout = value;
                OnPropertyChange("SelectedUserWorkout");
            }
        }
        public NewWorkoutViewModel()
        {
            GetSelectedItemsCommand = new DelegateCommand<object>(GetSelectedItems);
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Strength 1",
                    Sets = 4,
                    Exercises = new ObservableCollection<Exercise>() {
                        new Exercise() {
                            Description = "Low Bar Squat",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 100,
                            PreviousWeight = 100,
                        },
                        new Exercise() {
                            Description = "High Bar Squat",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 100,
                            PreviousWeight = 100,
                        },
                        new Exercise() {
                            Description = "Safety Bar Squat",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 100,
                            PreviousWeight = 100,
                        },
                        new Exercise() {
                            Description = "Bulgarian Squat",
                            CurrentReps = 8,
                            PreviousReps = 8,
                            CurrentWeight = 100,
                            PreviousWeight = 100,
                        },
                        new Exercise() {
                            Description = "Lunges",
                            CurrentReps = 10,
                            PreviousReps = 10,
                        },
                    },
                }
            );
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Strength 2",
                    Sets = 2,
                    Exercises = new ObservableCollection<Exercise>() {
                            new Exercise() {
                                Description = "Low Bar Squat",
                                CurrentReps = 5,
                                PreviousReps = 5,
                                CurrentWeight = 100,
                                PreviousWeight = 100,
                            },
                            new Exercise() {
                                Description = "Bulgarian Squat",
                                CurrentReps = 8,
                                PreviousReps = 8,
                                CurrentWeight = 100,
                                PreviousWeight = 100,
                            },
                            new Exercise() {
                                Description = "Lunges",
                                CurrentReps = 10,
                                PreviousReps = 10,
                            },
                        },
                }
            );
            userWorkouts.Add(new UserWorkout
                {
                    Description = "Ultimate Calves",
                    Sets = 3,
                    Exercises = new ObservableCollection<Exercise>() {
                        new Exercise() {
                            Description = "Leg Press Calf Raises",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 300,
                            PreviousWeight = 300,
                        },
                        new Exercise() {
                            Description = "Standing Calf Raises",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 200,
                            PreviousWeight = 200,
                        },
                        new Exercise() {
                            Description = "Squat Raises",
                            CurrentReps = 5,
                            PreviousReps = 5,
                            CurrentWeight = 230,
                            PreviousWeight = 230,
                        },
                    },
            }
            );

            majorMuscleGroups.Add(new MajorMuscleGroup {
                Description = "Quadriceps",
                Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Low Bar Squat",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "High Bar Squat",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Safety Bar Squat",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Bulgarian Squat",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Lunges",
                        CurrentReps = 10,
                        PreviousReps = 10,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Hamstrings",
                Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Stiff Leg Deadlift",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 230,
                        PreviousWeight = 230,
                    },
                    new Exercise() {
                        Description = "Romanian Deadlift",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 250,
                        PreviousWeight = 250,
                    },
                    new Exercise() {
                        Description = "Low Bar Squat",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Lunges",
                        CurrentReps = 10,
                        PreviousReps = 10,
                    },
                    new Exercise() {
                        Description = "Glute/Ham Raise",
                        CurrentReps = 10,
                        PreviousReps = 10,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Calves",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Leg Press Calf Raises",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Standing Calf Raises",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Squat Raises",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 230,
                        PreviousWeight = 230,
                    },
                    new Exercise() {
                        Description = "Seated Calf Raises",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Reverse Claf Raises",
                        CurrentReps = 10,
                        PreviousReps = 10,
                        CurrentWeight = 130,
                        PreviousWeight = 130,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Chest",
                Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Push Ups",
                        CurrentReps = 15,
                        PreviousReps = 15,
                    },
                    new Exercise() {
                        Description = "Dips",
                        CurrentReps = 8,
                        PreviousReps = 8,
                    },
                    new Exercise() {
                        Description = "Bench Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Pullovers",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Back",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Deadlifts",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 350,
                        PreviousWeight = 350,
                    },
                    new Exercise() {
                        Description = "Rows",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Chin Ups",
                        CurrentReps = 8,
                        PreviousReps = 8,
                    },
                    new Exercise() {
                        Description = "Pull Ups",
                        CurrentReps = 8,
                        PreviousReps = 8,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Shoulders",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Handstand Push Ups",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Overhead Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Single Arm Overhead Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "High Incline Bench Press",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Triceps",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Dips",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Bench Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Overhead Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Push Ups",
                        CurrentReps = 15,
                        PreviousReps = 15,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Biceps",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Chin Ups",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Pull Ups",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Rows",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Forearms",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Deadlifts",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Rows",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Chin Ups",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Holding Heavy Weight",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Trapezius",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Deadlifts",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Power Shrug",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 100,
                        PreviousWeight = 100,
                    },
                    new Exercise() {
                        Description = "Overhead Press",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Rack Pulls",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Chin Ups",
                        CurrentReps = 10,
                        PreviousReps = 10,
                    },
                }
            }
            );
            majorMuscleGroups.Add(new MajorMuscleGroup
                {
                    Description = "Abs",
                    Exercises = new ObservableCollection<Exercise>() {
                    new Exercise() {
                        Description = "Squats",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Deadlifts",
                        CurrentReps = 5,
                        PreviousReps = 5,
                        CurrentWeight = 300,
                        PreviousWeight = 300,
                    },
                    new Exercise() {
                        Description = "Chin Ups",
                        CurrentReps = 5,
                        PreviousReps = 5,
                    },
                    new Exercise() {
                        Description = "Overhead Press",
                        CurrentReps = 8,
                        PreviousReps = 8,
                        CurrentWeight = 200,
                        PreviousWeight = 200,
                    },
                    new Exercise() {
                        Description = "Push Ups",
                        CurrentReps = 15,
                        PreviousReps = 15,
                    },
                }
            }
            );
        }

        public void SetSelectedWorkout(UserWorkout userWorkout)
        {
            SelectedUserWorkout = userWorkout;
        }

        private void GetSelectedItems(object obj)
        {
            SelectedMuscleGroups.Clear();
            System.Collections.IList items = (System.Collections.IList)obj;
            var collection = items.Cast<MajorMuscleGroup>();
            foreach (var mgroup in collection) {
                SelectedMuscleGroups.Add(mgroup);
            }
        }
    }
}
