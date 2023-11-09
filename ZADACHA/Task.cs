using System;
using System.Collections.Generic;

namespace ZADACHA
{
    internal class Task
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string Assignee { get; set; }
        public Status Status { get; set; }
        public List<Report> Reports { get; set; }

        public Task(string description, DateTime deadline, string initiator)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            Assignee = null;
            Status = Status.Assigned;
            Reports = new List<Report>();
        }
    }
}
