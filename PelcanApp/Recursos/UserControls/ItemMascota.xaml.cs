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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PelcanApp.Recursos.UserControls
{
    /// <summary>
    /// Lógica de interacción para ItemMascota.xaml
    /// </summary>
    public partial class ItemMascota : UserControl
    {
        public ItemMascota()
        {
            InitializeComponent();
        }

        private void btnOpcionesMascotas_MouseEnter(object sender, MouseEventArgs e)
        {
            Image btn = (Image)sender;
            btn.Source = Herramientas.DameImagen(Properties.Resources.menu_down_corporativo);

        }

        private void btnOpcionesMascotas_MouseLeave(object sender, MouseEventArgs e)
        {
            Image btn = (Image)sender;
            btn.Source = Herramientas.DameImagen(Properties.Resources.menu_down_blanco);
        }
    }
}
