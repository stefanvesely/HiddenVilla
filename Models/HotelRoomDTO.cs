using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We need a room name")]
        public string Name { get; set; }

        [Required]
        public int Occupancy { get; set; }

        [Range(1, 3000, ErrorMessage = "We need a Regular Rate between 1 and 3000")]
        [Required]
        public double RegularRate { get; set; }

        public string Details { get; set; }
        public string SqFt { get; set; }

        public virtual ICollection<HotelRoomImageDTO> HotelRoomImages { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}