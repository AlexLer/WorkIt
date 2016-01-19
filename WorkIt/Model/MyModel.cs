using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Controller;

namespace WorkIt.Model
{
    class MyModel : IModel
    {
        private IController m_contoller;

        DatabaseConnection objConnect;

        DataSet ds;
        //DataRow dRow;

        //int MaxRows;
       // int inc = 0;


        public MyModel(IController controller)
        {
            m_contoller = controller;
        }

        public void AddMember(string[] args)
        {
            objConnect = new DatabaseConnection();
            objConnect.Sql = "INSERT INTO dbo.Members (Name,ID,Age,Weight,Sex,Address,Phone_NO) VALUES ('" + args[0] + "','" + args[1] + "','" + args[2] + "','" + args[3] + "','" + args[4] + "','" + args[5] + "','" + args[6] + "')";
            int x = objConnect.ExecuteSqlCommand();
            m_contoller.CheckChanges(x);
        }

        public void CheckClass(string class_name)
        {
            string[] args = m_contoller.getArgs();
            Console.WriteLine(args[0] + " " + args[1]);
            objConnect = new DatabaseConnection();
            objConnect.Sql = String.Format("SELECT M.Name, M.ID FROM Members_class MC, Members M WHERE MC.Class_name = '{0}' and MC.Time = '{1}' and MC.Date = '{2}' and MC.Member_ID = M.ID", class_name, args[0], args[1]);
            ds = objConnect.GetConnection;
            string class_desc = "";
            objConnect.Sql = String.Format("SELECT Description FROM Classes WHERE Name = '{0}'", class_name);
            DataSet ds_class_desc = objConnect.GetConnection;
            if (ds_class_desc.Tables[0].Rows.Count != 0)
            {
                class_desc = ds_class_desc.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            }
            string trainer = "";
            objConnect.Sql = String.Format("SELECT E.Name FROM Trainer_Class TC, Employees E WHERE TC.Class_Name = '{0}' and TC.Trainer_ID = E.ID", class_name);
            DataSet ds_class_trainer = objConnect.GetConnection;
            if (ds_class_trainer.Tables[0].Rows.Count != 0)
            {
                trainer = ds_class_trainer.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            }
            m_contoller.table(ds, String.Format("Participants List for {0}:\n", class_name), class_desc, trainer);
        }

        public List<string> GetDistributionList()
        {
            objConnect = new DatabaseConnection();
            objConnect.Sql = "SELECT Name FROM Distribution_lists";
            ds = objConnect.GetConnection;
            List<string> list = new List<string>();
            for (int i = 0 ; i < ds.Tables[0].Rows.Count; i++)
            {
                list.Add(ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString());
            }

            return list;
        }

    }
}
