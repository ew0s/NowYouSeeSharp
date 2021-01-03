using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t5
{
    public class Note
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public bool IsAlertNeeded { get; set; }

        public Note(int id, string body, DateTime date, bool isAlertNeeded)
        {
            Id = id;
            Body = body;
            Date = date;
            IsAlertNeeded = isAlertNeeded;
        }
    }
}
