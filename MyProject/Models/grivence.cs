namespace MyProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("grivence")]
    public partial class grivence
    {
        public int Id { get; set; }
        [Required]
       // [DisplayName("Name")]
        [StringLength(50)]
        public string name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string gender { get; set; }
        
        [Required]
        [StringLength(50)]
        public string address { get; set; }
       
        [Required]
        public string contactno { get; set; }

        [StringLength(50)]
        [Required]
        public string officename { get; set; }
        [Required]
        [StringLength(50)]
        public string officeaddress { get; set; }
        [Required]
        [StringLength(50)]
        public string category { get; set; }
        [Required]
        [StringLength(50)]
        public string description { get; set; }
    }
}
