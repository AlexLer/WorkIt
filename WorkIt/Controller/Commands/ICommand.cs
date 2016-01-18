using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIt.Controller.Commands
{
    public interface ICommand
    {
        void DoCommand(string[] args);
    }
}
