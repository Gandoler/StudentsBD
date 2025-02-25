using System.Data;

namespace BDAPP.logic.DBTools.Operations
{
    internal interface ISqlOperation
    {
        void Insert(string query);
        void Delete(string query);
        void Update(string query);
        void Select(string query, out DataTable results);
    }
}
