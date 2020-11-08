using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePractice.Models
{
    [Table("compony")]
    public class Company
    {
        public Company()
        {
        }

        public Company(string names)
        {
            Names = names;
        }

        public int Id { get; set; }
        
        [Column(name: "name")]
        public string Names { get; set; }
    }
}
