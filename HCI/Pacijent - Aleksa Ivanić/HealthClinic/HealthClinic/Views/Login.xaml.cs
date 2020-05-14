using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HealthClinic.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Login()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginGrid.Children.Clear();
            UserControl usc = new Home();
            LoginGrid.Children.Add(usc);
        }


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private double test1;
        
        public double Test1
        {
            get
            {
                return test1;
            }
            set
            {
                if (value != test1)
                {
                    test1 = value;
                    OnPropertyChanged("Test1");
                }
            }
        }

    }
}
