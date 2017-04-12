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

//modified by Linh
public class Listing
{
    #region data fields 
    string title;
    string author;
    string edition;
    string isbn;
    string courseCode;
    string courseLevel;
    string condition;
    string lastUsed;
    double price;
    image picture;  //? image type?
    string description;
    #endregion

    #region Properties
    public string Title
	{
		get
        {
            return title;
        }
		set
        {
            title = value;
        }
	}

	public string Author
	{
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }

	public string Edition
	{
        get
        {
            return edition;
        }
        set
        {
            edition = value;
        }
    }

	public string Isbn
	{
        get
        {
            return isbn;
        }
        set
        {
            isbn = value;
        }
    }

	public string CourseCode
	{
        get
        {
            return courseCode;
        }
        set
        {
            courseCode = value;
        }
	}

	public string CourseLevel
	{
        get
        {
            return courseLevel;
        }
        set
        {
            courseLevel = value;
        }
    }

	public string LastUsed
	{
        get
        {
            return lastUsed;
        }
        set
        {
            lastUsed = value;
        }
    }

	public string Condition
	{
        get
        {
            return condition;
        }
        set
        {
            condition = value;
        }
	}

	public double Price
	{
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

	public image Picture //Not sure how to implement this
	{
		get;
		set;
	}

	public string Description
	{
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }
    #endregion

    #region methods
    public Listing()
	{
	}

    public Listing(string title, string author, string edition, string isbn, string cC, string cL, string condition, double price)
    {
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.courseCode = cC;
        this.courseLevel = cL;
        this.condition = condition;
        this.price = price;
    }

    public virtual void UpdateAll(string title, string author, string edition, string isbn, string cC, string cL, string condition, double price, string lastUsed, image picture, string description)
	{
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.courseCode = cC;
        this.courseLevel = cL;
        this.condition = condition;
        this.price = price;
        this.lastUsed = lastUsed;
        this.picture = picture;
        this.description = description;
    }

	public virtual void UpdateAuthor(string author)
	{
        this.author = author;
	}

	public virtual void UpdateCondition(string condition)
	{
        this.condition = condition;
	}

	public virtual void UpdateCourseCode(string cC)
	{
        this.courseCode = cC;
	}

	public virtual void UpdateCourseLevel(string cL)
	{
        this.courseLevel = cL;
	}

	public virtual void UpdateDescription(string description)
	{
        this.description = description;
	}

	public virtual void UpdateEdition(string edition)
	{
        this.edition = edition;
	}

	public virtual void UpdateISBN(string isbn)
	{
        this.isbn = isbn;
	}

	public virtual void UpdateLastUsed(string lastUsed)
	{
        this.lastUsed = lastUsed;
	}

	public virtual void UpdatePicture(image picture)
	{
        this.picture = picture;
	}

	public virtual void UpdatePrice(double price)
	{
        this.price = price;
	}

	public virtual void UpdateTitle(string title)
	{
        this.title = title;
	}
    #endregion
}

