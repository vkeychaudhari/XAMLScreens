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

namespace XAMLScreens.Usercontrols
{
    /// <summary>
    /// Interaction logic for ListaView.xaml
    /// </summary>
    public partial class ListaView : UserControl
    {
        public ObservableCollection<Pendientes> PendientesColl { get; set; }
        public ObservableCollection<Agenda> AgendaRecords { get; set; }
        public ListaView()
        {
            InitializeComponent();
            LoadColl();
            LoadCollAgendaRecord();
            dataGridPendientes.ItemsSource = PendientesColl;
            lbAgenda.ItemsSource = AgendaRecords;

        }

        private void LoadCollAgendaRecord()
        {
            AgendaRecords = new ObservableCollection<Agenda>();
            AgendaRecords.Add(new Agenda { Header = "MANANA", SubAgendaRecords = GetSubAgendaCollection() });
            AgendaRecords.Add(new Agenda { Header = "TARDE", SubAgendaRecords = GetSubAgendaCollection2() });
        }

        public ObservableCollection<Demo> GetSubAgendaCollection()
        {
            ObservableCollection<Demo> temp = new ObservableCollection<Demo>();
            temp.Add(new Demo { Estudio = "Tiroides", Pacientes = "5", Actividad = "35" });
            temp.Add(new Demo { Estudio = "Osea", Pacientes = "5", Actividad = "35" });
            temp.Add(new Demo { Estudio = "G-Centinela", Pacientes = "5", Actividad = "35" });
            temp.Add(new Demo { Estudio = "Tiroides", Pacientes = "5", Actividad = "35" });
            return temp;
        }

        public ObservableCollection<Demo> GetSubAgendaCollection2()
        {
            ObservableCollection<Demo> temp = new ObservableCollection<Demo>();
            temp.Add(new Demo { Estudio = "Renograma", Pacientes = "5", Actividad = "35" });
            temp.Add(new Demo { Estudio = "Octreoscon", Pacientes = "5", Actividad = "35" });
            temp.Add(new Demo { Estudio = "Osea", Pacientes = "5", Actividad = "35" });
            return temp;
        }

        private void LoadColl()
        {
            PendientesColl = new ObservableCollection<Pendientes>();
            PendientesColl.Add(new Pendientes { Estado = "1-Pendiente", NHC = "00000", Nombre = "Paciente", Estudio = "Trioides", Stock = "5", EDAD = "15", PESO = "50", Unidad = "MCI", HoraCita = "08.30" });
            PendientesColl.Add(new Pendientes { Estado = "1-Pendiente", NHC = "00000", Nombre = "Paciente", Estudio = "Trioides", Stock = "25", EDAD = "15", PESO = "50", Unidad = "MCI", HoraCita = "08.30" });
            PendientesColl.Add(new Pendientes { Estado = "1-Pendiente", NHC = "00000", Nombre = "Paciente", Estudio = "Trioides", Stock = "10", EDAD = "15", PESO = "50", Unidad = "MCI", HoraCita = "08.30" });
            PendientesColl.Add(new Pendientes { Estado = "1-Pendiente", NHC = "00000", Nombre = "Paciente", Estudio = "Trioides", Stock = "123", EDAD = "15", PESO = "50", Unidad = "MCI", HoraCita = "08.30" });
        }


        public class Pendientes
        {

            public string Estado { get; set; }

            public string NHC { get; set; }

            public string Nombre { get; set; }

            public string Estudio { get; set; }

            public string Producto { get; set; }

            public string Stock { get; set; }

            public string EDAD { get; set; }

            public string PESO { get; set; }

            public string ACT { get; set; }

            public string Unidad { get; set; }

            public string HoraCita { get; set; }

            public string Acciones { get; set; }
        }

        public class Agenda
        {
            public string Header { get; set; }

            public ObservableCollection<Demo> SubAgendaRecords { get; set; }

        }

        public class Demo
        {
            public string Estudio { get; set; }
            public string Pacientes { get; set; }
            public string Actividad { get; set; }
        }

        private void CbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            if (text == "Todos" && spTodasDate != null)
            {
                gridViales.Visibility = Visibility.Visible;
                spTodasDate.Visibility = Visibility.Visible;
                spPendientesDate.Visibility = Visibility.Collapsed;
                btnVal.Visibility = Visibility.Collapsed;
                btnMar.Visibility = Visibility.Visible;
                gridAgenda.Visibility = Visibility.Visible;
                columnStock.Visibility = Visibility.Collapsed;
                border.Margin = new Thickness(0);
            }
            else if (text == "PENDIENTES" && spTodasDate != null)
            {
                gridViales.Visibility = Visibility.Collapsed;
                spTodasDate.Visibility = Visibility.Collapsed;
                spPendientesDate.Visibility = Visibility.Visible;
                btnVal.Visibility = Visibility.Visible;
                btnMar.Visibility = Visibility.Collapsed;
                gridAgenda.Visibility = Visibility.Collapsed;
                columnStock.Visibility = Visibility.Visible;
                border.Margin = new Thickness(0, 30, 0, 0);
            }
        }
    }
}
