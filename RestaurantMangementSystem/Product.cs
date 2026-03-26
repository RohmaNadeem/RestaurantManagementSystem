using System;
using System.Drawing;

namespace RestaurantMangementSystem
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int StockQuantity { get; set; }
        public string Unit { get; set; }
        public bool IsAvailable { get; set; }
        public byte[] ProductImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }

        public decimal ProfitMargin => Price - Cost;
        public decimal ProfitPercentage => Cost > 0 ? ((Price - Cost) / Cost) * 100 : 0;

        public Image GetImage()
        {
            if (ProductImage != null && ProductImage.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(ProductImage))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public void SetImage(Image image)
        {
            if (image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ProductImage = ms.ToArray();
                }
            }
            else
            {
                ProductImage = null;
            }
        }
    }
}