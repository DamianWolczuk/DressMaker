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
    
    public partial class IndClientsAdresses
    {
        public decimal IdClient { get; set; }
        public decimal IdAdress { get; set; }
        public decimal IdClientsAdresses { get; set; }
    
        public virtual Adresses Adresses { get; set; }
        public virtual IndClients IndClients { get; set; }
    }
}
