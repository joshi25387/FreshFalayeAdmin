namespace FreshFalaye.Admin.Models
{
    public class UnitDto
    {
        public int UnitId { get; set; }
        public string UnitCode { get; set; } = "";
        public string UnitName { get; set; } = "";
        public bool DecimalAllowed { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
