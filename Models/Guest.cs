using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
[Table("guests")]
public class Guest
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("identification_number")]
    public string IdentificationNumber { get; set; }
    [Column("phone_number")]
    public string PhoneNumber { get; set; }
    [Column("birthdate")]
    public DateOnly Birthdate { get; set; }
}