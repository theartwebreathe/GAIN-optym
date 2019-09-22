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

namespace GAIN.Dashboard
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : UserControl
    {
        private readonly DashboardViewModel _viewModel;
        public DashboardView()
        {
            InitializeComponent();
            _viewModel = new DashboardViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        public static readonly RoutedEvent NewWorkoutButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "NewWorkoutButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(DashboardView));

        public event RoutedEventHandler NewWorkoutButtonPressed
        {
            add { AddHandler(NewWorkoutButtonPressedEvent, value); }
            remove { RemoveHandler(NewWorkoutButtonPressedEvent, value); }
        }

        private void ButtonNewWorkout_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(DashboardView.NewWorkoutButtonPressedEvent));
        }
    }
}
