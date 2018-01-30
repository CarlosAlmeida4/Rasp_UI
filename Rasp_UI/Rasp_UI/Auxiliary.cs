using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rasp_UI;
using Mapsui.Geometries;
using Mapsui.Projection;
using Mapsui.Utilities;
using Mapsui.Geometries.WellKnownText;
using Mapsui.Providers;
using Mapsui.Styles;
using Mapsui.Layers;

namespace Rasp_UI
{
    class Auxiliary
    {
        public double[] GPS_Calculus(byte[] bb, int k)
        {
            double[] returner = new double[3];


            char[] returner_helper = new char[k];

            for (int i = 0; i < k; i++)
            {
                //Console.WriteLine("Char "+ i + " Has the value : "+ Convert.ToChar(bb[i]));
                //Returner_helper is a char array
                returner_helper[i] = Convert.ToChar(bb[i]);
            }

            //Create a string from the char array
            string returner_helper_2 = new string(returner_helper);
            //Substitute all "." with "," this is needed in order to use convert.ToDouble
            returner_helper_2 = returner_helper_2.Replace(".", ",");
            //Console.WriteLine("Returner Helper : " + returner_helper_2);

            int cut_index = returner_helper_2.IndexOf("/");
            int cut_index_2 = returner_helper_2.LastIndexOf("/");
            //Console.WriteLine("Cut Index: " + cut_index + "Cut_Index 2: " + cut_index_2);

            /**********************************************SPEED*****************************************************************/
            //Store in the speed string only the speed portion of the info
            string speed = returner_helper_2.Substring((cut_index_2 + 1), (returner_helper_2.LastIndexOf("\n") - 1 - (cut_index_2)));
            //Remove the speed portion from the returner_helper_2
            returner_helper_2 = returner_helper_2.Remove(cut_index_2, (returner_helper_2.LastIndexOf("\n") - (cut_index_2 - 1)));
            //Console.WriteLine("Speed: " + speed);
            returner[2] = Convert.ToDouble(speed);

            /**********************************************Longitude*****************************************************************/
            //Store in the longitude string only the speed portion of the info
            string longitude = returner_helper_2.Substring((cut_index + 1), (cut_index_2 - 1 - cut_index));
            //Remove the longitude portion from the returner_helper_2
            returner_helper_2 = returner_helper_2.Remove(cut_index, (cut_index_2 - cut_index));
            //Console.WriteLine("Longitude: " + longitude);
            returner[1] = Convert.ToDouble(longitude);

            //Console.WriteLine("Returner Helper 2: " + returner_helper_2);

            /*********************************************Latitude*******************************************************************/
            //Store in the latitude string only the speed portion of the info
            string latitude = returner_helper_2.Substring(0, cut_index);
            //Remove the latitude portion from the returner_helper_2
            returner_helper_2 = returner_helper_2.Remove(0, cut_index);
            //Console.WriteLine("latitude: " + latitude);
            returner[0] = Convert.ToDouble(latitude);

            return returner;

        }

        public static Layer CreatePointLayer(Mapsui.Geometries.Point point)
        {
            var features = new Features
            {
                new Feature {Geometry = point},
            };
            var dataSource = new MemoryProvider(features) { CRS = "EPSG:4326" };

            return new Layer
            {
                DataSource = dataSource,
                Name = "WGS84 Point"
            };
        }
    }
}
