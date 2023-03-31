using System;
using System.Collections.Generic;

namespace Oracle_Management_Library.Models;

public partial class Phongban
{
    public string Mapb { get; set; } = null!;

    public string? Tenpb { get; set; }

    public string? Manv { get; set; }

    public virtual ICollection<Dean> Deans { get; } = new List<Dean>();

    public virtual Nhanvien? ManvNavigation { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; } = new List<Nhanvien>();
}
