//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Like
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public Nullable<bool> Thumb_up { get; set; }
        public int Tweet_id { get; set; }
    
        public virtual Tweet Tweet { get; set; }
    }
}
