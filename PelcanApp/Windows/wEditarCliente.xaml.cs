using API.Data;
using API.Models;
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

namespace PelcanApp.Windows
{
    /// <summary>
    /// Lógica de interacción para wEditarCliente.xaml
    /// </summary>
    public partial class wEditarCliente : Window
    {

        public int ClienteID { get; set; }
        public Cliente cliente { get; set; }

        public wEditarCliente(int clienteID)
        {
            InitializeComponent();
            ClienteID = clienteID;

            //Rellenamos los campos con los datos del cliente indicado en el constructor
            Respuesta respuesta = DataClientes.MostrarClienteID(ClienteID);
            if (respuesta.Estado)
            {
                cliente = respuesta.ListaObjetos[0] as Cliente;
                txtDNI.Text = cliente.DNI;
                txtTelefono.Text = cliente.Telefono.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellidos.Text = cliente.Apellidos;
                txtDireccion.Text = cliente.Direccion;
                txtPoblacion.Text = cliente.Poblacion;
                txtCodigo.Text = cliente.CodigoPostal.ToString();
                txtProvincia.Text = cliente.Provincia;
                txtEmail.Text = cliente.Correo;
            }
            else
            {
                MessageBox.Show(respuesta.MensajeRespuesta, "Error al cargar el cliente", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();

            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            //Actualizamos los datos del cliente con los datos introducidos en los TextBox
            cliente.DNI = txtDNI.Text.Trim();
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellidos.Text.Trim();
            cliente.NombreCompleto = cliente.Nombre + " " + cliente.Apellidos;
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.CodigoPostal = Convert.ToInt32(txtCodigo.Text.Trim());
            cliente.Poblacion = txtPoblacion.Text.Trim();
            cliente.Provincia = txtProvincia.Text.Trim();
            cliente.Correo = txtEmail.Text.Trim();

            Respuesta respuesta = DataClientes.EditarCliente(cliente);
            if (respuesta.Estado)
            {
                DialogResult = true;
            }
            else
            {
                MessageBox.Show(respuesta.MensajeRespuesta, "No se ha podido actualizar el cliente", MessageBoxButton.OK, MessageBoxImage.Error);
                DialogResult = false;
                this.Close();
            }

        }
    }
}
