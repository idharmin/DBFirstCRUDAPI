namespace DBFirstCRUDAPI.Models;

public partial class Student
{
    [Key]
    public int Sid { get; set; }
    public string? Sname { get; set; }
    public int? Sstd { get; set; }
    public string? Sstream { get; set; }
    public string? Sstatus { get; set; }
}
