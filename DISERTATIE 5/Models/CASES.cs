//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DISERTATIE_5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CASES
    {
        public long CASE_ID { get; set; }
        public Nullable<long> CLIENT_ID { get; set; }
        public Nullable<decimal> BATCH_NUMBER { get; set; }
        public string BATCH_CODE { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string ZONE { get; set; }
        public Nullable<decimal> OWNER { get; set; }
        public string STATUS_PA { get; set; }
        public Nullable<long> NR_PA_MADE { get; set; }
        public Nullable<long> NR_PA_KEPT { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
    
        public virtual CLIENTS CLIENTS { get; set; }
    }
}