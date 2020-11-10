using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePractice.Models
{
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
        public string Name { get; set; }
    }
}
