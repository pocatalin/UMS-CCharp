//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfessorCourseStudent
    {
        public string ProfessorID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Student Student { get; set; }
    }
}
