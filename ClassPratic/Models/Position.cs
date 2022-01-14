using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPratic.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required(ErrorMessage = "Name Yazin")]
        public string Name { get; set; }
        public List<Employe> Employes { get; set; }
    }
}
