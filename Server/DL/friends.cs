//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Server.BL.Contracts;

namespace Server.DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class friends : IEntity
    {
        public int ID { get; set; }
        public int U_ID { get; set; }
        public int F_ID { get; set; }
    
        public virtual user user { get; set; }
    }
}
