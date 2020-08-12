namespace Doug.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        public int Id { get; set; }

        public int? WeightLifting { get; set; }

        public int? Running { get; set; }

        public int? Walking { get; set; }

        public int? Other { get; set; }

        public string Username { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDateTime { get; set; }
    }
}
