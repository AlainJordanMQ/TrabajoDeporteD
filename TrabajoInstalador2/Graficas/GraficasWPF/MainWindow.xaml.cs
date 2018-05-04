using GeneradoraDeDatos;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
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
using Trabajo;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;
using Trabajo.DAL;

namespace GraficasWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorMarcadores manejadorMarcadores;
        Generadora generador;
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            btnCalcular.Click += BtnCalcular_Click;
            generador = new Generadora();
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

        string[] MarcadorFinal = new string[50];
        int mar = 0;
        int[] Marca = new int[50];
        int contador = 0;
        private void EncontrarMarcadorFinal()
        {
            string d = cmbEquipo.Text;
            manejadorMarcadores.MarcadorF(d);
            for (int i = 0; i < manejadorMarcadores.MarcadorF(d).Count; i++)
            {
                MarcadorFinal[i] = Convert.ToString(manejadorMarcadores.MarcadorF(d)[i]);
                Marca[contador] = int.Parse(MarcadorFinal[i]);
                mar = mar + int.Parse( MarcadorFinal[i]);
                contador = contador + 1;
            }

            MarFinal.Text = mar.ToString();
        }
        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            EncontrarMarcadorFinal();
            int[] Marca2 = new int[50];
            float inferior = 1;
            float superior = contador+1;
            float incremento = 1;
            int valor = 2;
            for (int i = 0; i < 4; i++)
            {
                Marca2[i] = Marca[i];
            }
            generador.GenerarDatos(inferior, superior, incremento, Marca);
            Tabla.ItemsSource = null;
            Tabla.ItemsSource = generador.Puntos;
            PlotModel model = new PlotModel();
            LinearAxis ejeX = new LinearAxis();
            ejeX.Minimum = 0;//double.Parse(txbLimInferor.Text);
            ejeX.Maximum = 10;//double.Parse(txbLimSuperior.Text);
            ejeX.Position = AxisPosition.Bottom;
            ejeX.Title = "Numero de partido";

            LinearAxis ejeY = new LinearAxis();
            ejeY.Minimum = 0;//generador.Puntos.Min(p => p.Y);
            ejeY.Maximum = 10;//generador.Puntos.Max(p => p.Y);
            ejeY.Position = AxisPosition.Left;
            ejeY.Title = "Puntaje";
            

            model.Axes.Add(ejeX);
            model.Axes.Add(ejeY);
            model.Title = "Datos generados";
            LineSeries linea = new LineSeries();
            foreach (var item in generador.Puntos)
            {
                linea.Points.Add(new DataPoint(item.X, item.Y));
            }
            linea.Title = "Valores generados";
            linea.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));
            model.Series.Add(linea);
            Grafica.Model = model;

            
        }

        private void btnAceptarDeporte_Click(object sender, RoutedEventArgs e)
        {
            string d = cmbDeporte.Text;
            manejadorEquipo.Deporte(d);
            cmbEquipo.ItemsSource = null;
            cmbEquipo.ItemsSource = manejadorEquipo.Deporte(d);

        }

        private void btnAceptarEquipo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }
