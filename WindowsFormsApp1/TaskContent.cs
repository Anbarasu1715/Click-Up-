using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TaskContent
    {
        public string ProjectName { get; set; }
        private string Duration;

        public string TaskName { get; set; }
        public string Assignor { get; set; }
        public System.Windows.Forms.Label Status { get; set; }
        public string DueDate { get; set; }
        public System.Windows.Forms.Label Priority { get; set; }
        public string LastModified { get; set; }
        public Button View { get; set; }


        public TaskContent(string projectName, string taskName, string assignor, string dueDate, string lastModified,System.Windows.Forms.Label statusLabel, System.Windows.Forms.Label priorityLabel, Button ViewBtn)
        {
            ProjectName = projectName;
            TaskName = taskName;
            Assignor = assignor;
            DueDate = dueDate;
            LastModified = lastModified;
            Status = statusLabel;
            Priority = priorityLabel;
            View = ViewBtn;
        }

        public string GetDuration()
        {
            return Duration;
        }
        public void SetDuration(string start, string end)
        {
            Duration = start + " - " + end;
        }
    }
}
