using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GAIN.Dashboard
{
    sealed class DashboardViewModel : ViewModelBase
    {
        private ObservableCollection<Day> daysOfWeek = new ObservableCollection<Day>();
        public ObservableCollection<Day> DaysOfWeek
        {
            get { return daysOfWeek; }
            set
            {
                daysOfWeek = value;
                OnPropertyChange("DaysOfWeek");
            }
        }

        private ObservableCollection<HistoricalWorkout> historicalWorkouts = new ObservableCollection<HistoricalWorkout>();
        public ObservableCollection<HistoricalWorkout> HistoricalWorkouts
        {
            get { return historicalWorkouts; }
            set
            {
                historicalWorkouts = value;
                OnPropertyChange("HistoricalWorkouts");
            }
        }

        public DashboardViewModel()
        {
            daysOfWeek.Add(new Day
                {
                    Code = "S",
                    IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Sunday,
                    IsTrophy = true,
                }
            );
            daysOfWeek.Add(new Day
            {
                Code = "M",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Monday,
                IsTrophy = true,
            }
            );
            daysOfWeek.Add(new Day
            {
                Code = "T",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Tuesday,
                IsDash = true,
            }
            ); ;
            daysOfWeek.Add(new Day
            {
                Code = "W",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Wednesday,
                IsCheck = true,
            }
            );
            daysOfWeek.Add(new Day
            {
                Code = "T",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Thursday,
                IsTrophy = true,
            }
            );
            daysOfWeek.Add(new Day
            {
                Code = "F",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Friday,
            }
            );
            daysOfWeek.Add(new Day
            {
                Code = "S",
                IsToday = DateTime.Now.DayOfWeek == DayOfWeek.Saturday,
            }
            );

            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 1",
                Date = "9/21/19",
                Delta = "3%",
                DeltaDescription = "up",
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 1",
                Date = "9/20/19",
                Delta = "1%",
                DeltaDescription = "up",
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Custom: Chest",
                Date = "9/19/19",
                IsCustom = true,
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 2",
                Date = "9/18/19",
                Delta = "3%",
                DeltaDescription = "up",
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 1",
                Date = "9/16/19",
                Delta = "--",
                DeltaDescription = "neutral",
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Custom: Legs",
                Date = "9/15/19",
                Delta = "--",
                IsCustom = true,
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 1",
                Date = "9/14/19",
                Delta = "3%",
            });
            historicalWorkouts.Add(new HistoricalWorkout
            {
                Description = "Strength 1",
                Date = "9/12/19",
                Delta = "3%",
            });
        }
    }
}
