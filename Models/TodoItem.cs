﻿namespace PlanifyAPI.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Planned, Completed
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
