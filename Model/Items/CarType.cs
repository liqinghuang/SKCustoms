﻿using Infrastruture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CarType : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
