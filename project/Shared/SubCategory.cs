using System.ComponentModel.DataAnnotations.Schema;

namespace project.Shared
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId {get; set;}
        // public Category Category {get; set;}
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool Deleted { get; set; } = false;
        public bool Visible { get; set; } = true;
        // [NotMapped]
        // public bool Editing { get; set; } = false;
        // [NotMapped]
        // public bool IsNew { get; set; } = false;

        // public List<CategoryCategories> CategoryCategories {get; set;}
    }
}
