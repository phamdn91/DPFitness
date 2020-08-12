namespace Doug.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stat
    {
        public int Id { get; set; }

        public int? Age { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public int? BodyFat { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDateTime { get; set; }

        public string Username { get; set; }
    }
}
