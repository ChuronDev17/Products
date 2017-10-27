using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    public class Product
    {
        [Key]
        public int  ProductId { get; set; }


        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]  //Requerido

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} character lenght")] //El tamanio maximo y el mensaje en caso de que no sea asi.

        [Index("Product_Description_Index", IsUnique = true)]

        public string Description{ get; set; }


        [Required(ErrorMessage = "The field {0} is required")]  //Requerido

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)] //Para el signo de pesos.
        public decimal Price { get; set; }


        [Display(Name ="Is Active?")]  //El display para que me aparezca asi en la pagina.
        public bool IsActive { get; set; }


        public double Stock { get; set; }


        [Display(Name ="Last Purchase")]
        [DataType(DataType.Date)]
        public DateTime LastPurchase { get; set; }


        [DataType(DataType.MultilineText)] //Para que cuando escriba comentarios, pueda ser multilinea uno debajo de otro.
        public string Remarks { get; set; }




        public virtual Category Category { get; set; }
    }
}
