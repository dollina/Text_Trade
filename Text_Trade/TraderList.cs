﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Eric TODO

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class TraderList : DataBase
{

    private DataBase db = new DataBase();
    private List<int> traderList = new List<int>();

	public virtual void Add(Trader trader) // this function probably needs to be moved to the trader class
	{

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            //conn.ConnectionString = db.ConnString;
            conn.Open();

            string sql;

            if (trader.Trader_id == -1)
            {

                sql = "INSERT into [TraderList] (username, password, deleted, classschedule) "
                        + "VALUES ( @uname , @pword, 0, null )";

            }

            else
            {

                sql = "INSERT into [TraderList] (username, password, deleted, classschedule) "
                        + "VALUES ( @uname , @pword, 0, null )"
                        + "WHERE trader_id = @trader_id";

            }

            

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("uname", trader.Username);
                command.Parameters.AddWithValue("pword", trader.Password);

                if (trader.Trader_id == -1)
                {

                    int tid = (int)command.ExecuteScalar();

                    trader.Trader_id = tid;

                }

                else
                {

                    command.Parameters.AddWithValue("trader_id", trader.Trader_id);

                    command.ExecuteNonQuery();

                } 
            }

        }

	}


    public void CreateList()
    {

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string query = "SELECT trader_id FROM TraderList";

            using (SqlCommand command = new SqlCommand(query, conn))
            {

                using (SqlDataReader dbreader = command.ExecuteReader())
                {

                    while (dbreader.Read())
                    {

                        traderList.Add(Convert.ToInt32(dbreader.GetString(0)));

                    }

                }

            }

        }

    }

	public List<Trader> SearchForUser(int traderid)
	{

        List<Trader> traders = new List<Trader>();

        traders = db.SearchForTrader(traderid);

        return traders;

    }

    //Overloaded SearchForUser method using a string representing a username
    //Returns a list of traders with matching usernames
    //Empty string will return list of all users
    public List<Trader> SearchForUser(string uName)
    {
        List<Trader> traders = new List<Trader>();

        traders = db.SearchForTrader(uName);

        return traders;
    }

}

