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
    
    public partial class Entreprise
    {
        public int id_entreprise { get; set; }
        public string nom_entreprise { get; set; }
        public Nullable<int> ref_fournisseur { get; set; }
        public string adress_entreprise { get; set; }
        public string service_commercial { get; set; }
        public string service_apres_vente { get; set; }
        public string service_compta { get; set; }
        public string service_gestion_produit { get; set; }
        public int chiffre_affaire { get; set; }
        public int num_facture { get; set; }
        public int num_produit { get; set; }
    
        public virtual Catalogue_Produits Catalogue_Produits { get; set; }
        public virtual Commande Commande { get; set; }
    }
}
