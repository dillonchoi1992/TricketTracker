using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketTrackerModel
{
    public class Ticket
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string Issue { get; set; }
        [Required, StringLength(2000)]
        public string Description { get; set; }
        [Required, StringLength(2982)]
        public string Resolution {get; set; }
        [Required]
        public DateTime? CratedDate { get; set; }
        [Required]
        public DateTime? StartedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        [Required]
        public Prioriy TicketPrioority { get; set; }
        [Required, StringLength(64)]
        public Status TicketStatus { get; set; }
        public string TicketCreatedBy { get; set; }
        public string TechAssigned { get; set; }
        [Required, Range(0, 500)]
        public double HoursOfLabor { get; set; }
        [Required]
        public string StakeHoldersEmails { get; set; }
        public virtual Category? Category { get; set; } 
        [Required]
        public int CategoryId { get; set; }




    }
}