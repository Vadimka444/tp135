﻿namespace ElectronicsStore.Models
{
    public class Supplier
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public LinkedList<Batch> Batches { get; set; } = new();
    }
}
