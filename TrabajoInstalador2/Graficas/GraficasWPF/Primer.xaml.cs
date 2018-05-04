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
using System.Windows.Shapes;
using Trabajo;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;
using Trabajo.DAL;

namespace GraficasWPF
{
    /// <summary>
    /// Lógica de interacción para Primer.xaml
    /// </summary>
    public partial class Primer : Window
    {
        enum accion
        {
            Nuevo
        }
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorMarcadores manejadorMarcadores;
        IManejadorDeportesPunta manejadorDPunta;
        accion accionMarcadores;
        public Primer()
        {
            InitializeComponent();
            manejadorDeporte = new ManejadorDeporte(new RepositorioGenerico<Deporte>());
            manejadorEquipo = new ManejadorEquipo(new RepositorioGenerico<Equipo>());
            manejadorMarcadores = new ManejadorMarcadores(new RepositorioGenerico<Marcadores>());
            manejadorDPunta = new ManejadorDeportePunta(new RepositorioGenerico<DeportePunta>());
        }
        private void TablaResultado_Click(object sender, RoutedEventArgs e)
        {
            Tablas v = new Tablas();
            v.Show();

        }

        private void GraficaResultado_Click(object sender, RoutedEventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
        }

        private void btnTablaResultadoGeberal_Click(object sender, RoutedEventArgs e)
        {
            TablaResultadosGeneral v = new TablaResultadosGeneral();
            v.Show();

        }
    }
}
