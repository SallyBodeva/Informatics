﻿using System;
using System.Collections.Generic;
using System.Text;


public class Robot:IVistitors
{
    public Robot(string model, string id)
    {
       this.Model = model;
       this.Id = id;
    }

    public string Model { get; private set; }
    public string Id { get;  set; }
}

