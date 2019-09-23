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
    public partial class BuildCustomWorkoutView : UserControl
    {
        private readonly BuildCustomWorkoutViewModel _viewModel;
        public BuildCustomWorkoutView()
        {
            InitializeComponent();
            _viewModel = new BuildCustomWorkoutViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        public static readonly RoutedEvent BackButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "BackButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(BuildCustomWorkoutView));

        public event RoutedEventHandler BackButtonPressed
        {
            add { AddHandler(BackButtonPressedEvent, value); }
            remove { RemoveHandler(BackButtonPressedEvent, value); }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(BuildCustomWorkoutView.BackButtonPressedEvent));
        }

        public static readonly RoutedEvent StartButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "StartButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(BuildCustomWorkoutView));

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
