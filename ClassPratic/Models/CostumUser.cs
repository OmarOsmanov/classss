using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPratic.Models
{
    public class CostumUser:IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Employe> Employes { get; set; }

    }
}
