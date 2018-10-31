using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoom
    {
        Task AddRoom(Room room);

        Task UpdateRoom(Room room);

        Task DeleteRoom(int id);

        Task<List<Room>> GetRooms();

        Task<Room> GetRoom(int? id);
    }
}
