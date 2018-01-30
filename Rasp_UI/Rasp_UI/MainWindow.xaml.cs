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
using System.Net.Sockets;
using System.IO;
using System.Net;
using BruTile.Predefined;
using Mapsui.Layers;
using Rasp_UI;
using Mapsui.Geometries;
using Mapsui.Projection;
using Mapsui.Utilities;
using Mapsui.Geometries.WellKnownText;
using Mapsui.Providers;
using Mapsui.Styles;



namespace Rasp_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TCP_connection TCP = new TCP_connection();


        public MainWindow()
        {
            InitializeComponent();
            TCP.Connect_TCP();
            MyMapControl.Map.Layers.Add(new TileLayer(KnownTileSources.Create()));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Window1 window = new Window1();
            this.Close();
            window.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double[] GPS_Values = TCP.GPS_Information();
            var point = new Mapsui.Geometries.Point(GPS_Values[1], GPS_Values[0]);
            var sphericalMercatorCoordinate = SphericalMercator.FromLonLat(point.X, point.Y);
            MyMapControl.Map.NavigateTo(sphericalMercatorCoordinate);
            MyMapControl.Map.NavigateTo(MyMapControl.Map.Resolutions[18]);
            MyMapControl.Map.Layers.Add(OpenStreetMap.CreateTileLayer());

            MyMapControl.Map.Layers.Add(Auxiliary.CreatePointLayer(sphericalMercatorCoordinate));

        }
        

    }
}
