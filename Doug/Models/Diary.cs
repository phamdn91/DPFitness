namespace Doug.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diary")]
    public partial class Diary
    {
        public int Id { get; set; }

        public int? Calorie { get; set; }

        public int? Breakfast { get; set; }

        public int? Lunch { get; set; }

        public int? Dinner { get; set; }

        public int? Snacks { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDateTime { get; set; }
    }
}
