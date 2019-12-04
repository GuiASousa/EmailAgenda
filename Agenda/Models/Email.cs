using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Email
    {
        [Key]
        public int ID { get; set; }
        public string Contato { get; set; }
    }
}