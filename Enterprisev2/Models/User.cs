using Enterprisev2.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Enterprisev2.Enums;

namespace Enterprisev2.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public RoleStatus RoleId { get; set; } = RoleStatus.RoleId;
        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
