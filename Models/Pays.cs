using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pays")]
public class Pays
{
    [Key]
	[Column("pays_id")]
	public int PaysId { get; set; }

    [Display(Name = "Nom"), Column("nom"), Required(ErrorMessage = "Un nom est obligatoire")]
    public string Nom { get; set; }

    [Display(Name = "Code Pays"), Column("codes_pays"), Required(ErrorMessage = "Le code pays est obligatoire")]
    public string CodesPays { get; set; }

    [Display(Name = "Format tva"), Column("format_tva"), Required(ErrorMessage = "Le format tva est obligatoire")]
    public string FormatTva { get; set; }

    [Display(Name = "Préfixe téléphonique"), Column("prefix_tel"), Required(ErrorMessage = "Un préfixe téléphonique est obligatoire")]
    public string PrefixTel { get; set; }

}
