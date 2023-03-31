using System;
using System.Collections.Generic;

namespace Oracle_Management_Library.Models;

public partial class Phancong
{
    public string Manv { get; set; } = null!;

    public string Mada { get; set; } = null!;

    public DateTime? Thoigian { get; set; }

    public virtual Dean MadaNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
