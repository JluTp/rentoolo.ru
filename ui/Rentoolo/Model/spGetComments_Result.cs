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
    
    public partial class spGetComments_Result
    {
        public int Id { get; set; }
        public System.Guid UserId { get; set; }
        public int AdvertId { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public int Type { get; set; }
    }
}
