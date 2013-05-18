using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
namespace Prototype_1
{
    class ClientSearch
    {
        private db my_db;
        
        public ClientSearch() {
            my_db = new db();
        }
        public List<Client> getClientByName(String first_name) {
            List<Client> list = new List<Client>();
            string query = "select * from Client where firstName=\"" + first_name+"\"";
            MySqlConnection conn = null;
            MySqlDataReader dataReader = getReader(query, ref conn);
            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list.Add(new Client(dataReader));
            }
            conn.Close();
            return list;
        }
        public MySqlDataReader getReader(string query, ref MySqlConnection conn) { 
            MySqlDataReader dataReader=null;
            if (this.my_db.OpenConnection()== true) {
                conn = this.my_db.getConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                dataReader= cmd.ExecuteReader();
            }
            return dataReader;
        }
        public List<HouseHold> getHouseHold(Client c) {
            List<HouseHold> l = new List<HouseHold>();
            List<int> list_household_ids=getHouseHoldIds(c);
            MySqlConnection conn=null;
            foreach(int household_id in list_household_ids){
                string query="select * from Household where id="+household_id;
                MySqlDataReader dataReader=getReader(query, ref conn);
                dataReader.Read();
                l.Add(new HouseHold(dataReader));
                
            }
            conn.Close();
            return l;
            
        }
        private List<int> getHouseHoldIds(Client c){
            List<int> l = new List<int>();
            string query = "select HouseHold_ID from HouseholdOwnerRelation where Client_ID=" + c.id;
            MySqlConnection conn=null;
            MySqlDataReader dataReader = getReader(query, ref conn);
            while (dataReader.Read()) { 
                l.Add(dataReader.GetInt32("HouseHold_ID"));
            }
            conn.Close();
            return l;

        }
        
    }//end class my_db

    public class Client {
        public int id { get; set; }
        public String firstname {get;set;}
        public String _lastname { get; set; }
        public MySqlDateTime _Dob { get; set; }
        public String _gender { get; set; }
        public String _medicare { get; set; }
        public String _workStatus { get; set; }
        public String _countryoforigin { get; set; }
        public String _maritalstatus { get; set; }
        public String _incometype { get; set; }
        public String _languagespoken { get; set; }
        public MySqlDateTime _dateregistered { get; set; }
        public String _contact { get; set; }
        public String _region { get; set; }
        public String _reasonforserviceusage { get; set; }



        public Client(MySqlDataReader dr){
            
            id = Convert.ToInt32(dr.GetString("id"));
            firstname = dr.GetString("firstName");
            _lastname = dr.GetString("lastName");
            _Dob = dr.GetMySqlDateTime("DoB");
            _gender = dr.GetString("gender");
            _medicare = dr.GetString("medicare");
            _languagespoken = dr.GetString("languageSpoken");
            _dateregistered = dr.GetMySqlDateTime("dateRegistered");
            _contact = dr.GetString("contact");
            _region = dr.GetString("region");
            _reasonforserviceusage = dr.GetString("reasonForServiceUsage");

        }
        public Client(Dictionary<String, String> li) {
            this.firstname = li["firstname"];
            this._lastname = li["lastname"];
        }
        /*public List<HouseHold> getHouseHolds() {
            List<HouseHold> list = new List<HouseHold>();
            
            db my_db = new db();
            if (my_db.OpenConnection() == true)
            {
                MySqlConnection conn = my_db.getConnection();
                String query = "select * from HouseHoldOwnerRelation HouseHold_ID where Client_ID=" + this.id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {                 
                    int household_id = dataReader.GetInt32("HouseHold_ID");
                    conn.Close();
                    MySqlConnection conn2 = my_db.getConnection();
                    query = "select * from Household where ID=\"" + household_id + "\"";
                    cmd = new MySqlCommand(query, conn2);
                    MySqlDataReader dataReader2= cmd.ExecuteReader();
                    list.Add(new HouseHold(dataReader));

                }
            }
            return list;
        }*/
    }
    public class HouseHold {
        public int id { get; set; }
        public string address { get; set; }
        public string appartmentNumber { get; set; }
        public string postalCode { get; set; }
        public MySqlDateTime dateRegistered { get; set; }
        public MySqlDateTime dateRenewed { get; set; }
        public HouseHold(MySqlDataReader dr) {
            id = dr.GetInt32("ID");
            address = dr.GetString("address");
            appartmentNumber = dr.GetString("appartmentNumber");
            postalCode = dr.GetString("postalCode");
            dateRegistered = dr.GetMySqlDateTime("dateRegistered");
            dateRenewed = dr.GetMySqlDateTime("dateRenewed");
        }

    }
    class ClientHouseHoldTuple {
        public Client client;
        public HouseHold household;
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int id { get; set; }
        public string address { get; set; }
        public string appartmentNumber { get; set; }
        public string postalCode { get; set; }
        public MySqlDateTime dateRegistered { get; set; }
        public MySqlDateTime dateRenewed { get; set; }
        public ClientHouseHoldTuple(Client c, HouseHold h) {
            client = c;
            household = h;
            first_name = c.firstname;
            last_name = c._lastname;
            address = h.address;
            appartmentNumber = h.appartmentNumber;
            postalCode = h.postalCode;
            dateRegistered = h.dateRegistered;
            dateRenewed = h.dateRenewed;
        }
    }
}
