using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class Customer
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string FirstName { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string LastName { get; set; }
    [EmailAddress (ErrorMessage = "Invalid Email Address")]
    [Column(TypeName = "varchar(250)")]
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}