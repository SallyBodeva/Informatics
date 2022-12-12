using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

public class RandomList : List<string>
{
    public string RandomString()
    {
        Random random = new Random();
        int index = random.Next(0,base.Count-1);
        base.RemoveAt(index);
        return base[index];
    }
  
}

