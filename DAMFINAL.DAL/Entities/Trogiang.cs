using System;
using System.Collections.Generic;

namespace DAMFINAL.DAL.Entities;

public partial class Trogiang
{
    public string Matg { get; set; } = null!;

    public string? Tentg { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public int? Trangthai { get; set; }

    public virtual ICollection<Buoitrogiang> Buoitrogiangs { get; set; } = new List<Buoitrogiang>();
}
