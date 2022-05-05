using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [MaxLength(12)]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("BankName")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }


        [MaxLength(12)]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage ="This field is required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    
}
}
