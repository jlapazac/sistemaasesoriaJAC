//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace platonWSREST.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class horario
    {
        public int id { get; set; }
        public string codhorario { get; set; }
        public string codciclo { get; set; }
        public string codcurso { get; set; }
        public string codseccion { get; set; }
        public System.DateTime finicio { get; set; }
        public System.DateTime ffinal { get; set; }
        public string estado { get; set; }
    }
}