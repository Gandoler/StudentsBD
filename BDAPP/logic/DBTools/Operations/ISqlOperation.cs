using System.Data;

namespace OTSC_ui.Tools.DBTools.Operations
{
    internal interface ISqlOperation
    {
        void Insert(string query);
        void Delete(string query);
        void Update(string query);
        void Select(string query, out DataTable results);
    }
}
