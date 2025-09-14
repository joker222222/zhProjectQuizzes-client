using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateOnly? DateReg { get; set; }

    public virtual ICollection<Qwiz> Qwizs { get; set; } = new List<Qwiz>();
}
