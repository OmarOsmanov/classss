using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPratic.Models
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required(ErrorMessage = "FullName Yazin")]
        public string FulName { get; set; }
        [MaxLength(100), Required(ErrorMessage = "Email Yazin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age Yazin")]
        public int Age { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [ForeignKey("CustumUser")]
        public string CustumUserId { get; set; }  




    }
}
