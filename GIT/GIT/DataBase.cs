using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace GIT
{
    class DataBase
    {
        private static string User;
        private static string Password;
        private static string Port;
        private static string Host;
        private static string _DataBase;
        private static string ConnectionString;

        private MySqlConnection mySqlConnection;
        public void ConnectDataBase(string user, string password, string port, string host, string database)
        {
            User = user;
            Password = password;
            Port = port;
            Host = host;
            _DataBase = database;
            ConnectionString = $"host={Host};password={Password};port={Port};user={User};database={_DataBase}";
            mySqlConnection = new MySqlConnection(ConnectionString);

            if (mySqlConnection.State.Equals(System.Data.ConnectionState.Closed))
                mySqlConnection.Open();
        }
        public void CloseConnect()
        {
            if (mySqlConnection.State.Equals(System.Data.ConnectionState.Open))
                mySqlConnection.Close();
        }
    }
}
