using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Dtos
{
    [Keyless]
    public class AccountUpdateDto
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