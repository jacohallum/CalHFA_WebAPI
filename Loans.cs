using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CalHFA.Model
{
    [Table("Loan Information")]
    public partial class Loans
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Compliance_Loans_In_Line")]
        [StringLength(50)]
        public string ComplianceLoansInLine { get; set; }
        [Column("Compliance_Date")]
        [StringLength(50)]
        public string ComplianceDate { get; set; }
        [Column("Suspense_Loans_In_Line")]
        [StringLength(50)]
        public string SuspenseLoansInLine { get; set; }
        [Column("Suspense_Date")]
        [StringLength(50)]
        public string SuspenseDate { get; set; }
        [Column("Post_Closing_Loans_In_Line")]
        [StringLength(50)]
        public string PostClosingLoansInLine { get; set; }
        [Column("Post_Closing_Date")]
        [StringLength(50)]
        public string PostClosingDate { get; set; }
        [Column("Post_Closing_Suspense_Loans_In_Line")]
        [StringLength(50)]
        public string PostClosingSuspenseLoansInLine { get; set; }
        [Column("Post_Closing_Suspense_Date")]
        [StringLength(50)]
        public string PostClosingSuspenseDate { get; set; }
       
        [Column("date_created", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
    }
}
