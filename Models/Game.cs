using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "Maximum 1000 characteristics")]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string MinRequirements { get; set; }

        public int Downloads { get; set; }

        [ForeignKey("Category")]
        public virtual Category Cat { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
