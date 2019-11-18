using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ville")]
public class Ville
{
    [Key]
    public int VilleId { get; set; }

    [Required(ErrorMessage ="Le nom de la ville est obligatoire")]
    public string Nom { get; set; }

    [ForeignKey("pays")]
    public int PaysId { get; set; }

}
