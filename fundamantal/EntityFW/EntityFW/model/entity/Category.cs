using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW.model.entity
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int IDCategory { get; set; }

        [Key] 
        public int testFk2 { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
