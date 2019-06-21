using System;
using System.Collections.Generic;
using System.Text;

namespace Producto.Model
{
    
   using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    public class Producto
        {
            [Key]
        [JsonProperty(PropertyName = "productId")]
        public int ProductId { get; set; }

            [Required]

        [JsonProperty(PropertyName = "name")]
          public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }
        }
    }

