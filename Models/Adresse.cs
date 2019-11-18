using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("adresse")]
public class Adresse
{
    [Key]
    public int AdresseId { get; set; }

    [Required(ErrorMessage = "La rue est obligatoire")]
    public string Rue { get; set; }

    [Display(Name = "Code postal"), Required]
    public string CodePostal { get; set; }

    [ForeignKey("ville")]
    public int VilleId { get; set; }

    public virtual Ville Ville { get; set; }

}
