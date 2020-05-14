using HealthClinic.Entiteti;
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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlPacijenti.xaml
    /// </summary>
    public partial class UserControlPacijenti : UserControl
    {
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }

        public UserControlPacijenti()
        {
            InitializeComponent();
            this.DataContext = this;
            Pacijenti = UserControlPocetna.Pacijenti;
        }
    }
}
