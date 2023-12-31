//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Marche.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.DetailsCommandes = new HashSet<DetailsCommande>();
        }
    
        public int CommandeID { get; set; }
        public System.DateTime DateCommande { get; set; }
        public decimal MontantTotal { get; set; }
        public Nullable<int> FournisseurID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> MarcheID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual March March { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsCommande> DetailsCommandes { get; set; }
    }
}
