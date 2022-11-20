namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        public Guid RoleId { get; set; }

        [StringLength(250)]
        public string RoleName { get; set; }

        [StringLength(10)]
        public string RoleCode { get; set; }
    }
}
