using BDAPP.logic.DBTools.Managers.Connection;
using BDAPP.logic.DBTools.Managers.Data;
using BDAPP.logic.DBTools.Operations;
using Microsoft.Data.SqlClient;
using Npgsql;
using Serilog;
using System.Data;

namespace BDAPP.logic.DBTools.Managers.CRUD
{
    class CrudManager
    {

        private readonly IConnectManager _connectManager;

        public CrudManager(IConnectManager ConnectManager)
        {
            _connectManager = ConnectManager;


            _connectManager.Connect();
        }



        public bool AddMark(int student_id, string field_Name, int mark)
        {

            string query = @"
                INSERT INTO field_comprehensions (student_id, field, mark) 
                VALUES (@studentId, FIELDID_BY_Name(@field), @mark)
                RETURNING field_comprehensions_id";

            var parameters = new[]
            {
                new SqlParameter("@studentId", SqlDbType.Int) { Value = student_id },
                new SqlParameter("@field", SqlDbType.VarChar) { Value = field_Name },
                new SqlParameter("@mark", SqlDbType.Int) { Value = mark }
            };


            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {

                command.Parameters.AddWithValue(parameters[0]);
                command.Parameters.AddWithValue(parameters[1]);
                command.Parameters.AddWithValue(parameters[2]);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    Log.Error($"Eror in query add {student_id},{field_Name},{mark}" + ex.ToString());
                    return false;
                }
                catch (Exception ex)
                {
                    Log.Error($"Eror in query add {student_id},{field_Name},{mark}" + ex.ToString());
                    return false;
                }

            }
            return true;
        }



        public DataTable Search(int id)
        {
            // Запрос для поиска
            string query = @"
            SELECT s.student_id, s.students_group_number, s.last_name, s.first_name, f.field_name, fc.mark
            FROM students s
            JOIN field_comprehensions fc ON s.student_id = fc.student_id
            JOIN fields f ON fc.field = f.field_id
            WHERE s.student_id = @id";
            
            DataTable dataTable = new DataTable();
            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@id", id);
                try
                {
                   
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
                }
            }
            return dataTable;
        }




        public DataTable SELECT()
        {
            string query = @"
            SELECT s.student_id, s.students_group_number, s.last_name, s.first_name, f.field_name, fc.mark
            FROM students s
            JOIN field_comprehensions fc ON s.student_id = fc.student_id
            JOIN fields f ON fc.field = f.field_id";        
            DataTable dataTable = new DataTable();
            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
                }
            }
            return dataTable;
        }
    }

 }
