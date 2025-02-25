using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Shared
{
    public class ProductProperty
    {
        public List<ProductKeyValue> keyValues {get; set;} = new List<ProductKeyValue>();
        public Product product {get; set;}
    }

    public class ProductKeyValue{
        public int ProductId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
