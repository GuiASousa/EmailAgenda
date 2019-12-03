using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public String Cadencia { get; set; }
        public DateTime NextExec{ get; set; }
        public DateTime LastExec { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
