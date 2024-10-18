using System;
using System.Collections.Generic;

namespace _2302C2FirstAPI.Models;

public partial class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Skills { get; set; } = null!;

    public int JerseyNo { get; set; }

    public int TeamId { get; set; }

    public virtual Team Team { get; set; } = null!;
}
