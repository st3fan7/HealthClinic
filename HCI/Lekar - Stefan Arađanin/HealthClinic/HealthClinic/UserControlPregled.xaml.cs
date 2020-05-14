                                                                                                                                         
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HealthClinic.Entiteti;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlPregled.xaml
    /// </summary>
    public partial class UserControlPregled : UserControl
    {
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }

        public UserControlPregled()
        {
            InitializeComponent();
            this.DataContext = this;
            Pacijenti = UserControlPocetna.Pacijenti;
        }

        private void ListViewPregledPacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridPregled.Visibility = Visibility.Visible;
        }

        private void ButtonDijanoza_Click(object sender, RoutedEventArgs e)
        {
            DijalogIzmenaDijagnoze dijalogDijagnoza = new DijalogIzmenaDijagnoze();
            dijalogDijagnoza.ShowDialog();
        }
    }
}
