using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ville")]
public class Ville
{
    [Key]
    public int VilleId { get; set; }

    [Column("nom"), Required(ErrorMessage ="Le nom de la ville est obligatoire")]
    public string Nom { get; set; }

    [Column("pays_id"), ForeignKey("Pays"), Required]
    public int PaysId { get; set; }
    public virtual Pays Pays { get; set; }

}