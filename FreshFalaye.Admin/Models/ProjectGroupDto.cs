namespace FreshFalaye.Admin.Models
{
    public class ProductGroupDto
    {
        public int ProductGroupId { get; set; }
        public int BranchId { get; set; }
        public string GroupName { get; set; } = null!;
        public int? ParentGroupId { get; set; }
    }
}
