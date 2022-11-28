using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace PelcanApp.Windows
{
    /// <summary>
    /// Lógica de interacción para wNuevaMascota.xaml
    /// </summary>
    public partial class wNuevaMascota : Window
    {
        public Dictionary<string,string> Diccionario { get; set; }

        public wNuevaMascota()
        {
            InitializeComponent();
            List<string> lista = new List<string>() { "Antonio", "Torres", "Fernandez" };
            cmbRazas.ItemsSource = lista;

            imgRaza.Source = Herramientas.DameImagen(Properties.Resources.sin_imagen);
            //Diccionario = CreaDiccionarioImagenes();

            //if (Diccionario.Count > 0)
            //{
            //    List<string> keys = new List<string>(Diccionario.Keys);
            //    cmbRazas.ItemsSource = keys;
            //}
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

            

        }


        private Dictionary<string,string> CreaDiccionarioImagenes()
        {

            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            string[] archivos = Directory.GetFiles(@"../Razas", "*.jpg");
            foreach (string archivo in archivos)
            {
                string nuevoArchivo = archivo.Replace(".jpg", "");
                nuevoArchivo = nuevoArchivo.Replace(@"..\Razas\", "");
                nuevoArchivo = nuevoArchivo.Replace("_", " ");
                diccionario.Add(nuevoArchivo, archivo);
            }


            return diccionario;
        }

        private void cmbRazas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
            //ComboBox cmb = sender as ComboBox;
            ////imgRaza.Source = Herramientas.DameImagen(Diccionario[cmb.SelectedItem.ToString()]);
            //imgRaza.Source = new BitmapImage(new Uri(@"../Recursos/Razas/boxer.jpg", UriKind.Relative));
        }


    }
}
