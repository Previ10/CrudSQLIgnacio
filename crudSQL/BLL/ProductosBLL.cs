using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudSQL.BLL
{
    internal class ProductosBLL
    {

        public int ID { get; set; }
        public string NombreProducto{ get; set; }
        public string DescripcionProducto { get; set; }

        public decimal Precio { get; set; }
        public int IDprecio { get; set; }



    }
}
