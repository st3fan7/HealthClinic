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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for SurveyQuestionsBase.xaml
    /// </summary>
    public partial class SurveyQuestionsBase : UserControl
    {
        public SurveyQuestionsBase()
        {
            InitializeComponent();
            UserControl usc = new Layouts.SurveyQuestion();
            QuestionsBaseFrame.Content = usc;
        }
    }
}
