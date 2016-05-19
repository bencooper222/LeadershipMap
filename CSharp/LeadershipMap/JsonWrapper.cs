﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeadershipMap
{
    public abstract class JsonWrapper
    {
       
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        } 
    }
}
