
namespace Products.Domain
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {


        [Key]
        public int  CategoryId { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]  //Requerido

        [MaxLength(50, ErrorMessage ="The field {0} only can contain {1} character lenght")] //El tamanio maximo y el mensaje en caso de que no sea asi.

        [Index("Category_Description_Index", IsUnique = true)]
        public  string Description { get; set; }


        public virtual ICollection <Product> Products { get; set; }


        
    }
}
