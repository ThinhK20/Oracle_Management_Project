using System;
using System.Collections.Generic;

namespace Oracle_Management_Library.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Tennv { get; set; } = null!;

    public string Phai { get; set; } = null!;

    public DateTime Ngaysinh { get; set; }

    public string Diachi { get; set; } = null!;

    public string Sodt { get; set; } = null!;

    public decimal Luong { get; set; }

    public decimal Phucap { get; set; }

    public string? Vaitro { get; set; }

    public string? Manql { get; set; }

    public string? Phg { get; set; }

    public virtual ICollection<Nhanvien> InverseManqlNavigation { get; } = new List<Nhanvien>();

    public virtual Nhanvien? ManqlNavigation { get; set; }

    public virtual ICollection<Phancong> Phancongs { get; } = new List<Phancong>();

    public virtual Phongban? PhgNavigation { get; set; }

    public virtual ICollection<Phongban> Phongbans { get; } = new List<Phongban>();
}
