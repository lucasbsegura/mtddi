using System;

namespace MeuTodoCoreWebApi.Models
{
    public class TodoViewModel
    {
        public int Id { get; }
        public string Type { get; set; }
        public bool Done { get; set; }
        public DateTime Date { get; } 
    }
}
