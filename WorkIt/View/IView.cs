using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Controller.Commands;

namespace WorkIt.View
{
    public interface IView
    {
        void Start();
        void SetCommands(Dictionary<string, ICommand> commands);
        string[] getArgs();
        void Output(string s);
        void OutputWindow(string header, string names, string IDs);

        void SetDistributionList(List<string> lists);
    }
}
