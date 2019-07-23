using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityFrameworkMigrationEditor.Core
{
    public class MigrationConnection
    {
        /// <summary>
        /// Default table name __MigrationHistory
        /// </summary>
        public string MigrationTableName { get; set; }
        /// <summary>
        /// SQL Database connection string
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// Bağlanacağı SQL Server type SQL Server or Oracle
        /// </summary>
        public ServerType ServerType { get; set; }

        public MigrationConnection(string connectionString) : this(connectionString, "__MigrationHistory", ServerType.SQLServer)
        {
        }
        public bool TestConnection(out string resultError)
        {
            resultError = "";
            try
            {
                if (this.ServerType == ServerType.SQLServer)
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        var command = new SqlCommand($"SELECT COUNT(*) FROM {MigrationTableName}", connection);
                        var reader = command.ExecuteReader();
                        var tb = new DataTable();
                        tb.Load(reader);
                        connection.Close();
                        return true;
                    }
                }
                else if (this.ServerType == ServerType.Oracle)
                {
                    using (var connection = new OracleConnection(ConnectionString))
                    {
                        connection.Open();
                        var command = new OracleCommand($"SELECT COUNT(*) FROM {MigrationTableName}", connection);
                        var reader = command.ExecuteReader();
                        var tb = new DataTable();
                        tb.Load(reader);
                        connection.Close();
                        return true;
                    }
                }
                else
                {
                    throw new NotSupportedException("Can you development this SQL Server type?");
                }
            }
            catch (Exception ex)
            {
                resultError = ex.Message;
                return false;
            }
        }
        public MigrationConnection(string connectionString, string migrationTableName, ServerType serverType)
        {
            this.ConnectionString = connectionString;
            this.MigrationTableName = migrationTableName;
            this.ServerType = serverType;
        }
        #region - GetMigrations 
        public List<MigrationLightTable> GetMigrations()
        {
            return GetMigrations(new MigrationSetting(true));
        }
        public List<MigrationTable> GetMigrationsWithData()
        {
            return GetMigrationsWithData(new MigrationSetting(true));
        }
        public MigrationLightTable GetMigration(string migrationId)
        {
            return GetMigration(migrationId, new MigrationSetting(true));
        }
        public MigrationTable GetMigrationWithData(string migrationId)
        {
            return GetMigrationWithData(migrationId, new MigrationSetting(true));
        }
        #endregion
        #region - GetMigrations With Settings
        public List<MigrationLightTable> GetMigrations(MigrationSetting setting)
        {
            return getMigrationTable<MigrationLightTable>(string.Empty, false, setting);
        }
        public List<MigrationTable> GetMigrationsWithData(MigrationSetting setting)
        {
            return getMigrationTable<MigrationTable>(string.Empty, true, setting);
        }
        public MigrationLightTable GetMigration(string migrationId, MigrationSetting setting)
        {
            return getMigrationTable<MigrationLightTable>(migrationId, false, setting).FirstOrDefault();
        }
        public MigrationTable GetMigrationWithData(string migrationId, MigrationSetting setting)
        {
            return getMigrationTable<MigrationTable>(migrationId, true, setting).FirstOrDefault();
        }
        #endregion
        #region - Migration Update -
        public void UpdateMigration(string migrationId, XDocument xDocument)
        {
            UpdateMigration(migrationId, xDocument, new MigrationSetting());
        }
        public void UpdateMigration(MigrationLightTable migrationLightTable)
        {
            UpdateMigration(migrationLightTable, new MigrationSetting());
        }
        public void UpdateMigration(MigrationLightTable migrationLightTable, MigrationSetting setting)
        {
            if (this.ServerType == ServerType.SQLServer)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sqlToExecute = $"UPDATE {setting.MigrationTableName} SET {setting.ContextKeyName}=@contexKey , {setting.ProductVersionName}=@productName WHERE {setting.MigrationIdName}=@migrationId";

                    var command = new SqlCommand { Connection = connection, CommandType = CommandType.Text };
                    command.CommandText = sqlToExecute;


                    command.Parameters.Add("@migrationId", SqlDbType.NVarChar).Value = migrationLightTable.MigrationId;
                    command.Parameters.Add("@contexKey", SqlDbType.NVarChar).Value = migrationLightTable.ContextKey;
                    command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = migrationLightTable.ProductVersion;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else if (this.ServerType == ServerType.Oracle)
            {
                using (var connection = new OracleConnection(ConnectionString))
                {
                    var sqlToExecute = $"UPDATE {setting.MigrationTableName} SET {setting.ContextKeyName}=:contexKey , {setting.ProductVersionName}=:productName WHERE {setting.MigrationIdName}=:migrationId";

                    var command = new OracleCommand { Connection = connection, CommandType = CommandType.Text };
                    command.CommandText = sqlToExecute;


                    command.Parameters.Add("migrationId", OracleDbType.NVarchar2).Value = migrationLightTable.MigrationId;
                    command.Parameters.Add("contexKey", OracleDbType.NVarchar2).Value = migrationLightTable.ContextKey;
                    command.Parameters.Add("productName", OracleDbType.NVarchar2).Value = migrationLightTable.ProductVersion;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                throw new NotSupportedException("Can you development this New SQL Server type?");
            }
        }
        public void UpdateMigration(string migrationId, XDocument xDocument, MigrationSetting setting)
        {
            if (this.ServerType == ServerType.SQLServer)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sqlToExecute = $"UPDATE {setting.MigrationTableName} SET {setting.ModelName}=@data WHERE {setting.MigrationIdName}=@migrationId";
                    var command = new SqlCommand { Connection = connection, CommandType = CommandType.Text };
                    command.CommandText = sqlToExecute;
                    var modelBytes = xDocument.Compress();
                    command.Parameters.Add("@data", SqlDbType.VarBinary, modelBytes.Length).Value = modelBytes;
                    command.Parameters.Add("@migrationId", SqlDbType.NVarChar).Value = migrationId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else if (this.ServerType == ServerType.Oracle)
            {
                using (var connection = new OracleConnection(ConnectionString))
                {
                    var sqlToExecute = $"UPDATE {setting.MigrationTableName} SET {setting.ModelName}=:data WHERE {setting.MigrationIdName}=:migrationId";
                    var command = new OracleCommand { Connection = connection, CommandType = CommandType.Text };
                    command.CommandText = sqlToExecute;
                    var modelBytes = xDocument.Compress();
                    command.Parameters.Add("data", OracleDbType.Blob, modelBytes.Length).Value = modelBytes;
                    command.Parameters.Add("migrationId", OracleDbType.NVarchar2).Value = migrationId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                throw new NotSupportedException("Can you development this New SQL Server type?");
            }
        }
        #endregion
        #region - Private Method -

        private List<T> getMigrationTable<T>(string migrationId, bool getData, MigrationSetting setting) where T : class, new()
        {
            if (this.ServerType == ServerType.SQLServer)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sqlToExecute = string.Empty;
                    if (getData)
                    {
                        sqlToExecute = $"SELECT * FROM {setting.MigrationTableName}";
                    }
                    else
                    {
                        sqlToExecute = $"SELECT {setting.ContextKeyName},{setting.MigrationIdName},{setting.ProductVersionName} FROM {setting.MigrationTableName}";
                    }
                    if (string.IsNullOrEmpty(migrationId) == false)
                    {
                        sqlToExecute += $" WHERE {setting.MigrationIdName}='{migrationId}'";
                    }
                    connection.Open();

                    var command = new SqlCommand(sqlToExecute, connection);
                    var reader = command.ExecuteReader();
                    var tb = new DataTable();
                    tb.Load(reader);

                    var result = tb.DataTableToList<T>(setting.GetColumns());
                    connection.Close();
                    return result;
                }
            }
            else if (this.ServerType == ServerType.Oracle)
            {
                using (var connection = new OracleConnection(ConnectionString))
                {
                    var sqlToExecute = string.Empty;
                    if (getData)
                    {
                        sqlToExecute = $"SELECT * FROM {setting.MigrationTableName}";
                    }
                    else
                    {
                        sqlToExecute = $"SELECT {setting.ContextKeyName},{setting.MigrationIdName},{setting.ProductVersionName} FROM {setting.MigrationTableName}";
                    }
                    if (string.IsNullOrEmpty(migrationId) == false)
                    {
                        sqlToExecute += $" WHERE {setting.MigrationIdName}='{migrationId}'";
                    }
                    connection.Open();

                    var command = new OracleCommand(sqlToExecute, connection);
                    var reader = command.ExecuteReader();
                    var tb = new DataTable();
                    tb.Load(reader);

                    var result = tb.DataTableToList<T>(setting.GetColumns());
                    connection.Close();
                    return result;
                }
            }
            else
            {
                throw new NotSupportedException("Can you development this SQL Server type?");
            }

        }


        #endregion
    }
}
