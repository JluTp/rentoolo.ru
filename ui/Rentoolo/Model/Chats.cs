//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chats
    {
        public long Id { get; set; }
        public System.Guid OwnerId { get; set; }
        public string ChatName { get; set; }
        public short ChatType { get; set; }
    }
}
