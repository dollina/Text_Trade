﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Eric ToDo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

public class DataBase
{

    private const string CONNSTRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Database\\TTDatabase.mdf;Integrated Security=True;Connect Timeout=30";

    public virtual Marketplace Marketplace
    {
        get;
        set;
    }

    public virtual WatchList WatchList
    {
        get;
        set;
    }

    public virtual SellList SellList
    {
        get;
        set;
    }

    public virtual TraderList UserList
    {
        get;
        set;
    }

    public virtual ListingList ListingList
    {
        get;
        set;
    }

    public string ConnString
	{
		get { return CONNSTRING; }
	}

	public virtual void Insert(string tableName, string fieldName, int pKey)
	{

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = DataBase.CONNSTRING;
            conn.Open();

            string sql;
            sql = "INSERT FROM [" + tableName + "] WHERE [" + fieldName + "] = @id";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", pKey);

            command.ExecuteNonQuery();

        }

	}

	public virtual void Delete(string tableName, string fieldName, int pKey)
	{

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = DataBase.CONNSTRING;
            conn.Open();

            String sql;
            sql = "UPDATE [" + tableName + "] SET deleted = 1 WHERE [" + fieldName + "] = @id";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", pKey);

            command.ExecuteNonQuery();

        }

    }


    public List<Listing> SearchFor(string fieldname)
    {

        List<Listing> listings = new List<Listing>();

        using (SqlConnection conn = new SqlConnection(CONNSTRING))
        {

            conn.Open();

            string sql = "";

        }

        return listings;

    } 

}

