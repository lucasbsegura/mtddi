﻿using System;

namespace MeuTodoCoreWebApi.Infrastructure.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
