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

        private string part_list;

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

            return commands;
        }

        public void Output(string s)
        {
            m_view.Output(s);
        }


        public void table(DataSet ds)
        {
            int maxRows = ds.Tables[0].Rows.Count;
            
            if (maxRows == 0)
            {
                m_view.Output("Class doesn't exist");
            }

            else
            {
                part_list = "";
                DataRow dRow;
                for (int i = 0; i < maxRows; i++)
                {
                    dRow = ds.Tables[0].Rows[0];
                    int j = dRow.ItemArray.Count();
                    foreach (var item in dRow.ItemArray)
                    {
                        part_list = item.ToString() + " ";
                    }
                }

                m_view.Output(part_list);
            }

        }
        public void Test(){
            cosnole.writeln("Hi Alex");
        }
    }
}
