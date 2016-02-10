﻿using System;
using FSharpModel;
using Nest;

namespace TestModel
{
    public class User
    {
        [ElasticProperty(OmitNorms = true, Index = FieldIndexOption.NotAnalyzed)]
        public String Email { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }

        public bool? Enabled { get; set; }

        public bool Active { get; set; }

        public UserType Type { get; set; }

        public DateTime CreationTime { get; set; }

    }

}