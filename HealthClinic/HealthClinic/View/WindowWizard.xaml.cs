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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for WindowWizard.xaml
    /// </summary>
    public partial class WindowWizard : Window
    {
        public WindowWizard()
        {
            InitializeComponent();
        }

        private void ChangeTabItem(int i)
        {
            int newIndex = tabControl.SelectedIndex + i;
            if (newIndex >= tabControl.Items.Count)
            {
                newIndex = 0;
            }
            else if (newIndex < 0)
            {
                newIndex = tabControl.Items.Count - 1;
            }

            tabControl.SelectedIndex = newIndex;
        }
        void previousButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTabItem(-1);
        }
        void nextButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTabItem(1);
        }
        void finishButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTabItem(-tabControl.Items.Count);
        }
    }
}
