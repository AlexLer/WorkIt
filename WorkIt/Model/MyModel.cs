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
        //string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;


        public MyModel(IController controller)
        {
            m_contoller = controller;
        }

        public void AddMember(string[] args)
        {
            objConnect = new DatabaseConnection();
            Console.WriteLine(String.Format("INSERT INTO dbo.Members (Name,ID,Age,Weight,Sex,Address,Phone_NO) VALUES ({0},{1},{2},{3},{4},{5},{6})", args[0], args[1], args[2], args[3], args[4], args[5], args[6]));
            objConnect.Sql = "INSERT INTO dbo.Members (Name,ID,Age,Weight,Sex,Address,Phone_NO) VALUES ('" + args[0] + "','" + args[1] + "','" + args[2] + "','" + args[3] + "','" + args[4] + "','" + args[5] + "','" + args[6] + "')";
            Console.WriteLine("hehe");
            //ds = objConnect.GetConnection;
            int x = objConnect.ExecuteSqlCommand();
            if (x == -1)
            {
                m_contoller.Output("Error occured: Member already exists");
            }
            else m_contoller.Output("Member added successfully");
        }

        public void CheckClass(string class_name)
        {
            objConnect = new DatabaseConnection();
            objConnect.Sql = String.Format("SELECT * FROM Classes WHERE Name = {0}", class_name);

            ds = objConnect.GetConnection;
            
            m_contoller.table(ds);
        }


    }
}
