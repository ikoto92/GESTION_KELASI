//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GESTION_KELASI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcourscolaires
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parcourscolaires()
        {
            this.etudiant = new HashSet<etudiant>();
        }
    
        public string codeInfScol { get; set; }
        public string DipEntre { get; set; }
        public string classe { get; set; }
        public string AnEt { get; set; }
        public string DerNivEt { get; set; }
        public string DerEstScol { get; set; }
        public string Profil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<etudiant> etudiant { get; set; }
    }
}
