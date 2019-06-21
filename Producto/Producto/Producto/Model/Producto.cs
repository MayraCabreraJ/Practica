using System;
using System.Collections.Generic;
using System.Text;

namespace Producto.Model
{
    
   using System.ComponentModel.DataAnnotations;

   public class Producto
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            [Display(Name = "Product Name")]
            public string Name { get; set; }

            public double Price { get; set; }
        }
    }

