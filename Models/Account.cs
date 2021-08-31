using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Models
{
    [Keyless]
    public class Account
    {
        [Required]
        public string User { get; set; }

        [Required]
        public int AccountBalance { get; set; }

        [Required]
        public string DateOfPayment { get; set; }

        [Required]
        public int AmountOfPayment { get; set; }

        [Required]
        public string Status { get; set; }
    }
}