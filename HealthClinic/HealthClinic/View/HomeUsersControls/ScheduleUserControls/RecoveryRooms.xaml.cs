using HealthClinic.View.Dialogues;
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
    /// Interaction logic for RecoveryRooms.xaml
    /// </summary>
    public partial class RecoveryRooms : UserControl
    {
        public static List<String> cmbxItems = new List<String>();
        //private List<Oporavak> trenutniTerminiUSaliZaOporavak = new List<Oporavak>();
        public int counter = 0;
        public RecoveryRooms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            this.DataContext = this;
            counter = 0;
            fillData(DisplayType.date);
            cmbxItems.Clear();
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            
        }

        private void fillData(String date)
        {
            //Console.WriteLine("vratio sam se");
            //trenutniTerminiUSaliZaOporavak.Clear();
            //String sala = "";

            //if (cmbx.SelectedItem == R1)
            //{
            //    sala = "R1";
            //}
            //else
            //{
            //    sala = "R2";
            //}
            //foreach (Oporavak oporavak in Loading.oporavci)
            //{


            //    if (date.Equals(oporavak.Prijem) && sala.Equals(oporavak.Sala))
            //    {
            //        trenutniTerminiUSaliZaOporavak.Add(oporavak);
            //    }
            //}

            //if (trenutniTerminiUSaliZaOporavak.Count == 0)
            //{
            //    // 6 pacijenata po sali
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //    trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
                
            //    foreach (Oporavak o in trenutniTerminiUSaliZaOporavak)
            //    {
            //        Loading.oporavci.Add(o);
            //    }

            //}

            //dgTerms.ItemsSource = trenutniTerminiUSaliZaOporavak;
            //counter += 1;
        }





        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new TypeOfRoom(dateLabel.Content.ToString());
            GridRecoveryRooms.Children.Add(usc);

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
            //Oporavak oporavak = dgTerms.SelectedItem as Oporavak;
            //if (oporavak == null)
            //    return;
            //fillRecoveryWithDataFromSelectedRow(oporavak);

            UserControl usc = new PatientValidationForRecovery(dateLabel.Content.ToString());
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            //Oporavak oporavak = dgTerms.SelectedItem as Oporavak;
            //if (oporavak == null)
            //    return;
            //fillRecoveryWithDataFromSelectedRow(oporavak);

            UserControl usc = new DataModificationInRecoveryRoom(dateLabel.Content.ToString());
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Visibility = Visibility.Visible;
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            btnSearch.Visibility = Visibility.Hidden;
            btnClose.Visibility = Visibility.Visible;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Oporavak oporavak = dgTerms.SelectedItem as Oporavak;
            //if (oporavak == null)
            //    return;
            //fillRecoveryWithDataFromSelectedRow(oporavak);
            //if (oporavak.Status.Equals("Slobodan"))
            //{
            //    btnAccommodate.IsEnabled = true;
            //    btnChange.IsEnabled = false;  
            //}
            //else if (oporavak.Status.Equals("Zauzet"))
            //{
            //    btnAccommodate.IsEnabled = false;
            //    btnChange.IsEnabled = true;
            //}
        //}

        //private static void fillRecoveryWithDataFromSelectedRow(Oporavak oporavak)
        //{
        //    oporavak.Prijem = Convert.ToString(oporavak.Prijem);
        //    oporavak.Odjava = Convert.ToString(oporavak.Odjava);
        //    oporavak.Pacijent = Convert.ToString(oporavak.Pacijent);
        //    oporavak.Sala = Convert.ToString(oporavak.Sala);
        //    oporavak.Status = Convert.ToString(oporavak.Status);
        }

        private void cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            //if (counter < 1)
            //{
            //    counter += 1;
            //}

            //else
            //{
            //    counter += 1;
            //    trenutniTerminiUSaliZaOporavak.Clear();
            //    String sala = "";

            //    if (cmbx.SelectedItem == R1)
            //    {
            //        sala = "R1";
            //    }
            //    else
            //    {
            //        sala = "R2";
            //    }
            //    foreach (Oporavak oporavak in Loading.oporavci)
            //    {


            //        if (DisplayType.date.Equals(oporavak.Prijem) && sala.Equals(oporavak.Sala))
            //        {
            //            trenutniTerminiUSaliZaOporavak.Add(oporavak);
            //        }
            //    }

            //    if (trenutniTerminiUSaliZaOporavak.Count == 0)
            //    {


            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });
            //        trenutniTerminiUSaliZaOporavak.Add(new Oporavak() { Prijem = dateLabel.Content.ToString(), Odjava = "", Sala = sala, Pacijent = "", Status = "Slobodan" });

            //        foreach (Oporavak o in trenutniTerminiUSaliZaOporavak)
            //        {
            //            Loading.oporavci.Add(o);
            //        }

            //    }

            //    dgTerms.ItemsSource = trenutniTerminiUSaliZaOporavak;
                btnChange.IsEnabled = false;
                btnAccommodate.IsEnabled = false;
                dgTerms.UnselectAllCells();

            //}
        }
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //var fill = trenutniTerminiUSaliZaOporavak.Where(termin => termin.Pacijent.ToString().Contains(searchTextBox.Text) || termin.Prijem.ToString().Contains(searchTextBox.Text)
            //            || termin.Odjava.ToString().Contains(searchTextBox.Text) || termin.Sala.ToString().Contains(searchTextBox.Text) || termin.Status.ToString().Contains(searchTextBox.Text));
            //dgTerms.ItemsSource = fill;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Text = "";
           // dgTerms.ItemsSource = trenutniTerminiUSaliZaOporavak;
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }
    }
}
