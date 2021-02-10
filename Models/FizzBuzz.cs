using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzz
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName="NVARCHAR(10)")]
        public string fizzBuzzData {get; set;}

    }
}
