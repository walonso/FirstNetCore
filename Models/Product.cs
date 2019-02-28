using System.ComponentModel.DataAnnotations;

//https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/3-add-data-store

namespace RetailApi.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(minimum: 0.01, maximum: (double) decimal.MaxValue)]
        public decimal Price { get; set; }
    }
}
