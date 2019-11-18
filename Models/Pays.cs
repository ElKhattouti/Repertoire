using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pays")]
public class Pays
{
    [Key]
	[Column("pays_id")]
	public int PaysId { get; set; }

    [Display(Name = "Nom"), Column("nom"), Required]
    public string Nom { get; set; }

    [Display(Name = "Code Pays"), Column("codes_pays"), Required]
    public string CodesPays { get; set; }

    [Display(Name = "Format tva"), Column("format_tva"), Required]
    public string FormatTva { get; set; }

    [Display(Name = "Préfixe téléphonique"), Column("prefix_tel"), Required]
    public string PrefixTel { get; set; }

}
