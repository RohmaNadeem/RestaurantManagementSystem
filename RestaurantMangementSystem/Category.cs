using System;

namespace RestaurantMangementSystem
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // For display in ListBox
        public override string ToString() => Name;
    }
}