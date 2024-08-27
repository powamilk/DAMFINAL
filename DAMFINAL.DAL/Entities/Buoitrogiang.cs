using System;
using System.Collections.Generic;

namespace DAMFINAL.DAL.Entities;

public partial class Buoitrogiang
{
    public string Mabtg { get; set; } = null!;

    public int? Sothutu { get; set; }

    public int? Trangthai { get; set; }

    public string? Mamh { get; set; }

    public string? Matg { get; set; }

    public virtual Monhoc? MamhNavigation { get; set; }

    public virtual Trogiang? MatgNavigation { get; set; }
}
