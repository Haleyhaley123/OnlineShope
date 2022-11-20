namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        [Key]
        [Column(Order = 0)]
        public Guid ImageId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Path { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Url { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string FileType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileSize { get; set; }
    }
}
