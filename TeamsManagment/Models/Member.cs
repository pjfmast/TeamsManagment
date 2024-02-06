using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsManagment.Models;

public class Member
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public Team Team { get; set; } = null!;
    public int? TeamId { get; set; }

}