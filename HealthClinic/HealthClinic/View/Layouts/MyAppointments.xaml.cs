using Controller.ExaminationSurgeryControlers;
using HealthClinic.View.Converter;
using HealthClinic.View.Model;
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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for MyAppointments.xaml
    /// </summary>
    public partial class MyAppointments : UserControl
    {
        MedicalExaminationController medicalExaminationController;
        IEnumerable<MedicalExamination> medicalExaminationsFromFile;

        private int colNum = 0;
        public ObservableCollection<MedicalExaminationView> MedicalExaminations { get; set; }


        public MyAppointments()
        {
            InitializeComponent();
            this.DataContext = this;
            MedicalExaminations = new ObservableCollection<MedicalExaminationView>();


            var app = Application.Current as App;
            medicalExaminationController = app.MedicalExaminationController;

            medicalExaminationsFromFile = medicalExaminationController.GetAllEntities();

            foreach (MedicalExamination m in medicalExaminationsFromFile)
            {
                Console.WriteLine(m.ToDateTime);
                MedicalExaminations.Add(MedicalExaminationConverter.ConvertMedicalExaminationToMedicalExaminationView(m));
            }
           
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void CancelMedicalExaminationButton_Click(object sender, RoutedEventArgs e)
        {
            medicalExaminationController.DeleteEntity(findSelectedMedicalExamination());
        }

        private void ReScheduleMedicalExamination_Click(object sender, RoutedEventArgs e)
        {
            medicalExaminationController.DeleteEntity(findSelectedMedicalExamination());

        }

        private MedicalExamination findSelectedMedicalExamination()
        {
            MedicalExaminationView selectedMedicalExamination = (MedicalExaminationView)MyMedicalExaminationsTable.SelectedItem;
            foreach (MedicalExamination medicalExamination in medicalExaminationsFromFile)
                if (medicalExamination.GetId() == selectedMedicalExamination.Id)
                    return medicalExamination;
            return null;
        }
    }
}
