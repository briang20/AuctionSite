using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AuctionLib
{
    public class User
    {
        //Manually Created POCOs

        //Auto generated POCOs
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string password { get; set; }
                                           //--------------------------

        //Manually Created Pocos Access



        //-----------------Class Methods----------------------------

        public int CreateNewUser(User newUser)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand addNewUser = new SqlCommand();
            int success;

            try
            {

                addNewUser.CommandType = CommandType.StoredProcedure;
                addNewUser.CommandText = "AddNewUser";
                addNewUser.Parameters.AddWithValue("@username", newUser.userName);
                addNewUser.Parameters.AddWithValue("@password", newUser.password);
                addNewUser.Parameters.AddWithValue("@firstName", newUser.firstName);
                addNewUser.Parameters.AddWithValue("@lastName", newUser.lastName);
                addNewUser.Parameters.AddWithValue("@address1", newUser.addressOne);
                addNewUser.Parameters.AddWithValue("@address2", string.IsNullOrEmpty(newUser.addressTwo) ? newUser.addressTwo : string.Empty);
                addNewUser.Parameters.AddWithValue("@city", newUser.city);
                addNewUser.Parameters.AddWithValue("@state", newUser.state);
                addNewUser.Parameters.AddWithValue("@zip", newUser.zip);

                success = objDB.DoUpdateUsingCmdObj(addNewUser);
            }
            catch
            { throw; }

            finally
            { objDB.CloseConnection(); addNewUser.Dispose(); }

            return success;

        }



    }



}
