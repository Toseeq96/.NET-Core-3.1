using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
       
        [Required]
        public DateTime CreatedDate { get; set; }
       
        [Required]
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        
        [Required]
        public bool IsAtive { get; set; }
    }
}
