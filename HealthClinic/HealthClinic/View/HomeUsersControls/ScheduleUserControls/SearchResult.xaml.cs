using HealthClinic.Model;
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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : UserControl
    {
        List<Oporavak> oporavak = new List<Oporavak>();
        public SearchResult(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
        }
        private void fillData()
        {
            oporavak.Add(new Oporavak() { Prijem = "03/04/2020", Odjava = "13/04/2020", Sala = "O1", Pacijent = "Igor Petrić", Status = "Zauzet" });
            oporavak.Add(new Oporavak() { Prijem = "01/04/2020", Odjava = null, Sala = "O1", Pacijent = "Jelena Jelić", Status = "Zauzet" });
            oporavak.Add(new Oporavak() { Prijem = "02/04/2020", Odjava = null, Sala = "O1", Pacijent = null, Status = "Slobodan" });
            dgTerms.ItemsSource = oporavak;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Home();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridRecoveryRooms.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Patient();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Settings();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Report();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void btnAccommodate_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new PatientValidationForRecovery(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new DataModificationInRecoveryRoom(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Oporavak oporavak = dgTerms.SelectedItem as Oporavak;
            fillRecoveryWithDataFromSelectedRow(oporavak);
            if (oporavak.Status.Equals("Slobodan"))
            {
                btnAccommodate.IsEnabled = true;
                btnChange.IsEnabled = false;
            }
            else if (oporavak.Status.Equals("Zauzet"))
            {
                btnAccommodate.IsEnabled = false;
                btnChange.IsEnabled = true;
            }
        }

        private static void fillRecoveryWithDataFromSelectedRow(Oporavak oporavak)
        {
            oporavak.Prijem = Convert.ToString(oporavak.Prijem);
            oporavak.Odjava = Convert.ToString(oporavak.Odjava);
            oporavak.Pacijent = Convert.ToString(oporavak.Pacijent);
            oporavak.Sala = Convert.ToString(oporavak.Sala);
            oporavak.Status = Convert.ToString(oporavak.Status);
        }
    }
}
