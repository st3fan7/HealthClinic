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
    /// Interaction logic for DataAccommodationInRecoveryRoom.xaml
    /// </summary>
    public partial class DataModificationInRecoveryRoom : UserControl
    {
        //Oporavak oporavakKojegMenjam = new Oporavak();
        //private List<Sobe> sobe = new List<Sobe>();
        
        public DataModificationInRecoveryRoom(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            String odDatuma = selectedDate;
            datePickerSchedule.DisplayDateStart = DateTime.Parse(odDatuma);
            textWarning.Visibility = textWarningHidden;
            //oporavakKojegMenjam = oporavak;
            //receptionLabel.Content = oporavak.Prijem;
            //checkoutLabel.Content = oporavak.Odjava;
            //roomLabel.Content = oporavak.Sala;
            //patientLabel.Content = oporavak.Pacijent;

            //List<String> sobeKojimaSePuni = new List<String>();
            //foreach(Sobe s in Loading.sobeZaOporavak)
            //{
            //    sobeKojimaSePuni.Add(s.Soba);
            //}

            //Console.WriteLine("Sobe koje punim, ima ih: " + sobeKojimaSePuni.Count);
            //sobe.Clear();
            //foreach (String r in sobeKojimaSePuni)
            //{
            //    sobe.Add(new Sobe() { Soba = r });
            //}


            //cmbx.ItemsSource = sobe;
            //cmbx.DisplayMemberPath = "Soba";

        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
                

            //foreach (Oporavak o in Loading.oporavci)
            //{
            //    if (o == oporavakKojegMenjam)
            //    {
            //        Console.WriteLine("isti je");
            //        if (datePickerSchedule.Text.Length != 0)
            //        {
            //            Console.WriteLine("razlicito je od 0");
            //            o.Odjava = datePickerSchedule.Text;
            //        }

            //        if (cmbx.Text.Length != 0)
            //        {
            //            o.Sala = cmbx.Text;  
            //        }

            //        (this.Parent as Panel).Children.RemoveRange(1, 6);
            //        return;
            //    }
            //}
               
        }


        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Home();
            GridDataModification.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Schedule();
            GridDataModification.Children.Add(usc);

        }
        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new PatientView();
            GridDataModification.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Settings();
            GridDataModification.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Report();
            GridDataModification.Children.Add(usc);
        }
        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }

    }
}
