using System;
using System.Collections.Generic;

#nullable disable

namespace kipasCalisanlar.Models
{
    public partial class Elemanlar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Position { get; set; }
        public DateTime Hiredate { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string Adress { get; set; }
    }
}
