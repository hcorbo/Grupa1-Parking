using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class Korisnik
    {
        [ScaffoldColumn(false)]
        public String Id{ get; set; } 

        [Required]
        public String Ime { get; set; }

        [Required]
        public String Prezime { get; set; }

        [EmailAddress, Required]
        public String Email{ get; set; }

        public DateTime DatumRodjenja{ get; set; } = new DateTime();

        [Required]
        public String Password { get; set; }

        [Required]
        public Boolean JeAktivan { get; set; }

        public DateTime DatumKreiranja { get; set; } = new DateTime();
        public String Uloga { get; set; }
    }
}
