using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Qwiz
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public string? Image { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
