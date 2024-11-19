using System.ComponentModel.DataAnnotations.Schema;

namespace Web_App.Models;

[Table("Organization")]
public class OrganizationEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Regon { get; set; }
    public string Nip { get; set; }
    public Adress? Address { get; set; }
    public ISet<ContactEntity> Contacts { get; set; }
}

public class Adress 
{
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}