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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for WorkingTimeForDoctors.xaml
    /// </summary>
    public partial class WorkingTimeForDoctors : Window
    {
        public static RoutedCommand helpSchortcut = new RoutedCommand();

        public WorkingTimeForDoctors()
        {
            InitializeComponent();
            helpSchortcut.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(helpSchortcut, ShortKey_Click));
            InputSearch.Focus();
            InputSearch.SelectAll();
        }

        private void Button_Click_IzmeniRadnoVreme(object sender, RoutedEventArgs e)
        {
            var changeWorkingTimeForDoctor = new ChangeWorkinTimeForDoctor();
            changeWorkingTimeForDoctor.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShortKey_Click(object sender, ExecutedRoutedEventArgs e)
        {
            var helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
