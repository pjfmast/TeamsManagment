using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsManagment.Models;

public class Team
{
    public int Id { get; set; }
    public required string Group { get; set; }
    public required string Title { get; set; }

    public ICollection<Member> Enrolled { get; } = null!;
}