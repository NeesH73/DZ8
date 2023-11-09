using System;

namespace ZADACHA
{
    internal class Report
    {
        public string Text { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Performer { get; set; }

        public Report(string text, DateTime completionDate, string performer)
        {
            Text = text;
            CompletionDate = completionDate;
            Performer = performer;
        }
    }
}
