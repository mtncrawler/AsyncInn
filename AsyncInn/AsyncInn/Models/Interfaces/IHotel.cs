using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotel
    {
        Task AddHotel(Hotel hotel);

        Task UpdateHotel(Hotel hotel);

        Task DeleteHotel(Hotel hotel);

        Task<List<Hotel>> GetHotels();


    }
}
