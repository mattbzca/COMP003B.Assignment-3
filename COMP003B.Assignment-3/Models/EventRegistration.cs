using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace COMP003B.Assignment_3.Models
{
    public class EventRegistration
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string EventCode { get; set; }

        [Required]
        [Range(1, 10)]
        public int Tickets {  get; set; }

        public string? ReferralCode {  get; set; }
    }
}
