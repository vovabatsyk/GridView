using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Log
    {

        public string Type { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Source { get; set; }
        public string Error { get; set; }

        public Log(string type, string date, string time, string source, string error)
        {
            Type = type;
            Date = date;
            Time = time;
            Source = source;
            Error = error;
        }


    }

    public  class LogsList: List<Log>
    {
        public LogsList()
        {

            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "An example of error is when a mistake leads you to come to the wrong collusion and you continue to believe this incorrect conclusion."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A mistake; an accidental wrong action or a false statement not made deliberately."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A mistake; an accidental wrong action or a false statement not made deliberately."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "An example of error is when a mistake leads you to come to the wrong collusion and you continue to believe this incorrect conclusion."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A mistake; an accidental wrong action or a false statement not made deliberately."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
            this.Add(new Log("Error", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A mistake; an accidental wrong action or a false statement not made deliberately."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "An example of error is when a mistake leads you to come to the wrong collusion and you continue to believe this incorrect conclusion."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A mistake; an accidental wrong action or a false statement not made deliberately."));
            this.Add(new Log("Warning", DateTime.Now.ToString("d"), DateTime.Now.ToString("T"), "Configuration reader", "A play which is scored as having been made incorrectly."));
        }
    }
}
