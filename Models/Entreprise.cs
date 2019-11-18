using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table ("entreprise")]
public class Entreprise
{
    [Column("entreprise_id"), Required]
    public int EntrepriseId { get; set; }

    [Column("nom"), Required]
    public string Nom { get; set; }

    [Column("adresse_id"), Required]
    public int AdresseId { get; set; }

}
