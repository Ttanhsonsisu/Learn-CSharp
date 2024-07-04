using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW.model.entity
{
    [Table("myproduct")]
    public class Product
    {

       // [Key]
        public int IDProduct { get; set; }

        [Required] // atrri not null
        [StringLength(255)]
        public string NameProduct {  get; set; }
        [Column("quantityProdcut" , TypeName = "bigint")]
        public int Quantity { get; set; }
        //fk
        //[ForeignKey("cateID")]
        public virtual Category Category { get; set; }
    
    }
}
