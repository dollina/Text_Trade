﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// modified by Linh 
public class Account
{
    //make all the data fields protected just in case, since Account class has children
    #region data fields 
    protected string username;
    protected string password;
    protected Email email;
    protected string firstName;
    protected string lastName;
    #endregion

    #region Property fields
    
    // can you add 'this.' before the variables in the get methods
    // ie return this.username
    // it helps to keep variables set in the proper manner

    public string UserName  //can't change username
    {
        get
        {
            return username;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }
        set //can change password
        {
            password = value;  
        }
    }

    public Email _Email
    {
        get    //cant change registered email
        {
            return email;  // as of now this wont return anything you need 
                        //to call _Email.email to return the string containing the email
        }
    }

    public string FirstName //cant change name
    {
        get
        {
            return firstName;
        }
    }

    public string LastName  //cant change name
    {
        get
        {
            return lastName;
        }
    }

    #endregion

    #region methods
    public Account()    //default constructor
	{
	}

    // can you add this. before all the variables again here

	public Account(string uName, string pWord, string fName, string lName, Email eMail) //constructor
	{
        username = uName;
        password = pWord;
        firstName = fName;
        lastName = lName;
        email = eMail;
	}

	public void ChangePassword(string pass)  //why does this method return something? make it void
	{
        password = pass;
	}
    #endregion
}

