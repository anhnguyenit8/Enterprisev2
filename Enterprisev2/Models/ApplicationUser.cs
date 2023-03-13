using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Enterprisev2.Static;

namespace Enterprisev2.Models
{
    public class ApplicationUser : IdentityUser
    {
       /* [Key]
        public UserRoles RoleId { get; set; } = UserRoles.RoleId;
        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }*/
        public Department Department { get; set; }
        public List<Post> Posts { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
    }
}
