﻿using MSharp;

namespace Domain
{
    public class Manufacturer : EntityType
    {
        public Manufacturer()
        {
            String("Name").Mandatory(value: true).Unique(value: true);
        }
    }
}