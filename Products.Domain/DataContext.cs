using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    public class DataContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }


        public DataContext() :base("DefaultConnection")
        {
            
        }
        //Cada que usemos la clase DataContext se va a conectar a la Base de datos, si no exista
        // la crea.



    }
}
