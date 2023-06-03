using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_myconference.Models;

public class Sessions
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string StartTimeDisplay => $"{Start:t}";
    public string DayDisplay => $"{Start:MMM} {Start:d}";
    public Speaker Speaker { get; set; } = new Speaker
    {
        Name = "James Montemagno",
        Company = "Microsoft",
        Description = "James Montemagno is a Principal Lead Program Manager for .NET Community at Microsoft11 with Xamarin.",
        Title = "Pricipal Lead Program Manager"
    };
}
