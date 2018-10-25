using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroProj.Models
{
    public class SuperheroProj
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterName { get; set; }
        public string Ability { get; set; }
        public string SecondAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}