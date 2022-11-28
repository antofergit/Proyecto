using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace PelcanApp
{
    public static class Herramientas
    {

        public static BitmapImage DameImagen(byte[] recurso)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(recurso);
            bitmapImage.EndInit();
            return bitmapImage;

        }

        public static BitmapImage DameImagen(string path)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(path, UriKind.Relative);
            bitmapImage.EndInit();
            return bitmapImage;
        }

    }
}
