using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Farma.pe.models;
using Newtonsoft.Json;

namespace Farma.pe
{
    public partial class BuscarMedicamentos : PhoneApplicationPage
    {
        public BuscarMedicamentos()
        {
            InitializeComponent();
            listarMedicamentos();
        }

        private void listarMedicamentos()
        {
            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54970/WebAPI_Farma.pe/api/Medicamento/");

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Listar);
                wc.DownloadStringAsync(url);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Listar(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<Medicamento> arr = JsonConvert.DeserializeObject<List<Medicamento>>(e.Result);

                for (int i = 0; i < arr.Count(); i++)
                {
                    arr.ElementAt(i).rutaFlecha = "/imagenes/flechaDerecha.png";
                    arr.ElementAt(i).rutaImagen = "/imagenes/logo.png";
                }

                lbMedicamento.ItemsSource = arr;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}