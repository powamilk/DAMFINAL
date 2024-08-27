using System;
using System.Collections.Generic;

namespace DAMFINAL.DAL.Entities;

public partial class Monhoc
{
    public string Mamh { get; set; } = null!;

    public string? Tenmh { get; set; }

    public int? Sotinchi { get; set; }

    public int? Trangthai { get; set; }

    public string? Magv { get; set; }

    public virtual ICollection<Buoitrogiang> Buoitrogiangs { get; set; } = new List<Buoitrogiang>();

    public virtual Giangvien? MagvNavigation { get; set; }
}
