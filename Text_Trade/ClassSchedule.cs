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

public class ClassSchedule
{
    #region data fields
    private List<Course> schedule;
    #endregion

    // this. again please

    #region Properties
    public List<Course> Schedule
    {
        get
        {
            return schedule;
        }
    }
    #endregion

    #region methods
    public ClassSchedule()  //constructor
	{
	}

	public virtual void AddClass(string cC, string cL)
	{
        schedule.Add(new Course(cC, cL));
	}

    // you would probably need to create a predicate and search the list for the course
    // then you would call the remove function (it might be called something different)
    // and you could either remove it based on the predicate call (imagine a function in
    // in a function) or you could set an iterator based on what the predicate returns
    // and remove the position in the list

	public virtual void RemoveClass(Course course)
	{
        if (schedule.Count != 0)
            schedule.Remove(course);
	}
    #endregion
}

