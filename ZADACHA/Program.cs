using System;
using System.Collections.Generic;

namespace ZADACHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> team = new List<string> { "Антон", "Вася", "Коля", "Алиса", "Настя" };

            Project project = new Project("Сделать приложение", DateTime.Now.AddDays(10), "Алексей", "Вася");

            foreach (string teamMember in team)
            {
                Task task = new Task("Сделай приложение", DateTime.Now.AddDays(5), teamMember);
                project.Tasks.Add(task);
            }
            project.Status = Status.InProgress;
            foreach (Task task in project.Tasks)
            {
                task.Assignee = task.Initiator;
                task.Status = Status.InProgress;
                task.Reports.Add(new Report("Задание выполнено без ошибок", DateTime.Now, task.Assignee));
                task.Status = Status.Completed;
            }
            project.Status = Status.Closed;
            Console.WriteLine("Проект завершен");
        }
    }
}
