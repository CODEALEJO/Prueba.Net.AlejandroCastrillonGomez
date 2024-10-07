using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Data;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.DTOS;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;

public class RoomServices : IRoomInterface
{
    private readonly ApplicationDbcontext _context;

    public RoomServices(ApplicationDbcontext context)
    {
        _context = context;
    }

    
    public async Task<IEnumerable<RoomFullInfoDTO>> GetRoomTypes()
    {
        var roomTypes = await _context.RoomTypes
            .Include(rt => rt.Rooms)
            .ToListAsync();

        return roomTypes.Select(roomType => new RoomFullInfoDTO
        {
            RoomTypeName = roomType.Name,
            RoomTypeDescription = roomType.Description,
            Capacity = roomType.Rooms.Any() ? roomType.Rooms.Max(r => r.MaxPerson) : 0,
            RoomPrice = roomType.Rooms.Any() ? roomType.Rooms.Min(r => (decimal)r.PricePerNight) : 0m
        });
    }

    
    public async Task<IEnumerable<Room>> GetRoomsAvailable()
    {
        return await _context.Rooms
            .Where(r => r.Availability == true)
            .ToListAsync();
    }

    
    public async Task<RoomFullInfoDTO> GetRoomTypeById(int id)
    {
        var roomType = await _context.RoomTypes
            .Include(rt => rt.Rooms)
            .FirstOrDefaultAsync(rt => rt.Id == id);

        if (roomType == null) return null;

        return new RoomFullInfoDTO
        {
            RoomTypeName = roomType.Name,
            RoomTypeDescription = roomType.Description,
            Capacity = roomType.Rooms.Any() ? roomType.Rooms.Max(r => r.MaxPerson) : 0,
            RoomPrice = roomType.Rooms.Any() ? roomType.Rooms.Min(r => (decimal)r.PricePerNight) : 0m
        };
    }

    
    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Rooms.AnyAsync(r => r.Id == id);
    }
}
