using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt.Controller.Commands
{
    abstract class ACommand : ICommand
    {
        protected IModel m_model;
        protected IView m_view;

        public abstract void DoCommand(string[] args);
    }
}
