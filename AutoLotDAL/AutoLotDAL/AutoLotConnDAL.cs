using System;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
    public class InventoryDAL
    {
        private SqlConnection connect = null;
        public ConnectionState conState { get { if (connect == null) { return ConnectionState.Closed; } return connect.State; } }
        public ConnectionState OpenConnection(string connectionString)
        {
            try
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                return connect.State;
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't open connection!", ex);
                throw error;
            }
        }
        public ConnectionState CloseConnection()
        {
            try
            {
                connect.Close();
                return connect.State;
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't close connection!", ex);
                throw error;
            }

        }
        public DataTable GetTablesName()
        {
            try
            {
                DataTable tables = connect.GetSchema("Tables");
                return tables;
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't get tables name!", ex);
                throw error;
            }
        }
        public DataTable GetAllFromTableAsDataTable(string tableName)
        {
            DataTable table = new DataTable();
            string sql = "Select * From " + tableName;
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, this.connect))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    table.Load(dr);
                    dr.Close();
                }
                return table;
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't get data from table!", ex);
                throw error;
            }
        }
        public void InsertAuto(string make, string color, string petName)
        {
            string sql = string.Format("Insert Into Inventory" + "(Make, Color, PetName) Values('{0}', '{1}', '{2}')", make, color, petName);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, this.connect))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Make";
                    param.Value = make;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 25;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Color";
                    param.Value = color;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 25;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PetName";
                    param.Value = petName;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 25;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't insert new data in Auto table!", ex);
                throw error;
            }
           
        }
        public void DeleteCar(int id)
        {
            string sql = string.Format("Delete from Inventory Where CarId = {0}", id);
            using (SqlCommand cmd = new SqlCommand(sql,this.connect))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Can't delete car!", ex);
                    throw error;
                }
            }
        }
        public void UpdateCarPetName(int id, string newPetName)
        {
            string sql = string.Format("Update Inventory Set PetName = '{0}' Where CarId = {1}", newPetName, id);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, this.connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't update PetName!", ex);
                throw error;
            }

        }
        public string LookUpPetName(int carId)
        {
            string carPetName = string.Empty;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetPetName", this.connect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@carID";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = carId;
                    param.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.Direction = ParameterDirection.Output;
                    param.ParameterName = "@petName";
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();

                    carPetName = ((string)cmd.Parameters["@petName"].Value).Trim();
                }
                return carPetName;
            }
            catch (Exception ex)
            {
                Exception error = new Exception("Can't get PetName!", ex);
                throw error;
            }
           
        }
        public void ProcessCreditRisk(bool throwEx, int custId)
        {
            string fName = string.Empty;
            string lName = string.Empty;
            SqlParameter param = null;
            string sql = string.Format("Select * From Customer Where CustId = {0}", custId);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                param = new SqlParameter();
                param.ParameterName = "@CustID";
                param.SqlDbType = SqlDbType.Int;
                param.Value = custId;
                cmd.Parameters.Add(param);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        fName = (string)dr["FirstName"];
                        lName = (string)dr["LastName"];
                    }
                    else return;
                }
            }
            SqlCommand cmdRemove = new SqlCommand(string.Format("Delete From Customers Where CustId = {0}", custId), this.connect);
            param = new SqlParameter();
            param.ParameterName = "@CustID";
            param.SqlDbType = SqlDbType.Int;
            param.Value = custId;
            cmdRemove.Parameters.Add(param);
            SqlCommand cmdInsert = new SqlCommand(string.Format("Insert Into CreditRisk" +
                "(CustId, FirstName, LastName) Values" +
                "('{0}', '{1}'. '{2}')", custId, fName, lName), this.connect);
            cmdInsert.Parameters.Add(param); // CustID
            param = new SqlParameter();
            param.ParameterName = "@FirstName";
            param.SqlDbType = SqlDbType.Char;
            param.Value = fName;
            cmdInsert.Parameters.Add(param);
            param = new SqlParameter();
            param.ParameterName = "@LastName";
            param.SqlDbType = SqlDbType.Char;
            param.Value = lName;
            cmdInsert.Parameters.Add(param);
            SqlTransaction sqlTransaction = null;
            try
            {
                sqlTransaction = connect.BeginTransaction();
                cmdInsert.Transaction = sqlTransaction;
                cmdRemove.Transaction = sqlTransaction;
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();
                if(throwEx)
                {
                    throw new ApplicationException("Data base error! Transaction failed!");
                }
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                sqlTransaction.Rollback();
            }
        }
    }
}
