//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassportManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OldPassportData
    {
        public string PassportNumber { get; set; }
        public string UserID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string TypeOfService { get; set; }
        public string BookletType { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int Amount { get; set; }
        public string ReasonForReIssue { get; set; }
    }
}