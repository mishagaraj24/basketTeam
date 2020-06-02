using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace basKet.Models

{
    public class Comanda
    {
        public int Id { get; set; }

        [Display(Name = "NameTeam")]
        public string NameTeam { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Player3 { get; set; }
        public string Player4 { get; set; }
        public string Player5 { get; set; }

    }
}