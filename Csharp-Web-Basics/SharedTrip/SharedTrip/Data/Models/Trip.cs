﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTrip.Data.Models
{
    public class Trip
    {
        public Trip()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserTrips = new HashSet<UserTrip>();
        }
        public string Id { get; set; }
        [Required]
        public string StartPoint { get; set; }
        [Required]
        public string EndPoint { get; set; }

        public DateTime DepartureTime { get; set; }

        public int Seats { get; set; }
        [MaxLength(80)]
        [Required]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public ICollection<UserTrip> UserTrips { get; set; }


        /*⦁	Has an Id – a string, Primary Key
        ⦁	Has a StartPoint – a string (required)
        ⦁	Has a EndPoint – a string (required)
        ⦁	Has a DepartureTime – a datetime (required) 
        ⦁	Has a Seats – an integer with min value 2 and max value 6 (required)
        ⦁	Has a Description – a string with max length 80 (required)
        ⦁	Has a ImagePath – a string
        ⦁	Has UserTrips collection – a UserTrip type
        */
    }
}
