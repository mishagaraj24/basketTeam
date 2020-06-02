using basket.Controllers;
using basKet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace basKet.Data
{
  
        public class Teams : DbContext
        {
            public DbSet<Comanda> Comandi { get; set; }
        }
   
}