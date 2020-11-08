using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime TimePublished { get; set; }

        public bool IsComplite { get; set; } = false;
    }
}
