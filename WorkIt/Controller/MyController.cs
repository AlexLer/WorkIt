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
    class MyController : IController
    {
        private IModel m_model;
        private IView m_view;

        public void SetModel(IModel model)
        {
            m_model = model;
           
        }

        public void SetView(IView view)
        {
            m_view = view;
            m_view.SetCommands(GetCommands());

        }

        public Dictionary<string, ICommand> GetCommands()
        {
            Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
            commands["AddMember"] = new AddMember(m_view, m_model);
            commands["ClassList"] = new ClassList(m_view, m_model);

            return commands;
        }

        public void Output(string s)
        {
            m_view.Output(s);
        }


        public void table(DataSet ds, string s)
        {
            int maxRows = 0;
            try
            {
                maxRows = ds.Tables[0].Rows.Count;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (maxRows == 0)
            {
                m_view.Output("Class doesn't exist");
            }

            else
            {
                string names = "Name:\n";
                string IDs = "ID:\n";
                string header = s;
                DataRow dRow;
                for (int i = 0; i < maxRows; i++)
                {

                    dRow = ds.Tables[0].Rows[i];
                    names += dRow.ItemArray.GetValue(0) + "\n";
                    IDs += dRow.ItemArray.GetValue(1) + "\n";
                }
                
                m_view.OutputWindow(header, names, IDs);
            }
        }
    }
}
