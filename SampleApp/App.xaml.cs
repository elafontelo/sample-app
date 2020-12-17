using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SampleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void GetMessages()
        {
            //var client = new Pop3Client();
            //client.Connect("pop.outlook.com", 995, true);
            //client.Authenticate("ysraela.f@kinpo.com.ph", "kinpo123");

            //var count = client.GetMessageCount();
            //Message message = client.GetMessage(count);
            //Console.WriteLine(message.Headers.Subject);
        }

    }
}
