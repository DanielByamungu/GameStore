//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CreditCard
    {
        public string Code { get; set; }
        public string EnglishName { get; set; }
        public string FrenchName { get; set; }
        public byte CardNumberLength { get; set; }
        public string CardNumberPrefixList { get; set; }
    }
}
