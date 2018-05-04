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
using Trabajo.COMMON.Interfaces;
using Trabajo.COMMON.Entidades;
using Trabajo.DAL;
namespace GraficasWPF
{
    /// <summary>
    /// Lógica de interacción para Tablas.xaml
    /// </summary>
    public partial class Tablas : Window
    {
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorMarcadores manejadorMarcadores;
        public Tablas()
        {
            InitializeComponent();
            manejadorDeporte = new ManejadorDeporte(new RepositorioGenerico<Deporte>());
            manejadorEquipo = new ManejadorEquipo(new RepositorioGenerico<Equipo>());
            manejadorMarcadores = new ManejadorMarcadores(new RepositorioGenerico<Marcadores>());
            ActualizarComboDeporte();
        }
        private void ActualizarComboDeporte()
        {
            cmbDeporte.ItemsSource = null;
            cmbDeporte.ItemsSource = manejadorDeporte.Listar;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarTablaMarcadores();
            EncontrarMarcadorFinal();

        }

        private void ActualizarTablaMarcadores()
        {
            string d = cmbEquipo.Text;
            manejadorMarcadores.Equipo(d);
            //cmbEquipo.ItemsSource = null;
            dtgTabla.ItemsSource = manejadorMarcadores.Equipo(d);
            //dtgTabla.ItemsSource = null;
            //dtgTabla.ItemsSource = manejadorMarcadores.Listar;
        }
        string[] MarcadorFinal = new string[50];
        int mar;
        private void EncontrarMarcadorFinal()
        {
            string d = cmbEquipo.Text;
            manejadorMarcadores.MarcadorF(d);
            for (int i= 0; i < manejadorMarcadores.MarcadorF(d).Count; i++)
            {
                MarcadorFinal[i] = Convert.ToString(manejadorMarcadores.MarcadorF(d)[i]);
              // mar = mar + int.Parse( MarcadorFinal[i]);
            }
           
            MarFinal.Text = MarcadorFinal[2];
        }

        private void AceptarEquipo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AceptarDeporte_Click(object sender, RoutedEventArgs e)
        {
            string d = cmbDeporte.Text;
            manejadorEquipo.Deporte(d);
            cmbEquipo.ItemsSource = null;
            cmbEquipo.ItemsSource = manejadorEquipo.Deporte(d);
        }
    }
}
