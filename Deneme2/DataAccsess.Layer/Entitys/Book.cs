﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Layer.Entitys
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }
    }
}
