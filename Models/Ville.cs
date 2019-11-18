using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ville")]
public class Ville
{
    [Key]
    [Column("ville_id")]
    public int VilleId { get; set; }

    [Column("nom"), Required]
    public string Nom { get; set; }

    [Column("pays_id"), ForeignKey("Pays")]
    public int PaysId { get; set; }
    public Pays Pays { get; set; }

}
