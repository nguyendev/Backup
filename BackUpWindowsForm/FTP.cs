//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackUpWindowsForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class FTP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FTPServer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FolderSave { get; set; }
        public Nullable<int> Schedule { get; set; }
        public Nullable<int> Type { get; set; }
        public string DatabaseName { get; set; }
        public Nullable<System.DateTime> StartDT { get; set; }
    }
}
