﻿namespace WebApplication1.Models
{
    public class Transfers
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Currency { get; set; }
        public int Direction { get; set; }
    }
}
