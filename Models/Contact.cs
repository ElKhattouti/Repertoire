using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Contact
{
    public int ContactId { get; set; }
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public string Telephone { get; set; }
    public int AddresseId { get; set; }
    public string Tva { get; set; }
}
