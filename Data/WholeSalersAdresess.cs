//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DressMakerPol.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WholeSalersAdresess
    {
        public decimal IdWholesaler { get; set; }
        public decimal IdAdress { get; set; }
        public decimal IdWholeSalersAdreses { get; set; }
    
        public virtual Adresses Adresses { get; set; }
        public virtual WholeSalers WholeSalers { get; set; }
    }
}
