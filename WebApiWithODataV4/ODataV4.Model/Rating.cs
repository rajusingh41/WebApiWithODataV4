﻿using System.ComponentModel.DataAnnotations;

namespace ODataV4.Model
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public int Value { get; set; }
        [Required]
        public Person RatedBy { get; set; }
    }
}
