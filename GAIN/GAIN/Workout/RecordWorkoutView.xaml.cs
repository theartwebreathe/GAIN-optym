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
    /// Interaction logic for RecordWorkoutView.xaml
    /// </summary>
    public partial class RecordWorkoutView : UserControl
    {
        private readonly RecordWorkoutViewModel _viewModel;
        public RecordWorkoutView()
        {
            InitializeComponent();
            _viewModel = new RecordWorkoutViewModel();
            DataContext = _viewModel;
        }

        public static readonly RoutedEvent BackButtonPressedEvent = EventManager.RegisterRoutedEvent(
            "BackButtonPressed",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(RecordWorkoutView));

        public event RoutedEventHandler BackButtonPressed
        {
            add { AddHandler(BackButtonPressedEvent, value); }
            remove { RemoveHandler(BackButtonPressedEvent, value); }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(RecordWorkoutView.BackButtonPressedEvent));
        }
    }
}
