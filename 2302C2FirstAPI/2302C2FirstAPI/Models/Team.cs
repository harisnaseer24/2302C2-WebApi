using System;
using System.Collections.Generic;

namespace _2302C2FirstAPI.Models;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
