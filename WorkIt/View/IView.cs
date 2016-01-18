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
        void Output(string s);
    }
}
