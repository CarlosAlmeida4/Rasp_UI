using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Rasp_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Console.WriteLine(" GoodBye ");
            TCP_connection TCP = new TCP_connection();
            TCP.Disconnect_TCP();
        }

    }

}
