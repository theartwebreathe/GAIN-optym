using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GAIN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GainMainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new GainMainViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
            
        }

        private void DashboardView_NewWorkoutButtonPressed(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = 2;
        }

        private void NewWorkoutView_BackButtonPressed(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = transitioner.SelectedIndex - 1;
        }

        private void BuildCustomWorkoutView_BackButtonPressed(object sender, RoutedEventArgs e)
        {
            transitioner.SelectedIndex = transitioner.SelectedIndex - 1;
        }

        private void NewWorkoutView_CreateCustomWorkoutButtonPressed(object sender, RoutedEventArgs e)
        {
            ((Workout.BuildCustomWorkoutViewModel)buildCustomWorkoutView.DataContext).SelectedMuscleGroups.Clear();
            ((Workout.BuildCustomWorkoutViewModel)buildCustomWorkoutView.DataContext).SelectedMuscleGroups = ((Workout.NewWorkoutViewModel)newWorkoutView.DataContext).SelectedMuscleGroups;
            transitioner.SelectedIndex = transitioner.SelectedIndex + 1;
        }
    }
}
