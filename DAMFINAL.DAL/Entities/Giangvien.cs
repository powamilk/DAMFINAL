using System;
using System.Collections.Generic;

namespace DAMFINAL.DAL.Entities;

public partial class Giangvien
{
    public string Magv { get; set; } = null!;

    public string? Tengv { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public int? Trangthai { get; set; }

    public virtual ICollection<Monhoc> Monhocs { get; set; } = new List<Monhoc>();
}
