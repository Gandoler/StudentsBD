using BDAPP.logic.DBTools.Managers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.logic.DBTools.Managers.CRUD
{
    class CrudManager
    {
        private readonly IDataManager _dataManager;

        public CrudManager(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }



    }
}
