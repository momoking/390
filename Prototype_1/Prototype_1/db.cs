using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Prototype_1
{
    class db
    {
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public db()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "mydb";
        uid = "root";
        password = "";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }
    //open connection to database
    public Boolean OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    //TODO: create message saying: "Cannot connect to server.  Contact administrator"
                    break;

                case 1045:
                    //TODO: create massage saying: "Invalid username/password, please try again"
                    break;
            }
            return false;
        }
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
           //TODO: display message saying: "ex.Message"
            return false;
        }
    }
    public MySqlConnection getConnection(){
        return this.connection;
    }
    

    }
}
