using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TareaSQLite.Model
{
    [Table("Ventas")]
    public class Ventas
    {
        [PrimaryKey, AutoIncrement]
        public int VentasId { get; set; }

        public string Contents { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Ventas()
        {
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
        }
    }
}
