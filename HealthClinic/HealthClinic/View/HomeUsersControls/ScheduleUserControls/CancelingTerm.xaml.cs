using Controller;
using Controller.ExaminationSurgeryControlers;
using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.Term;
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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for CancelingTerm.xaml
    /// </summary>
    public partial class CancelingTerm : UserControl
    {
        private readonly MedicalExaminationController medicalExaminationController;
        private readonly SurgeryController surgeryController;

        public static ViewTerm termForCanceling = new ViewTerm();
        public CancelingTerm(string selectedDate, ViewTerm term)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            timeLabel.Content = term.Time;
            roomLabel.Content = term.Room;
            doctorLabel.Content = term.Doctor;
            patientLabel.Content = term.Patient;
            termForCanceling = term;

            var app = Application.Current as App;
            medicalExaminationController = app.MedicalExaminationController;
            surgeryController = app.SurgeryController;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Home();
            GridScheduleTerm.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Schedule();
            GridScheduleTerm.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new PatientView();
            GridScheduleTerm.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Settings();
            GridScheduleTerm.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Report();
            GridScheduleTerm.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {

            if (termForCanceling.Status.Equals("Zauzet"))
            {


                ViewTerm termSearch = new ViewTerm();

                if (termForCanceling.Task.Equals("Pregled"))
                {
                    medicalExaminationController.DeleteEntity(medicalExaminationController.GetEntity(termForCanceling.Id));

                    foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                    {
                        if (viewTerm.Id == termForCanceling.Id)
                        {
                            Console.WriteLine("Nasao");
                            termSearch = viewTerm;
                            break;
                        }
                    }

                    Loading.currentMedicalExaminationTerms.Remove(termSearch);

                    ObservableCollection<ViewTerm> viewTermsFree = new ObservableCollection<ViewTerm>();
                    foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                    {
                        if (viewTerm.Status.Equals("Slobodan"))
                        {
                            viewTermsFree.Add(viewTerm);
                        }
                    }

                    foreach (ViewTerm viewTerm in viewTermsFree)
                    {
                        Loading.currentMedicalExaminationTerms.Remove(viewTerm);
                    }

                    
                }
                else
                {
                    surgeryController.DeleteEntity(surgeryController.GetEntity(termForCanceling.Id));

                    foreach (ViewTerm viewTerm in Loading.currentSurgeryTerms)
                    {
                        if (viewTerm.Id == termForCanceling.Id)
                        {
                            termSearch = viewTerm;
                            break;
                        }
                    }

                    Loading.currentSurgeryTerms.Remove(termSearch);

                    ObservableCollection<ViewTerm> viewTermsFree = new ObservableCollection<ViewTerm>();
                    foreach (ViewTerm viewTerm in Loading.currentSurgeryTerms)
                    {
                        if (viewTerm.Status.Equals("Slobodan"))
                        {
                            viewTermsFree.Add(viewTerm);
                        }
                    }

                    foreach (ViewTerm viewTerm in viewTermsFree)
                    {
                        Loading.currentSurgeryTerms.Remove(viewTerm);
                    }
                }
            }

            GridScheduleTerm.Children.Clear();
            UserControl usc = new SuccessfullyCanceling();
            GridScheduleTerm.Children.Add(usc);

        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        
    }
}
