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

public class ListingList
{


	public List<Listing> listingList
	{

		get { return this.listingList; }
        set { this.listingList = new List<Listing>(); }

	}

    public DataBase db;

    public string connString
    {

        get { return this.connString; }
        set { this.connString = db.connString; }

    }

    public virtual void Add(Listing listing)
	{
        listingList.Add(listing);

	}

}

