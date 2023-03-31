namespace Oracle_Management_Library.Models;

public partial class Dean
{
    public string Mada { get; set; } = null!;

    public string? Tenda { get; set; }

    public DateTime? Ngaybd { get; set; }

    public string? Mapb { get; set; }

    public virtual Phongban? MapbNavigation { get; set; }

    public virtual ICollection<Phancong> Phancongs { get; } = new List<Phancong>();
}
