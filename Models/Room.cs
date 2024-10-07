using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;

[Table("rooms")]
public class Room
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("room_number")]
    public string RoomNumber { get; set; }
    [Column("room_type_id")]
    public int RoomTypeId { get; set; }
    [Column("room_type")]
    public RoomType RoomType { get; set; }
    [Column("price_per_night")]
    public double PricePerNight { get; set; }
    [Column("availability")]
    public bool Availability { get; set; }
    [Column("max_persons")]
    public int MaxPerson { get; set; }
    
}