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
    /// Lógica de interacción para TablaResultadosGeneral.xaml
    /// </summary>
    public partial class TablaResultadosGeneral : Window
    {
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorMarcadores manejadorMarcadores;
        IManejadorDeportesPunta manejadorDeportesPunta;
        IManejadorNombreGanador manejadorNombreGanador;
        public TablaResultadosGeneral()
        {
            InitializeComponent();
            manejadorDeporte = new ManejadorDeporte(new RepositorioGenerico<Deporte>());
            manejadorEquipo = new ManejadorEquipo(new RepositorioGenerico<Equipo>());
            manejadorMarcadores = new ManejadorMarcadores(new RepositorioGenerico<Marcadores>());
            manejadorDeportesPunta = new ManejadorDeportePunta(new RepositorioGenerico<DeportePunta>());
            manejadorNombreGanador = new ManejadorNombreGanador(new RepositorioGenerico<NombreGanador>());
            ActualizarComboDeporte();
        }
        

        private void ActualizarComboDeporte()
        {
            cmbDeporte.ItemsSource = null;
            cmbDeporte.ItemsSource = manejadorDeporte.Listar;
        }

        private void AceptarDeporte_Click(object sender, RoutedEventArgs e)
        {
            ActualizarTablaMarcadores();
        }

        private void ActualizarTablaMarcadores()
        {
            string d = cmbDeporte.Text;
            //manejadorDeportesPunta.Deporte(d);
            manejadorNombreGanador.Deporte(d);
            //cmbEquipo.ItemsSource = null;
            dtgTabla.ItemsSource = manejadorNombreGanador.Deporte(d);
        }
        string[] Puntaje = new string[50];
        int Max = 3;
        int Med = 2;
        int Min = 1;
        int lugarMax;
        int lugarMed;
        int lugarMin;
        string[] NombreG = new string[50];
        private void btnMostrarGanador_Click(object sender, RoutedEventArgs e)
        {
            string d = cmbDeporte.Text;
            manejadorDeportesPunta.Deporte(d);
            for (int i = 0; i < manejadorDeportesPunta.Deporte(d).Count; i++)
            {
                Puntaje[i] = Convert.ToString(manejadorDeportesPunta.Deporte(d)[i]);
                // mar = mar + int.Parse( MarcadorFinal[i]);
                if (int.Parse(Puntaje[i]) > Max)
                {
                    Max = int.Parse(Puntaje[i]);
                    lugarMax = i;
                }else if (int.Parse(Puntaje[i]) > Med)
                {
                    Med = int.Parse(Puntaje[i]);
                    lugarMed = i;
                }else if(int.Parse(Puntaje[i]) > Min){

                    Min = int.Parse(Puntaje[i]);
                    lugarMin = i;
                }
            }
            string nom = cmbDeporte.Text;
            manejadorNombreGanador.Deporte(d);
            for (int i = 0; i < manejadorNombreGanador.Deporte(d).Count; i++)
            {
                NombreG[i] = Convert.ToString(manejadorNombreGanador.Deporte(d)[i]);
                //txbGanador.Text = NombreG[i];
            }
            txbGanadorPri.Text = NombreG[lugarMax];
            txbGanadorSe.Text = NombreG[lugarMed];
            txbGanadorTer.Text = NombreG[lugarMin];
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            NombreGanador qui = dtgTabla.SelectedItem as NombreGanador;
            if (qui != null)
            {
                if (MessageBox.Show("Realmente deseas eliminar este Marcador?", "Trabajo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (manejadorNombreGanador.Eliminar(qui.Id))
                    {
                        MessageBox.Show("Marcador eliminado", "Trabajo", MessageBoxButton.OK, MessageBoxImage.Information);
                        ActualizarTablaMarcadores();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Marcador", "Trabajo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }
    }
}
