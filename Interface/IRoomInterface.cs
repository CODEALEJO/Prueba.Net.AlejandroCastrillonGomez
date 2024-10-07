using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.DTOS;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface
{
    public interface IRoomInterface
    {
        Task<IEnumerable<RoomFullInfoDTO>> GetRoomTypes(); 
        Task<IEnumerable<Room>> GetRoomsAvailable();
        Task<RoomFullInfoDTO> GetRoomTypeById(int id);
        Task<bool> CheckExistence(int id);

    }
}