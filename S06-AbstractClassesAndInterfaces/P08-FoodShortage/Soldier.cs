﻿using System;
using System.Collections.Generic;
using System.Text;


public class Soldier
{
    public Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get;private  set; }
}

