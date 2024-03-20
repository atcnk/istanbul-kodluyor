using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // Erisim Belirteci -> public -> tum dis dunyaya acik
    // private -> ilgili nesneye ozel
    public class Product
    {
        // geri donus tipi olmayan, nesne ismiyle ayni olan 
        // newlendiginde calisacak method 
        // eger ilgili class hicbir ctor tanimi icermiyor ise
        // bos parametreli ctor default olarak eklenir
        // parametreli ctor varken bos parametreli ctor ezilir
        // genelde classlarda bu ikisi de olur ki kullanici isterse herhangi birini kullanabilsin

        // All args ctor
        public Product(int id, string name)
        {
            
        }

        // No args ctor 
        public Product()
        {

        }
        public int Id { get; set; } // field 
        public string Name { get; set; }
    }
}
