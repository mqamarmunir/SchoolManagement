//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AbpSetting
    {
        public long Id { get; set; }
        public Nullable<int> TenantId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<long> LastModifierUserId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
    
        public virtual AbpUser AbpUser { get; set; }
    }
}