using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorkIt.Controller;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Start(object sender, StartupEventArgs e)
        {
            IController controller = new MyController();
            IView view = new MainWindow(controller);
            IModel model = new MyModel(controller);

            controller.SetModel(model);
            controller.SetView(view);

            view.Start();
        }
    }
}
