using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Controller.Commands;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt.Controller
{
    public interface IController
    {
        void SetModel(IModel model);
        void SetView(IView view);
        Dictionary<string, ICommand> GetCommands();

        void CheckChanges(int x);

        void table(DataSet ds, string s, string class_desc, string trainer);

        string[] getArgs();

        void Output(string s);
    }
}
