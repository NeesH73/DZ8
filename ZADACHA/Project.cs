using System;
using System.Collections.Generic;

namespace ZADACHA
{
    internal class Project
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string ProjectManager { get; set; }
        public List<Task> Tasks { get; set; }
        public Status Status { get; set; }

        public Project(string description, DateTime deadline, string initiator, string projectManager)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            ProjectManager = projectManager;
            Tasks = new List<Task>();
            Status = Status.Project;
        }
    }
}
