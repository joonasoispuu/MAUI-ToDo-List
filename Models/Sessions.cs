using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_myconference.Models
{
    internal class Sessions
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimeDisplay => $"{Start:t}";
        public string DayDisplay => $"{Start:MMM} {Start:d}";
    }
}
