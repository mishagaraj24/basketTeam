using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basKet.Models
{
    public class BaseUser
    {
        public string ConnectionId { get; set; }

        [Required]
        public string Username { get; set; }
    }

}