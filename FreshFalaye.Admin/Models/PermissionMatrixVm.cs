namespace FreshFalaye.Admin.Models
{
    class PermissionMatrixVm
    {
        public string Module { get; set; } = "";

        public Guid? ViewId { get; set; }
        public Guid? CreateId { get; set; }
        public Guid? EditId { get; set; }
        public Guid? DeleteId { get; set; }

        public bool View { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }

        public bool All
        {
            get => View && Create && Edit && Delete;
            set
            {
                View = value;
                Create = value;
                Edit = value;
                Delete = value;
            }
        }
    }

}
