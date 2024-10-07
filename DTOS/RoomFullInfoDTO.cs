using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.DTOS
{
    public class RoomFullInfoDTO
    {
        public int RoomId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeDescription { get; set; }
        public int Capacity { get; set; }
        public decimal RoomPrice { get; set; }

    }
}