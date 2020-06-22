using Controller;
using Controller.BlogNotificationControlers;
using Controller.MedicamentControlers;
using Model.DoctorMenager;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using Repository.MedicamentRepository;
using Service.MedicamentService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string MEDICAMNET_FILE = "../../Resources/Data/medicaments.csv";
        private const string ARTICLE_FILE = "../../Resources/Data/article.csv";
        private const string CSV_DELIMITER = ";";

        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public App()
        {
            var medicamentRepository = new MedicamentRepository(
                new CSVStream<Medicament>(MEDICAMNET_FILE, new MedicamentCSVConverter(CSV_DELIMITER)),
                new IntSequencer());

            var medicamentService = new MedicamentService(medicamentRepository);
            

            MedicamentController = new MedicamentController(medicamentService);
            
        }

        public IController<Medicament, int> MedicamentController { get; private set; }
        public IController<Medicament, int> ArticleController { get; private set; }
    }
}
