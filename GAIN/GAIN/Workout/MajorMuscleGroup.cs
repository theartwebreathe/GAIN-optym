using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Workout
{
    class MajorMuscleGroup
    {
        public string Description { get; set; }
        public bool IsChecked { get; set; }
        public ObservableCollection<Exercise> Exercises { get; set; }
    }
}
