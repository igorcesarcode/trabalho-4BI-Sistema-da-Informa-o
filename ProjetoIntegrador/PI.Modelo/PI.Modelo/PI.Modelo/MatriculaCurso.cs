//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatriculaCurso
    {
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public System.DateTime DataMatricula { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Curso Curso { get; set; }
    }
}