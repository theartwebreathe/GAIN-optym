using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GAIN.Workout
{
    /// <summary>
    /// Interaction logic for NewWorkoutView.xaml
    /// </summary>
    public partial class NewWorkoutView : UserControl
    {
        private readonly NewWorkoutViewModel _viewModel;
        public NewWorkoutView()
        {
            InitializeComponent();
            _viewModel = new NewWorkoutViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        public static readonly RoutedEvent CreateCustomWorkoutButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "CreateCustomWorkoutButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(NewWorkoutView));

        public event RoutedEventHandler CreateCustomWorkoutButtonPressed
        {
            add { AddHandler(CreateCustomWorkoutButtonPressedEvent, value); }
            remove { RemoveHandler(CreateCustomWorkoutButtonPressedEvent, value); }
        }

        private void ButtonCreateCustomWorkout_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(NewWorkoutView.CreateCustomWorkoutButtonPressedEvent));
        }

        public static readonly RoutedEvent BackButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "BackButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(NewWorkoutView));

        public event RoutedEventHandler BackButtonPressed
        {
            add { AddHandler(BackButtonPressedEvent, value); }
            remove { RemoveHandler(BackButtonPressedEvent, value); }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(NewWorkoutView.BackButtonPressedEvent));
        }

        public static readonly RoutedEvent StartButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "StartButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(NewWorkoutView));

        public event RoutedEventHandler StartButtonPressed
        {
            add { AddHandler(StartButtonPressedEvent, value); }
            remove { RemoveHandler(StartButtonPressedEvent, value); }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(NewWorkoutView.StartButtonPressedEvent));
        }
    }
}
