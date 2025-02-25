using BDAPP.logic.DBTools.Connection;
using BDAPP.logic.DBTools.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.logic.DBTools.Managers.Data
{
    interface IDataManager
    {


        public void InsertData(string query);


        public void UpdateData(string query);

        public void DeleteData(string query);

        public DataTable GetDataTable(string query);

        public void CloseConnecction();
    }
}
