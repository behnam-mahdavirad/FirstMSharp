﻿using MSharp;

namespace Domain
{
    public class Category : EntityType
    {
        public Category()
        {
            String("Name").Mandatory(); // Mandatory means it is required
        }
    }
}