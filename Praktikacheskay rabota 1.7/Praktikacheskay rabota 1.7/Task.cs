﻿namespace DailyPlanner
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public DateTime Date { get; set; }
        
        public bool IsCompleted { get; set; }
    }
}