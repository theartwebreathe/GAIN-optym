using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace GAIN.Workout
{
    class RecordWorkoutViewModel : ViewModelBase
    {
        public DelegateCommand<Exercise> IncrementRepsCommand { get; private set; }
        public DelegateCommand<Exercise> DecrementRepsCommand { get; private set; }
        public DelegateCommand<Exercise> IncrementWeightCommand { get; private set; }
        public DelegateCommand<Exercise> DecrementWeightCommand { get; private set; }

        private UserWorkout currentWorkout = new UserWorkout();
        public UserWorkout CurrentWorkout
        {
            get { return currentWorkout; }
            set
            {
                currentWorkout = value;
                OnPropertyChange("CurrentWorkout");
            }
        }

        public RecordWorkoutViewModel()
        {
            IncrementRepsCommand = new DelegateCommand<Exercise>(IncrementReps);
            DecrementRepsCommand = new DelegateCommand<Exercise>(DecrementReps);
            IncrementWeightCommand = new DelegateCommand<Exercise>(IncrementWeight);
            DecrementWeightCommand = new DelegateCommand<Exercise>(DecrementWeight);
        }

        private void DecrementWeight(Exercise exercise)
        {
            exercise.CurrentWeight = exercise.CurrentWeight - 10;
            CalculatePercentChange(exercise);            
        }

        private void IncrementWeight(Exercise exercise)
        {
            exercise.CurrentWeight = exercise.CurrentWeight + 10;
            CalculatePercentChange(exercise);

        }

        private void DecrementReps(Exercise exercise)
        {
            exercise.CurrentReps = exercise.CurrentReps - 1;
            CalculatePercentChange(exercise);
        }

        private void IncrementReps(Exercise exercise)
        {
            exercise.CurrentReps = exercise.CurrentReps + 1;
            CalculatePercentChange(exercise);
        }

        private void CalculatePercentChange(Exercise exercise)
        {
            int weightPercentageChange =
                100 - (int)Math.Round((double)(100 * exercise.CurrentWeight) / exercise.PreviousWeight);
            int repsPercentageChange =
                100 - (int)Math.Round((double)(100 * exercise.CurrentReps) / exercise.PreviousReps);

            var totalPercentageChange = weightPercentageChange + repsPercentageChange;
            exercise.PercentChange = totalPercentageChange * -1;
        }
    }
}
