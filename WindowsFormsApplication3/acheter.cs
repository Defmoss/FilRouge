//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication3
{
    using System;
    using System.Collections.Generic;
    
    public partial class acheter
    {
        public int num_produit { get; set; }
        public int num_fournisseur { get; set; }
        public int num_fournisseur_Fournisseur { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Fournisseur Fournisseur1 { get; set; }
        public virtual Catalogue_Produits Catalogue_Produits { get; set; }
    }
}
