using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using API.Data;
using API.Models;


namespace PelcanApp.Windows
{
    /// <summary>
    /// Lógica de interacción para wNuevoCliente.xaml
    /// </summary>
    public partial class wNuevoCliente : Window
    {

        public wNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

            List<TextBox> listaTextBoxes = new List<TextBox>()
            {
                txtDNI,
                txtTelefono,
                txtNombre,
                txtApellidos,
                txtDireccion,
                txtPoblacion,
                txtCodigo,
                txtProvincia,
                txtEmail
            };

            //Comprobamos que todos los campos estén rellenos
            if (Validacion(listaTextBoxes))
            {
                //Creamos el objeto Cliente con los datos obtenidos
                Cliente nuevoCliente = new Cliente
                {
                    DNI = txtDNI.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    NombreCompleto = txtNombre.Text.Trim() + " " + txtApellidos.Text.Trim(),
                    Telefono = Convert.ToInt32(txtTelefono.Text.Trim()),
                    Direccion = txtDireccion.Text.Trim(),
                    CodigoPostal = Convert.ToInt32(txtCodigo.Text.Trim()),
                    Poblacion = txtPoblacion.Text.Trim(),
                    Provincia = txtProvincia.Text.Trim(),
                    Correo = txtEmail.Text.Trim(),
                    FechaAlta = DateTime.Now
                };

                Respuesta respuesta =  DataClientes.AgregarCliente(nuevoCliente);
                DialogResult = respuesta.Estado;
                if (!respuesta.Estado)
                {
                    MessageBox.Show(respuesta.MensajeRespuesta, "Error al crear el nuevo Cliente", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                else
                {
                    this.Close();
                }

            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }


        private bool Validacion(List<TextBox> objetos)
        {
            bool validacion = false;
            foreach (TextBox objeto in objetos)
            {
                if (string.IsNullOrEmpty(objeto.Text.Trim()))
                {
                    objeto.BorderBrush = Brushes.Red;
                    MessageBox.Show($"El campo {objeto.Tag} es obligatorio", "Campo incompleto", MessageBoxButton.OK, MessageBoxImage.Stop);
                    objeto.Focus();
                    validacion = false;
                    break;
                }
                validacion = true;
            }

            return validacion;
        }

    }
}
