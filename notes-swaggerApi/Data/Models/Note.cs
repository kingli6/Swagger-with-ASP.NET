using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace notes_swaggerApi.Data.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Value { get; set; }

    }
}