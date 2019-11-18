using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("adresse")]
public class Adresse
{
    [Key]
    public int AdresseId { get; set; }

    [Column("rue"), Required]
    public string Rue { get; set; }

    [Display(Name = "Code postal"), Required]
    public string CodePostal { get; set; }

    [ForeignKey("Ville")]
    public int VilleId { get; set; }
    public virtual Ville Ville { get; set; }

}