namespace DBFirstCRUDAPI.DBContext
{
    public partial class Teacher
    {
        [Key]
        public int Tid { get; set; }
        public string? Tname { get; set; }
        public string? Tsubject { get; set; }
        public string? Tqualification { get; set; }
        public string? Tstatus { get; set; }
    }
}
