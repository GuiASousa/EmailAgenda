using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Grupo
    {
        [Key]
        public int ID { get; set; }
        public List<Email> emails { get; set; }
    }
}