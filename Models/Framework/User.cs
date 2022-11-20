namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public Guid UserId { get; set; }

        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Phone { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string VerifyCode { get; set; }

        public bool? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string RoleCode { get; set; }

        public string Token { get; set; }
    }
}
